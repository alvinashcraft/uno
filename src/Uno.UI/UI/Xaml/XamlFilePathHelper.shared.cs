﻿using System;
using System.Globalization;
using System.IO;
using Uno.Extensions;

namespace Uno.UI.Xaml
{
	internal static class XamlFilePathHelper
	{
		private const string WinUIThemeResourceURLFormatString = "Microsoft.UI.Xaml/Themes/themeresources_v{0}.xaml";
		public const string AppXIdentifier = "ms-appx:///";
		public const string MSResourceIdentifier = "ms-resource:///";
		public static string LocalResourcePrefix => $"{MSResourceIdentifier}Files/";
		public const string WinUICompactURL = "Microsoft.UI.Xaml/DensityStyles/Compact.xaml";

		/// <summary>
		/// Convert relative source path to absolute path.
		/// </summary>
		internal static string ResolveAbsoluteSource(string origin, string relativeTargetPath)
		{
			if (IsAbsolutePath(relativeTargetPath))
			{
				// The path is already absolute. (Currently we assume it's in the local assembly.)
				var trimmedPath = relativeTargetPath.TrimStart(AppXIdentifier);
				return trimmedPath;
			}
			else if (relativeTargetPath.StartsWith("/", StringComparison.Ordinal))
			{
				// Paths that start with '/' mean they're relative to the root (ie, absolute paths).
				// We remove the leading / because that's what the callers expect.
				return relativeTargetPath.Substring(1);
			}

			var originDirectory = Path.GetDirectoryName(origin);
			if (originDirectory.IsNullOrWhiteSpace())
			{
				return relativeTargetPath;
			}

			var absoluteTargetPath = GetAbsolutePath(originDirectory, relativeTargetPath);

			return absoluteTargetPath.Replace('\\', '/');
		}

		internal static bool IsAbsolutePath(string relativeTargetPath) => relativeTargetPath.StartsWith(AppXIdentifier, StringComparison.Ordinal)
			|| relativeTargetPath.StartsWith(MSResourceIdentifier, StringComparison.Ordinal);

		internal static string GetWinUIThemeResourceUrl(int version) => string.Format(CultureInfo.InvariantCulture, WinUIThemeResourceURLFormatString, version);

		private static string GetAbsolutePath(string originDirectory, string relativeTargetPath)
		{
			var addedRootLength = 0;
			if (Path.GetPathRoot(originDirectory).Length == 0)
			{
				var localRoot = Path.GetPathRoot(Directory.GetCurrentDirectory());
				addedRootLength = localRoot.Length;
				// Prepend a dummy root so that GetFullPath doesn't try to add the working directory. We remove it immediately afterward.
				originDirectory = localRoot + originDirectory;
			}
			var absoluteTargetPath = Path.GetFullPath(
					Path.Combine(originDirectory, relativeTargetPath)
				);

			absoluteTargetPath = absoluteTargetPath.Substring(addedRootLength);

			return absoluteTargetPath;
		}
	}
}
