﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Windows.Devices.Input;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using SamplesApp.UITests.Extensions;
using SamplesApp.UITests.TestFramework;
using Uno.UITest;
using Uno.UITest.Helpers;
using Uno.UITest.Helpers.Queries;
using Uno.UITests.Helpers;

namespace SamplesApp.UITests
{
	public partial class SampleControlUITestBase
	{
		protected IApp _app;
		private static int _totalTestFixtureCount;
		private static bool _firstRun = true;
		private DateTime _startTime;
		private readonly string _screenShotPath = Environment.GetEnvironmentVariable("UNO_UITEST_SCREENSHOT_PATH");


		[OneTimeSetUp]
		public void SingleSetup()
		{
			ValidateAppMode();
		}

		protected IApp App => _app;

		static SampleControlUITestBase()
		{
			AppInitializer.TestEnvironment.AndroidAppName = Constants.AndroidAppName;
			AppInitializer.TestEnvironment.WebAssemblyDefaultUri = Constants.WebAssemblyDefaultUri;
			AppInitializer.TestEnvironment.iOSAppName = Constants.iOSAppName;
			AppInitializer.TestEnvironment.AndroidAppName = Constants.AndroidAppName;
			AppInitializer.TestEnvironment.iOSDeviceNameOrId = Constants.iOSDeviceNameOrId;
			AppInitializer.TestEnvironment.CurrentPlatform = Constants.CurrentPlatform;

#if DEBUG
			Console.WriteLine("*** WARNING Running Chrome with a head, this will fail when running in CI ***");
			AppInitializer.TestEnvironment.WebAssemblyHeadless = false;
#endif

			// Uncomment to align with your own environment
			// Environment.SetEnvironmentVariable("ANDROID_HOME", @"C:\Program Files (x86)\Android\android-sdk");
			// Environment.SetEnvironmentVariable("JAVA_HOME", @"C:\Program Files\Microsoft\jdk-11.0.12.7-hotspot");

			// Start the app only once, so the tests runs don't restart it
			// and gain some time for the tests.
			AppInitializer.ColdStartApp();
		}

		/// <summary>
		/// Gets the default pointer type for the current platform
		/// </summary>
		public PointerDeviceType DefaultPointerType => AppInitializer.GetLocalPlatform() switch
		{
			Platform.Browser => PointerDeviceType.Mouse,
			Platform.iOS => PointerDeviceType.Touch,
			Platform.Android => PointerDeviceType.Touch,
			_ => throw new InvalidOperationException($"Unknown platform '{AppInitializer.GetLocalPlatform()}'.")
		};

		public PointerDeviceType CurrentPointerType => DefaultPointerType; // We cannot change pointer type on this platform

		public void ValidateAppMode()
		{
			if(GetCurrentFixtureAttributes<TestAppModeAttribute>().FirstOrDefault() is TestAppModeAttribute testAppMode)
			{
				if(
					_totalTestFixtureCount != 0
					&& testAppMode.CleanEnvironment
					&& testAppMode.Platform == AppInitializer.GetLocalPlatform()
				)
				{
					// If this is not the first run, and the fixture requested a clean environment, request a cold start.
					// If this is the first run, as the app is cold-started during the type constructor, we can skip this.
					_app = AppInitializer.ColdStartApp();
				}
			}

			_totalTestFixtureCount++;
		}

		[SetUp]
		[AutoRetry]
		public void BeforeEachTest()
		{
			_startTime = DateTime.Now;

			ValidateAutoRetry();

			// Check if the test needs to be ignore or not
			// If nothing specified, it is considered as a global test
			var platforms = GetActivePlatforms().Distinct().ToArray();
			if (platforms.Length != 0)
			{
				// Otherwise, we need to define on which platform the test is running and compare it with targeted platform
				var shouldIgnore = false;
				var currentPlatform = AppInitializer.GetLocalPlatform();

				if (_app is Uno.UITest.Xamarin.XamarinApp xa)
				{
					if (Xamarin.UITest.TestEnvironment.Platform == Xamarin.UITest.TestPlatform.Local)
					{
						shouldIgnore = !platforms.Contains(currentPlatform);
					}
					else
					{
						var testCloudPlatform = Xamarin.UITest.TestEnvironment.Platform == Xamarin.UITest.TestPlatform.TestCloudiOS
							? Platform.iOS
							: Platform.Android;

						shouldIgnore = !platforms.Contains(testCloudPlatform);
					}
				}
				else
				{
					shouldIgnore = !platforms.Contains(currentPlatform);
				}

				if (shouldIgnore)
				{
					var list = string.Join(", ", platforms.Select(p => p.ToString()));

					Assert.Ignore($"This test is ignored on this platform (runs on {list})");
				}
			}

			var app = AppInitializer.AttachToApp();
			_app = app ?? _app;

			Helpers.App = _app;
		}

