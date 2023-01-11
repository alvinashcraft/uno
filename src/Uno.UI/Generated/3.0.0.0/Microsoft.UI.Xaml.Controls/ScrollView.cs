#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Controls
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class ScrollView : global::Microsoft.UI.Xaml.Controls.Control
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Microsoft.UI.Xaml.Controls.ScrollingZoomMode ZoomMode
		{
			get
			{
				return (global::Microsoft.UI.Xaml.Controls.ScrollingZoomMode)this.GetValue(ZoomModeProperty);
			}
			set
			{
				this.SetValue(ZoomModeProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Microsoft.UI.Xaml.Controls.ScrollingChainMode ZoomChainMode
		{
			get
			{
				return (global::Microsoft.UI.Xaml.Controls.ScrollingChainMode)this.GetValue(ZoomChainModeProperty);
			}
			set
			{
				this.SetValue(ZoomChainModeProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Microsoft.UI.Xaml.Controls.ScrollingRailMode VerticalScrollRailMode
		{
			get
			{
				return (global::Microsoft.UI.Xaml.Controls.ScrollingRailMode)this.GetValue(VerticalScrollRailModeProperty);
			}
			set
			{
				this.SetValue(VerticalScrollRailModeProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Microsoft.UI.Xaml.Controls.ScrollingScrollMode VerticalScrollMode
		{
			get
			{
				return (global::Microsoft.UI.Xaml.Controls.ScrollingScrollMode)this.GetValue(VerticalScrollModeProperty);
			}
			set
			{
				this.SetValue(VerticalScrollModeProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Microsoft.UI.Xaml.Controls.ScrollingChainMode VerticalScrollChainMode
		{
			get
			{
				return (global::Microsoft.UI.Xaml.Controls.ScrollingChainMode)this.GetValue(VerticalScrollChainModeProperty);
			}
			set
			{
				this.SetValue(VerticalScrollChainModeProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Microsoft.UI.Xaml.Controls.ScrollingScrollBarVisibility VerticalScrollBarVisibility
		{
			get
			{
				return (global::Microsoft.UI.Xaml.Controls.ScrollingScrollBarVisibility)this.GetValue(VerticalScrollBarVisibilityProperty);
			}
			set
			{
				this.SetValue(VerticalScrollBarVisibilityProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  double VerticalAnchorRatio
		{
			get
			{
				return (double)this.GetValue(VerticalAnchorRatioProperty);
			}
			set
			{
				this.SetValue(VerticalAnchorRatioProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  double MinZoomFactor
		{
			get
			{
				return (double)this.GetValue(MinZoomFactorProperty);
			}
			set
			{
				this.SetValue(MinZoomFactorProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  double MaxZoomFactor
		{
			get
			{
				return (double)this.GetValue(MaxZoomFactorProperty);
			}
			set
			{
				this.SetValue(MaxZoomFactorProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Microsoft.UI.Xaml.Controls.ScrollingInputKinds IgnoredInputKinds
		{
			get
			{
				return (global::Microsoft.UI.Xaml.Controls.ScrollingInputKinds)this.GetValue(IgnoredInputKindsProperty);
			}
			set
			{
				this.SetValue(IgnoredInputKindsProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Microsoft.UI.Xaml.Controls.ScrollingRailMode HorizontalScrollRailMode
		{
			get
			{
				return (global::Microsoft.UI.Xaml.Controls.ScrollingRailMode)this.GetValue(HorizontalScrollRailModeProperty);
			}
			set
			{
				this.SetValue(HorizontalScrollRailModeProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Microsoft.UI.Xaml.Controls.ScrollingScrollMode HorizontalScrollMode
		{
			get
			{
				return (global::Microsoft.UI.Xaml.Controls.ScrollingScrollMode)this.GetValue(HorizontalScrollModeProperty);
			}
			set
			{
				this.SetValue(HorizontalScrollModeProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Microsoft.UI.Xaml.Controls.ScrollingChainMode HorizontalScrollChainMode
		{
			get
			{
				return (global::Microsoft.UI.Xaml.Controls.ScrollingChainMode)this.GetValue(HorizontalScrollChainModeProperty);
			}
			set
			{
				this.SetValue(HorizontalScrollChainModeProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Microsoft.UI.Xaml.Controls.ScrollingScrollBarVisibility HorizontalScrollBarVisibility
		{
			get
			{
				return (global::Microsoft.UI.Xaml.Controls.ScrollingScrollBarVisibility)this.GetValue(HorizontalScrollBarVisibilityProperty);
			}
			set
			{
				this.SetValue(HorizontalScrollBarVisibilityProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  double HorizontalAnchorRatio
		{
			get
			{
				return (double)this.GetValue(HorizontalAnchorRatioProperty);
			}
			set
			{
				this.SetValue(HorizontalAnchorRatioProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Microsoft.UI.Xaml.Controls.ScrollingContentOrientation ContentOrientation
		{
			get
			{
				return (global::Microsoft.UI.Xaml.Controls.ScrollingContentOrientation)this.GetValue(ContentOrientationProperty);
			}
			set
			{
				this.SetValue(ContentOrientationProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Microsoft.UI.Xaml.UIElement Content
		{
			get
			{
				return (global::Microsoft.UI.Xaml.UIElement)this.GetValue(ContentProperty);
			}
			set
			{
				this.SetValue(ContentProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Microsoft.UI.Xaml.Visibility ComputedHorizontalScrollBarVisibility
		{
			get
			{
				return (global::Microsoft.UI.Xaml.Visibility)this.GetValue(ComputedHorizontalScrollBarVisibilityProperty);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Microsoft.UI.Xaml.Visibility ComputedVerticalScrollBarVisibility
		{
			get
			{
				return (global::Microsoft.UI.Xaml.Visibility)this.GetValue(ComputedVerticalScrollBarVisibilityProperty);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Microsoft.UI.Xaml.UIElement CurrentAnchor
		{
			get
			{
				throw new global::System.NotImplementedException("The member UIElement ScrollView.CurrentAnchor is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Microsoft.UI.Composition.CompositionPropertySet ExpressionAnimationSources
		{
			get
			{
				throw new global::System.NotImplementedException("The member CompositionPropertySet ScrollView.ExpressionAnimationSources is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  double ExtentHeight
		{
			get
			{
				throw new global::System.NotImplementedException("The member double ScrollView.ExtentHeight is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  double ExtentWidth
		{
			get
			{
				throw new global::System.NotImplementedException("The member double ScrollView.ExtentWidth is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  double HorizontalOffset
		{
			get
			{
				throw new global::System.NotImplementedException("The member double ScrollView.HorizontalOffset is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  double ScrollableHeight
		{
			get
			{
				throw new global::System.NotImplementedException("The member double ScrollView.ScrollableHeight is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  double ScrollableWidth
		{
			get
			{
				throw new global::System.NotImplementedException("The member double ScrollView.ScrollableWidth is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Microsoft.UI.Xaml.Controls.ScrollingInteractionState State
		{
			get
			{
				throw new global::System.NotImplementedException("The member ScrollingInteractionState ScrollView.State is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  double VerticalOffset
		{
			get
			{
				throw new global::System.NotImplementedException("The member double ScrollView.VerticalOffset is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  double ViewportHeight
		{
			get
			{
				throw new global::System.NotImplementedException("The member double ScrollView.ViewportHeight is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  double ViewportWidth
		{
			get
			{
				throw new global::System.NotImplementedException("The member double ScrollView.ViewportWidth is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  float ZoomFactor
		{
			get
			{
				throw new global::System.NotImplementedException("The member float ScrollView.ZoomFactor is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Microsoft.UI.Xaml.DependencyProperty ComputedHorizontalScrollBarVisibilityProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(ComputedHorizontalScrollBarVisibility), typeof(global::Microsoft.UI.Xaml.Visibility), 
			typeof(global::Microsoft.UI.Xaml.Controls.ScrollView), 
			new FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.Visibility)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Microsoft.UI.Xaml.DependencyProperty ComputedVerticalScrollBarVisibilityProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(ComputedVerticalScrollBarVisibility), typeof(global::Microsoft.UI.Xaml.Visibility), 
			typeof(global::Microsoft.UI.Xaml.Controls.ScrollView), 
			new FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.Visibility)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Microsoft.UI.Xaml.DependencyProperty ContentOrientationProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(ContentOrientation), typeof(global::Microsoft.UI.Xaml.Controls.ScrollingContentOrientation), 
			typeof(global::Microsoft.UI.Xaml.Controls.ScrollView), 
			new FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.Controls.ScrollingContentOrientation)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Microsoft.UI.Xaml.DependencyProperty ContentProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(Content), typeof(global::Microsoft.UI.Xaml.UIElement), 
			typeof(global::Microsoft.UI.Xaml.Controls.ScrollView), 
			new FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.UIElement)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Microsoft.UI.Xaml.DependencyProperty HorizontalAnchorRatioProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(HorizontalAnchorRatio), typeof(double), 
			typeof(global::Microsoft.UI.Xaml.Controls.ScrollView), 
			new FrameworkPropertyMetadata(default(double)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Microsoft.UI.Xaml.DependencyProperty HorizontalScrollBarVisibilityProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(HorizontalScrollBarVisibility), typeof(global::Microsoft.UI.Xaml.Controls.ScrollingScrollBarVisibility), 
			typeof(global::Microsoft.UI.Xaml.Controls.ScrollView), 
			new FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.Controls.ScrollingScrollBarVisibility)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Microsoft.UI.Xaml.DependencyProperty HorizontalScrollChainModeProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(HorizontalScrollChainMode), typeof(global::Microsoft.UI.Xaml.Controls.ScrollingChainMode), 
			typeof(global::Microsoft.UI.Xaml.Controls.ScrollView), 
			new FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.Controls.ScrollingChainMode)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Microsoft.UI.Xaml.DependencyProperty HorizontalScrollModeProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(HorizontalScrollMode), typeof(global::Microsoft.UI.Xaml.Controls.ScrollingScrollMode), 
			typeof(global::Microsoft.UI.Xaml.Controls.ScrollView), 
			new FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.Controls.ScrollingScrollMode)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Microsoft.UI.Xaml.DependencyProperty HorizontalScrollRailModeProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(HorizontalScrollRailMode), typeof(global::Microsoft.UI.Xaml.Controls.ScrollingRailMode), 
			typeof(global::Microsoft.UI.Xaml.Controls.ScrollView), 
			new FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.Controls.ScrollingRailMode)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Microsoft.UI.Xaml.DependencyProperty IgnoredInputKindsProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(IgnoredInputKinds), typeof(global::Microsoft.UI.Xaml.Controls.ScrollingInputKinds), 
			typeof(global::Microsoft.UI.Xaml.Controls.ScrollView), 
			new FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.Controls.ScrollingInputKinds)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Microsoft.UI.Xaml.DependencyProperty MaxZoomFactorProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(MaxZoomFactor), typeof(double), 
			typeof(global::Microsoft.UI.Xaml.Controls.ScrollView), 
			new FrameworkPropertyMetadata(default(double)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Microsoft.UI.Xaml.DependencyProperty MinZoomFactorProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(MinZoomFactor), typeof(double), 
			typeof(global::Microsoft.UI.Xaml.Controls.ScrollView), 
			new FrameworkPropertyMetadata(default(double)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		// Generating stub ScrollPresenterProperty which has no C# getter
		internal static object ScrollPresenterProperty { get; }
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Microsoft.UI.Xaml.DependencyProperty VerticalAnchorRatioProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(VerticalAnchorRatio), typeof(double), 
			typeof(global::Microsoft.UI.Xaml.Controls.ScrollView), 
			new FrameworkPropertyMetadata(default(double)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Microsoft.UI.Xaml.DependencyProperty VerticalScrollBarVisibilityProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(VerticalScrollBarVisibility), typeof(global::Microsoft.UI.Xaml.Controls.ScrollingScrollBarVisibility), 
			typeof(global::Microsoft.UI.Xaml.Controls.ScrollView), 
			new FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.Controls.ScrollingScrollBarVisibility)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Microsoft.UI.Xaml.DependencyProperty VerticalScrollChainModeProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(VerticalScrollChainMode), typeof(global::Microsoft.UI.Xaml.Controls.ScrollingChainMode), 
			typeof(global::Microsoft.UI.Xaml.Controls.ScrollView), 
			new FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.Controls.ScrollingChainMode)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Microsoft.UI.Xaml.DependencyProperty VerticalScrollModeProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(VerticalScrollMode), typeof(global::Microsoft.UI.Xaml.Controls.ScrollingScrollMode), 
			typeof(global::Microsoft.UI.Xaml.Controls.ScrollView), 
			new FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.Controls.ScrollingScrollMode)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Microsoft.UI.Xaml.DependencyProperty VerticalScrollRailModeProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(VerticalScrollRailMode), typeof(global::Microsoft.UI.Xaml.Controls.ScrollingRailMode), 
			typeof(global::Microsoft.UI.Xaml.Controls.ScrollView), 
			new FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.Controls.ScrollingRailMode)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Microsoft.UI.Xaml.DependencyProperty ZoomChainModeProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(ZoomChainMode), typeof(global::Microsoft.UI.Xaml.Controls.ScrollingChainMode), 
			typeof(global::Microsoft.UI.Xaml.Controls.ScrollView), 
			new FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.Controls.ScrollingChainMode)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Microsoft.UI.Xaml.DependencyProperty ZoomModeProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(ZoomMode), typeof(global::Microsoft.UI.Xaml.Controls.ScrollingZoomMode), 
			typeof(global::Microsoft.UI.Xaml.Controls.ScrollView), 
			new FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.Controls.ScrollingZoomMode)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public ScrollView() : base()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.ScrollView", "ScrollView.ScrollView()");
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ScrollView.ScrollView()
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ScrollView.Content.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ScrollView.Content.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ScrollView.CurrentAnchor.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ScrollView.ExpressionAnimationSources.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ScrollView.HorizontalOffset.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ScrollView.VerticalOffset.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ScrollView.ZoomFactor.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ScrollView.ExtentWidth.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ScrollView.ExtentHeight.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ScrollView.ViewportWidth.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ScrollView.ViewportHeight.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ScrollView.ScrollableWidth.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ScrollView.ScrollableHeight.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ScrollView.State.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ScrollView.HorizontalScrollBarVisibility.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ScrollView.HorizontalScrollBarVisibility.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ScrollView.VerticalScrollBarVisibility.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ScrollView.VerticalScrollBarVisibility.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ScrollView.ContentOrientation.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ScrollView.ContentOrientation.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ScrollView.HorizontalScrollChainMode.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ScrollView.HorizontalScrollChainMode.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ScrollView.VerticalScrollChainMode.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ScrollView.VerticalScrollChainMode.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ScrollView.HorizontalScrollRailMode.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ScrollView.HorizontalScrollRailMode.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ScrollView.VerticalScrollRailMode.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ScrollView.VerticalScrollRailMode.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ScrollView.HorizontalScrollMode.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ScrollView.HorizontalScrollMode.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ScrollView.VerticalScrollMode.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ScrollView.VerticalScrollMode.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ScrollView.ComputedHorizontalScrollBarVisibility.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ScrollView.ComputedVerticalScrollBarVisibility.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ScrollView.ZoomChainMode.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ScrollView.ZoomChainMode.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ScrollView.ZoomMode.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ScrollView.ZoomMode.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ScrollView.IgnoredInputKinds.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ScrollView.IgnoredInputKinds.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ScrollView.MinZoomFactor.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ScrollView.MinZoomFactor.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ScrollView.MaxZoomFactor.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ScrollView.MaxZoomFactor.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ScrollView.HorizontalAnchorRatio.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ScrollView.HorizontalAnchorRatio.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ScrollView.VerticalAnchorRatio.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ScrollView.VerticalAnchorRatio.set
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  void RegisterAnchorCandidate( global::Microsoft.UI.Xaml.UIElement element)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.ScrollView", "void ScrollView.RegisterAnchorCandidate(UIElement element)");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  void UnregisterAnchorCandidate( global::Microsoft.UI.Xaml.UIElement element)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.ScrollView", "void ScrollView.UnregisterAnchorCandidate(UIElement element)");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  int ScrollTo( double horizontalOffset,  double verticalOffset)
		{
			throw new global::System.NotImplementedException("The member int ScrollView.ScrollTo(double horizontalOffset, double verticalOffset) is not implemented in Uno.");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  int ScrollTo( double horizontalOffset,  double verticalOffset,  global::Microsoft.UI.Xaml.Controls.ScrollingScrollOptions options)
		{
			throw new global::System.NotImplementedException("The member int ScrollView.ScrollTo(double horizontalOffset, double verticalOffset, ScrollingScrollOptions options) is not implemented in Uno.");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  int ScrollBy( double horizontalOffsetDelta,  double verticalOffsetDelta)
		{
			throw new global::System.NotImplementedException("The member int ScrollView.ScrollBy(double horizontalOffsetDelta, double verticalOffsetDelta) is not implemented in Uno.");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  int ScrollBy( double horizontalOffsetDelta,  double verticalOffsetDelta,  global::Microsoft.UI.Xaml.Controls.ScrollingScrollOptions options)
		{
			throw new global::System.NotImplementedException("The member int ScrollView.ScrollBy(double horizontalOffsetDelta, double verticalOffsetDelta, ScrollingScrollOptions options) is not implemented in Uno.");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  int AddScrollVelocity( global::System.Numerics.Vector2 offsetsVelocity,  global::System.Numerics.Vector2? inertiaDecayRate)
		{
			throw new global::System.NotImplementedException("The member int ScrollView.AddScrollVelocity(Vector2 offsetsVelocity, Vector2? inertiaDecayRate) is not implemented in Uno.");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  int ZoomTo( float zoomFactor,  global::System.Numerics.Vector2? centerPoint)
		{
			throw new global::System.NotImplementedException("The member int ScrollView.ZoomTo(float zoomFactor, Vector2? centerPoint) is not implemented in Uno.");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  int ZoomTo( float zoomFactor,  global::System.Numerics.Vector2? centerPoint,  global::Microsoft.UI.Xaml.Controls.ScrollingZoomOptions options)
		{
			throw new global::System.NotImplementedException("The member int ScrollView.ZoomTo(float zoomFactor, Vector2? centerPoint, ScrollingZoomOptions options) is not implemented in Uno.");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  int ZoomBy( float zoomFactorDelta,  global::System.Numerics.Vector2? centerPoint)
		{
			throw new global::System.NotImplementedException("The member int ScrollView.ZoomBy(float zoomFactorDelta, Vector2? centerPoint) is not implemented in Uno.");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  int ZoomBy( float zoomFactorDelta,  global::System.Numerics.Vector2? centerPoint,  global::Microsoft.UI.Xaml.Controls.ScrollingZoomOptions options)
		{
			throw new global::System.NotImplementedException("The member int ScrollView.ZoomBy(float zoomFactorDelta, Vector2? centerPoint, ScrollingZoomOptions options) is not implemented in Uno.");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  int AddZoomVelocity( float zoomFactorVelocity,  global::System.Numerics.Vector2? centerPoint,  float? inertiaDecayRate)
		{
			throw new global::System.NotImplementedException("The member int ScrollView.AddZoomVelocity(float zoomFactorVelocity, Vector2? centerPoint, float? inertiaDecayRate) is not implemented in Uno.");
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ScrollView.ExtentChanged.add
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ScrollView.ExtentChanged.remove
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ScrollView.StateChanged.add
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ScrollView.StateChanged.remove
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ScrollView.ViewChanged.add
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ScrollView.ViewChanged.remove
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ScrollView.ScrollAnimationStarting.add
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ScrollView.ScrollAnimationStarting.remove
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ScrollView.ZoomAnimationStarting.add
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ScrollView.ZoomAnimationStarting.remove
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ScrollView.ScrollCompleted.add
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ScrollView.ScrollCompleted.remove
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ScrollView.ZoomCompleted.add
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ScrollView.ZoomCompleted.remove
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ScrollView.BringingIntoView.add
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ScrollView.BringingIntoView.remove
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ScrollView.AnchorRequested.add
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ScrollView.AnchorRequested.remove
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ScrollView.ContentProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ScrollView.ScrollPresenterProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ScrollView.HorizontalScrollBarVisibilityProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ScrollView.VerticalScrollBarVisibilityProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ScrollView.ContentOrientationProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ScrollView.HorizontalScrollChainModeProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ScrollView.VerticalScrollChainModeProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ScrollView.HorizontalScrollRailModeProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ScrollView.VerticalScrollRailModeProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ScrollView.HorizontalScrollModeProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ScrollView.VerticalScrollModeProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ScrollView.ComputedHorizontalScrollBarVisibilityProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ScrollView.ComputedVerticalScrollBarVisibilityProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ScrollView.ZoomChainModeProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ScrollView.ZoomModeProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ScrollView.IgnoredInputKindsProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ScrollView.MinZoomFactorProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ScrollView.MaxZoomFactorProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ScrollView.HorizontalAnchorRatioProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ScrollView.VerticalAnchorRatioProperty.get
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  event global::Windows.Foundation.TypedEventHandler<global::Microsoft.UI.Xaml.Controls.ScrollView, global::Microsoft.UI.Xaml.Controls.ScrollingAnchorRequestedEventArgs> AnchorRequested
		{
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.ScrollView", "event TypedEventHandler<ScrollView, ScrollingAnchorRequestedEventArgs> ScrollView.AnchorRequested");
			}
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.ScrollView", "event TypedEventHandler<ScrollView, ScrollingAnchorRequestedEventArgs> ScrollView.AnchorRequested");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  event global::Windows.Foundation.TypedEventHandler<global::Microsoft.UI.Xaml.Controls.ScrollView, global::Microsoft.UI.Xaml.Controls.ScrollingBringingIntoViewEventArgs> BringingIntoView
		{
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.ScrollView", "event TypedEventHandler<ScrollView, ScrollingBringingIntoViewEventArgs> ScrollView.BringingIntoView");
			}
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.ScrollView", "event TypedEventHandler<ScrollView, ScrollingBringingIntoViewEventArgs> ScrollView.BringingIntoView");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  event global::Windows.Foundation.TypedEventHandler<global::Microsoft.UI.Xaml.Controls.ScrollView, object> ExtentChanged
		{
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.ScrollView", "event TypedEventHandler<ScrollView, object> ScrollView.ExtentChanged");
			}
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.ScrollView", "event TypedEventHandler<ScrollView, object> ScrollView.ExtentChanged");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  event global::Windows.Foundation.TypedEventHandler<global::Microsoft.UI.Xaml.Controls.ScrollView, global::Microsoft.UI.Xaml.Controls.ScrollingScrollAnimationStartingEventArgs> ScrollAnimationStarting
		{
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.ScrollView", "event TypedEventHandler<ScrollView, ScrollingScrollAnimationStartingEventArgs> ScrollView.ScrollAnimationStarting");
			}
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.ScrollView", "event TypedEventHandler<ScrollView, ScrollingScrollAnimationStartingEventArgs> ScrollView.ScrollAnimationStarting");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  event global::Windows.Foundation.TypedEventHandler<global::Microsoft.UI.Xaml.Controls.ScrollView, global::Microsoft.UI.Xaml.Controls.ScrollingScrollCompletedEventArgs> ScrollCompleted
		{
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.ScrollView", "event TypedEventHandler<ScrollView, ScrollingScrollCompletedEventArgs> ScrollView.ScrollCompleted");
			}
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.ScrollView", "event TypedEventHandler<ScrollView, ScrollingScrollCompletedEventArgs> ScrollView.ScrollCompleted");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  event global::Windows.Foundation.TypedEventHandler<global::Microsoft.UI.Xaml.Controls.ScrollView, object> StateChanged
		{
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.ScrollView", "event TypedEventHandler<ScrollView, object> ScrollView.StateChanged");
			}
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.ScrollView", "event TypedEventHandler<ScrollView, object> ScrollView.StateChanged");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  event global::Windows.Foundation.TypedEventHandler<global::Microsoft.UI.Xaml.Controls.ScrollView, object> ViewChanged
		{
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.ScrollView", "event TypedEventHandler<ScrollView, object> ScrollView.ViewChanged");
			}
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.ScrollView", "event TypedEventHandler<ScrollView, object> ScrollView.ViewChanged");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  event global::Windows.Foundation.TypedEventHandler<global::Microsoft.UI.Xaml.Controls.ScrollView, global::Microsoft.UI.Xaml.Controls.ScrollingZoomAnimationStartingEventArgs> ZoomAnimationStarting
		{
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.ScrollView", "event TypedEventHandler<ScrollView, ScrollingZoomAnimationStartingEventArgs> ScrollView.ZoomAnimationStarting");
			}
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.ScrollView", "event TypedEventHandler<ScrollView, ScrollingZoomAnimationStartingEventArgs> ScrollView.ZoomAnimationStarting");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  event global::Windows.Foundation.TypedEventHandler<global::Microsoft.UI.Xaml.Controls.ScrollView, global::Microsoft.UI.Xaml.Controls.ScrollingZoomCompletedEventArgs> ZoomCompleted
		{
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.ScrollView", "event TypedEventHandler<ScrollView, ScrollingZoomCompletedEventArgs> ScrollView.ZoomCompleted");
			}
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.ScrollView", "event TypedEventHandler<ScrollView, ScrollingZoomCompletedEventArgs> ScrollView.ZoomCompleted");
			}
		}
		#endif
	}
}
