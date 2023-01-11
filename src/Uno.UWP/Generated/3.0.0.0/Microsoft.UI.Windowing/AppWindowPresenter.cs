#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Windowing
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class AppWindowPresenter 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  bool DoNotActivateWindow
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool AppWindowPresenter.DoNotActivateWindow is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Windowing.AppWindowPresenter", "bool AppWindowPresenter.DoNotActivateWindow");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Microsoft.UI.Windowing.AppWindowPresenterKind Kind
		{
			get
			{
				throw new global::System.NotImplementedException("The member AppWindowPresenterKind AppWindowPresenter.Kind is not implemented in Uno.");
			}
		}
		#endif
		// Forced skipping of method Microsoft.UI.Windowing.AppWindowPresenter.DoNotActivateWindow.get
		// Forced skipping of method Microsoft.UI.Windowing.AppWindowPresenter.DoNotActivateWindow.set
		// Forced skipping of method Microsoft.UI.Windowing.AppWindowPresenter.Kind.get
	}
}
