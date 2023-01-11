#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.Web.WebView2.Core
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class CoreWebView2NavigationStartingEventArgs 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  bool Cancel
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool CoreWebView2NavigationStartingEventArgs.Cancel is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.Web.WebView2.Core.CoreWebView2NavigationStartingEventArgs", "bool CoreWebView2NavigationStartingEventArgs.Cancel");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  bool IsRedirected
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool CoreWebView2NavigationStartingEventArgs.IsRedirected is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  bool IsUserInitiated
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool CoreWebView2NavigationStartingEventArgs.IsUserInitiated is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  ulong NavigationId
		{
			get
			{
				throw new global::System.NotImplementedException("The member ulong CoreWebView2NavigationStartingEventArgs.NavigationId is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Microsoft.Web.WebView2.Core.CoreWebView2HttpRequestHeaders RequestHeaders
		{
			get
			{
				throw new global::System.NotImplementedException("The member CoreWebView2HttpRequestHeaders CoreWebView2NavigationStartingEventArgs.RequestHeaders is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  string Uri
		{
			get
			{
				throw new global::System.NotImplementedException("The member string CoreWebView2NavigationStartingEventArgs.Uri is not implemented in Uno.");
			}
		}
		#endif
		// Forced skipping of method Microsoft.Web.WebView2.Core.CoreWebView2NavigationStartingEventArgs.Uri.get
		// Forced skipping of method Microsoft.Web.WebView2.Core.CoreWebView2NavigationStartingEventArgs.IsUserInitiated.get
		// Forced skipping of method Microsoft.Web.WebView2.Core.CoreWebView2NavigationStartingEventArgs.IsRedirected.get
		// Forced skipping of method Microsoft.Web.WebView2.Core.CoreWebView2NavigationStartingEventArgs.RequestHeaders.get
		// Forced skipping of method Microsoft.Web.WebView2.Core.CoreWebView2NavigationStartingEventArgs.Cancel.get
		// Forced skipping of method Microsoft.Web.WebView2.Core.CoreWebView2NavigationStartingEventArgs.Cancel.set
		// Forced skipping of method Microsoft.Web.WebView2.Core.CoreWebView2NavigationStartingEventArgs.NavigationId.get
	}
}
