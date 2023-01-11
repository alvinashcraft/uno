#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Controls.Primitives
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class ScrollControllerScrollByRequestedEventArgs 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  int CorrelationId
		{
			get
			{
				throw new global::System.NotImplementedException("The member int ScrollControllerScrollByRequestedEventArgs.CorrelationId is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.Primitives.ScrollControllerScrollByRequestedEventArgs", "int ScrollControllerScrollByRequestedEventArgs.CorrelationId");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  double OffsetDelta
		{
			get
			{
				throw new global::System.NotImplementedException("The member double ScrollControllerScrollByRequestedEventArgs.OffsetDelta is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Microsoft.UI.Xaml.Controls.ScrollingScrollOptions Options
		{
			get
			{
				throw new global::System.NotImplementedException("The member ScrollingScrollOptions ScrollControllerScrollByRequestedEventArgs.Options is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public ScrollControllerScrollByRequestedEventArgs( double offsetDelta,  global::Microsoft.UI.Xaml.Controls.ScrollingScrollOptions options) 
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.Primitives.ScrollControllerScrollByRequestedEventArgs", "ScrollControllerScrollByRequestedEventArgs.ScrollControllerScrollByRequestedEventArgs(double offsetDelta, ScrollingScrollOptions options)");
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.ScrollControllerScrollByRequestedEventArgs.ScrollControllerScrollByRequestedEventArgs(double, Microsoft.UI.Xaml.Controls.ScrollingScrollOptions)
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.ScrollControllerScrollByRequestedEventArgs.OffsetDelta.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.ScrollControllerScrollByRequestedEventArgs.Options.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.ScrollControllerScrollByRequestedEventArgs.CorrelationId.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.ScrollControllerScrollByRequestedEventArgs.CorrelationId.set
	}
}