		[TearDown]
		public void AfterEachTest()
		{
			if (
				TestContext.CurrentContext.Result.Outcome != ResultState.Success
				&& TestContext.CurrentContext.Result.Outcome != ResultState.Skipped
				&& TestContext.CurrentContext.Result.Outcome != ResultState.Ignored
			)
			{
				TakeScreenshot($"{TestContext.CurrentContext.Test.Name} - Tear down on error", ignoreInSnapshotCompare: true);
			}

			WriteSystemLogs(GetCurrentStepTitle("log"));
		}

		private void WriteSystemLogs(string fileName)
		{
			if (_app != null && AppInitializer.GetLocalPlatform() == Platform.Browser)
			{
				var outputPath = string.IsNullOrEmpty(_screenShotPath)
					? Environment.CurrentDirectory
					: _screenShotPath;

				using (var logOutput = new StreamWriter(Path.Combine(outputPath, $"{fileName}_{DateTime.Now:yyyy-MM-dd-HH-mm-ss.fff}.txt")))
				{
					foreach (var log in _app.GetSystemLogs(_startTime.ToUniversalTime()))
					{
						logOutput.WriteLine($"{log.Timestamp}/{log.Level}: {log.Message}");
					}
				}
			}
		}

		public ScreenshotInfo TakeScreenshot(string stepName, bool? ignoreInSnapshotCompare = null)
			=> TakeScreenshot(
				stepName,
				ignoreInSnapshotCompare != null
					? new ScreenshotOptions { IgnoreInSnapshotCompare = ignoreInSnapshotCompare.Value }
					: null
			);

		public ScreenshotInfo TakeScreenshot(string stepName, ScreenshotOptions options)
		{
			if (_app == null)
			{
				Console.WriteLine($"Skipping TakeScreenshot _app is not available");
				return null;
			}

			var title = GetCurrentStepTitle(stepName);
			var fileInfo = GetNativeScreenshot(title);

			var fileNameWithoutExt = Path.GetFileNameWithoutExtension(fileInfo.Name);
			if (fileNameWithoutExt != title)
			{
				var outputPath = string.IsNullOrEmpty(_screenShotPath)
					? Path.GetDirectoryName(fileInfo.FullName)
					: _screenShotPath;
				var destFileName = Path
					.Combine(outputPath, title + Path.GetExtension(fileInfo.Name))
					.GetNormalizedLongPath();

				if (File.Exists(destFileName))
				{
					File.Delete(destFileName);
				}

				File.Move(fileInfo.FullName, destFileName);

				TestContext.AddTestAttachment(destFileName, stepName);

				fileInfo = new FileInfo(destFileName);
			}
			else
			{
				TestContext.AddTestAttachment(fileInfo.FullName, stepName);
			}

			if (options != null)
			{
				SetOptions(fileInfo, options);
			}

			return new ScreenshotInfo(fileInfo, stepName);
		}

		private FileInfo GetNativeScreenshot(string title)
		{
			if (AppInitializer.GetLocalPlatform() == Platform.Android)
			{
				return _app.GetInAppScreenshot();
			}
			else
			{
				return _app.Screenshot(title);
			}
		}

		private static string GetCurrentStepTitle(string stepName) =>
					$"{TestContext.CurrentContext.Test.Name}_{stepName}"
						.Replace(" ", "_")
						.Replace(".", "_")
						.Replace(":", "_")
						.Replace("(", "")
						.Replace(")", "")
						.Replace("\"", "")
						.Replace(",", "_")
						.Replace("__", "_");

		public void SetOptions(FileInfo screenshot, ScreenshotOptions options)
		{
			var fileName = Path
				.Combine(screenshot.DirectoryName, Path.GetFileNameWithoutExtension(screenshot.FullName) + ".metadata")
				.GetNormalizedLongPath();

			File.WriteAllText(fileName, $"IgnoreInSnapshotCompare={options.IgnoreInSnapshotCompare}");
		}

		private static void ValidateAutoRetry()
		{
			if (GetCurrentTestAttributes<AutoRetryAttribute>().Length == 0)
			{
				Assert.Fail($"The AutoRetryAttribute is not defined for this test");
			}
		}

		private static T[] GetCurrentFixtureAttributes<T>() where T : Attribute
		{
			var testType = Type.GetType(TestContext.CurrentContext.Test.ClassName);
			return testType?.GetCustomAttributes(typeof(T), true) is T[] array ? array : new T[0];
		}

		private static T[] GetCurrentTestAttributes<T>() where T : Attribute
		{
			var testType = Type.GetType(TestContext.CurrentContext.Test.ClassName);
			var methodInfo = testType?.GetMethod(TestContext.CurrentContext.Test.MethodName);
			return methodInfo?.GetCustomAttributes(typeof(T), true) is T[] array ? array : new T[0];
		}

