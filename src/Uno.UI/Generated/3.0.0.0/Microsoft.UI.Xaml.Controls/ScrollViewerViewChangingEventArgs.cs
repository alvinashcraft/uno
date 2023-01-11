#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Controls
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class ScrollViewerViewChangingEventArgs 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Microsoft.UI.Xaml.Controls.ScrollViewerView FinalView
		{
			get
			{
				throw new global::System.NotImplementedException("The member ScrollViewerView ScrollViewerViewChangingEventArgs.FinalView is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  bool IsInertial
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool ScrollViewerViewChangingEventArgs.IsInertial is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Microsoft.UI.Xaml.Controls.ScrollViewerView NextView
		{
			get
			{
				throw new global::System.NotImplementedException("The member ScrollViewerView ScrollViewerViewChangingEventArgs.NextView is not implemented in Uno.");
			}
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ScrollViewerViewChangingEventArgs.NextView.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ScrollViewerViewChangingEventArgs.FinalView.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ScrollViewerViewChangingEventArgs.IsInertial.get
	}
}
