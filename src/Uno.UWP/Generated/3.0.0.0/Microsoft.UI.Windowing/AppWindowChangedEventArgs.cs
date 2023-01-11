#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Windowing
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class AppWindowChangedEventArgs 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  bool DidPositionChange
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool AppWindowChangedEventArgs.DidPositionChange is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  bool DidPresenterChange
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool AppWindowChangedEventArgs.DidPresenterChange is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  bool DidSizeChange
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool AppWindowChangedEventArgs.DidSizeChange is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  bool DidVisibilityChange
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool AppWindowChangedEventArgs.DidVisibilityChange is not implemented in Uno.");
			}
		}
		#endif
		// Forced skipping of method Microsoft.UI.Windowing.AppWindowChangedEventArgs.DidPositionChange.get
		// Forced skipping of method Microsoft.UI.Windowing.AppWindowChangedEventArgs.DidPresenterChange.get
		// Forced skipping of method Microsoft.UI.Windowing.AppWindowChangedEventArgs.DidSizeChange.get
		// Forced skipping of method Microsoft.UI.Windowing.AppWindowChangedEventArgs.DidVisibilityChange.get
	}
}