		private IEnumerable<Platform> GetActivePlatforms()
		{
			var currentTest = TestContext.CurrentContext.Test;
			if (currentTest.ClassName == null)
			{
				yield break;
			}
			if (Type.GetType(currentTest.ClassName) is { } classType)
			{
				if (classType.GetCustomAttributes(typeof(ActivePlatformsAttribute), false) is
					ActivePlatformsAttribute[] classAttributes)
				{
					foreach (var attr in classAttributes)
					{
						if (attr.Error is not null)
						{
							throw attr.Error;
						}

						if (attr.Platforms == null)
						{
							continue;
						}

						foreach (var platform in attr.Platforms)
						{
							yield return platform;
						}
					}
				}

				if (currentTest.MethodName is { })
				{
					var testMethodInfo = classType.GetMethod(currentTest.MethodName);

					if (testMethodInfo is { } mi &&
					    mi.GetCustomAttributes(typeof(ActivePlatformsAttribute), false) is
						    ActivePlatformsAttribute[] methodAttributes)
					{
						foreach (var attr in methodAttributes)
						{
							if (attr.Error is not null)
							{
								throw attr.Error;
							}

							if (attr.Platforms == null)
							{
								continue;
							}

							foreach (var platform in attr.Platforms)
							{
								yield return platform;
							}
						}
					}
				}

			}
		}

		protected Task RunAsync(string metadataName, bool waitForSampleControl = true, bool skipInitialScreenshot = false, int sampleLoadTimeout = 5)
		{
			Run(metadataName, waitForSampleControl, skipInitialScreenshot, sampleLoadTimeout);
			return Task.CompletedTask;
		}

		protected void Run(string metadataName, bool waitForSampleControl = true, bool skipInitialScreenshot = false, int sampleLoadTimeout = 5)
		{
			if (waitForSampleControl)
			{
				var sampleControlQuery = AppInitializer.GetLocalPlatform() == Platform.Browser
					? new QueryEx(q => q.Marked("sampleControl"))
					: new QueryEx(q => q.All().Marked("sampleControl"));

				_app.WaitForElement(sampleControlQuery, timeout: TimeSpan.FromSeconds(sampleLoadTimeout));

				if (_firstRun)
				{
					_firstRun = false;
					WriteSystemLogs("AppStartup");
				}
			}

			var testRunId = _app.InvokeGeneric("browser:SampleRunner|RunTest", metadataName);

			_app.WaitFor(() =>
			{
				var result = _app.InvokeGeneric("browser:SampleRunner|IsTestDone", testRunId).ToString();
				return bool.TryParse(result, out var testDone) && testDone;
			}, retryFrequency: TimeSpan.FromMilliseconds(50));

			if (!skipInitialScreenshot)
			{
				TakeScreenshot(metadataName.Replace(".", "_"));
			}
		}

		internal IAppRect GetScreenDimensions()
		{
			if (AppInitializer.GetLocalPlatform() == Platform.Browser)
			{
				var sampleControl = _app.Marked("sampleControl");

				return _app.WaitForElement(sampleControl).First().Rect;
			}
			else
			{
				return _app.GetScreenDimensions();
			}
		}

		private class PhysicalRect : IAppRect
		{
			public PhysicalRect(IAppRect logicalRect, double scaling)
			{
				var s = (float)scaling;
				Bottom = logicalRect.Bottom * s;
				Right = logicalRect.Right * s;
				CenterY = logicalRect.CenterY * s;
				CenterX = logicalRect.CenterX * s;
				Y = logicalRect.Y * s;
				X = logicalRect.X * s;
				Height = logicalRect.Height * s;
				Width = logicalRect.Width * s;
			}

			public float Width { get; }
			public float Height { get; }
			public float X { get; }
			public float Y { get; }
			public float CenterX { get; }
			public float CenterY { get; }
			public float Right { get; }
			public float Bottom { get; }
		}

		public IAppRect ToPhysicalRect(IAppRect logicalRect)
		{
			if (logicalRect is PhysicalRect p)
			{
				return p;
			}
			return new PhysicalRect(logicalRect, GetDisplayScreenScaling());
		}

		internal float GetDisplayScreenScaling() => _app.GetDisplayScreenScaling();

		internal float LogicalToPhysical(float logical) => logical * GetDisplayScreenScaling();

		internal float PhysicalToLogical(float physical) => physical / GetDisplayScreenScaling();

		protected bool GetIsCurrentRotationLandscape(string elementName)
		{
			if (!GetSupportsRotation())
			{
				return true;
			}

			var sampleRect = _app.GetPhysicalRect(elementName);
			var b = sampleRect.Width > sampleRect.Height;
			return b;
		}

		protected static bool GetSupportsRotation()
		{
			var currentPlatform = AppInitializer.GetLocalPlatform();
			var supportsRotation = currentPlatform == Platform.Android || currentPlatform == Platform.iOS;
			return supportsRotation;
		}

		protected static bool GetIsTouchInteraction()
		{
			var currentPlatform = AppInitializer.GetLocalPlatform();
			return currentPlatform == Platform.Android || currentPlatform == Platform.iOS;
		}
	}
}
