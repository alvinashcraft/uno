#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Media
{
	#if false || false || false || false || false || false || false
	[global::Uno.NotImplemented]
	#endif
	public  partial class RevealBrush : global::Microsoft.UI.Xaml.Media.XamlCompositionBrushBase
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Microsoft.UI.Xaml.ApplicationTheme TargetTheme
		{
			get
			{
				return (global::Microsoft.UI.Xaml.ApplicationTheme)this.GetValue(TargetThemeProperty);
			}
			set
			{
				this.SetValue(TargetThemeProperty, value);
			}
		}
		#endif
		// Skipping already declared property Color
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  bool AlwaysUseFallback
		{
			get
			{
				return (bool)this.GetValue(AlwaysUseFallbackProperty);
			}
			set
			{
				this.SetValue(AlwaysUseFallbackProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Microsoft.UI.Xaml.DependencyProperty AlwaysUseFallbackProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(AlwaysUseFallback), typeof(bool), 
			typeof(global::Microsoft.UI.Xaml.Media.RevealBrush), 
			new FrameworkPropertyMetadata(default(bool)));
		#endif
		// Skipping already declared property ColorProperty
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Microsoft.UI.Xaml.DependencyProperty StateProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.RegisterAttached(
			"State", typeof(global::Microsoft.UI.Xaml.Media.RevealBrushState), 
			typeof(global::Microsoft.UI.Xaml.Media.RevealBrush), 
			new FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.Media.RevealBrushState)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Microsoft.UI.Xaml.DependencyProperty TargetThemeProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(TargetTheme), typeof(global::Microsoft.UI.Xaml.ApplicationTheme), 
			typeof(global::Microsoft.UI.Xaml.Media.RevealBrush), 
			new FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.ApplicationTheme)));
		#endif
		// Skipping already declared method Microsoft.UI.Xaml.Media.RevealBrush.RevealBrush()
		// Forced skipping of method Microsoft.UI.Xaml.Media.RevealBrush.RevealBrush()
		// Forced skipping of method Microsoft.UI.Xaml.Media.RevealBrush.Color.get
		// Forced skipping of method Microsoft.UI.Xaml.Media.RevealBrush.Color.set
		// Forced skipping of method Microsoft.UI.Xaml.Media.RevealBrush.TargetTheme.get
		// Forced skipping of method Microsoft.UI.Xaml.Media.RevealBrush.TargetTheme.set
		// Forced skipping of method Microsoft.UI.Xaml.Media.RevealBrush.AlwaysUseFallback.get
		// Forced skipping of method Microsoft.UI.Xaml.Media.RevealBrush.AlwaysUseFallback.set
		// Forced skipping of method Microsoft.UI.Xaml.Media.RevealBrush.ColorProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Media.RevealBrush.TargetThemeProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Media.RevealBrush.AlwaysUseFallbackProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Media.RevealBrush.StateProperty.get
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static void SetState( global::Microsoft.UI.Xaml.UIElement element,  global::Microsoft.UI.Xaml.Media.RevealBrushState value)
		{
			element.SetValue(StateProperty, value);
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Microsoft.UI.Xaml.Media.RevealBrushState GetState( global::Microsoft.UI.Xaml.UIElement element)
		{
			return (global::Microsoft.UI.Xaml.Media.RevealBrushState)element.GetValue(StateProperty);
		}
		#endif
	}
}
