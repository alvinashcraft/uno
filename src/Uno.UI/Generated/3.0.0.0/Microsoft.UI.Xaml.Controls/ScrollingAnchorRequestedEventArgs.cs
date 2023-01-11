#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Controls
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class ScrollingAnchorRequestedEventArgs 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Microsoft.UI.Xaml.UIElement AnchorElement
		{
			get
			{
				throw new global::System.NotImplementedException("The member UIElement ScrollingAnchorRequestedEventArgs.AnchorElement is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.ScrollingAnchorRequestedEventArgs", "UIElement ScrollingAnchorRequestedEventArgs.AnchorElement");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::System.Collections.Generic.IList<global::Microsoft.UI.Xaml.UIElement> AnchorCandidates
		{
			get
			{
				throw new global::System.NotImplementedException("The member IList<UIElement> ScrollingAnchorRequestedEventArgs.AnchorCandidates is not implemented in Uno.");
			}
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ScrollingAnchorRequestedEventArgs.AnchorCandidates.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ScrollingAnchorRequestedEventArgs.AnchorElement.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ScrollingAnchorRequestedEventArgs.AnchorElement.set
	}
}
