#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Composition.Experimental
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial interface IExpContentTopLevelHost 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		global::Microsoft.UI.Composition.Experimental.ExpDisplayOrientations CurrentOrientation
		{
			get;
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		global::Microsoft.UI.DisplayId DisplayId
		{
			get;
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		float DisplayScale
		{
			get;
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		global::Microsoft.UI.Composition.Experimental.ExpDisplayOrientations NativeOrientation
		{
			get;
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		global::Microsoft.UI.WindowId WindowId
		{
			get;
		}
		#endif
		// Forced skipping of method Microsoft.UI.Composition.Experimental.IExpContentTopLevelHost.CurrentOrientation.get
		// Forced skipping of method Microsoft.UI.Composition.Experimental.IExpContentTopLevelHost.DisplayId.get
		// Forced skipping of method Microsoft.UI.Composition.Experimental.IExpContentTopLevelHost.DisplayScale.get
		// Forced skipping of method Microsoft.UI.Composition.Experimental.IExpContentTopLevelHost.NativeOrientation.get
		// Forced skipping of method Microsoft.UI.Composition.Experimental.IExpContentTopLevelHost.WindowId.get
		// Forced skipping of method Microsoft.UI.Composition.Experimental.IExpContentTopLevelHost.StateChanged.add
		// Forced skipping of method Microsoft.UI.Composition.Experimental.IExpContentTopLevelHost.StateChanged.remove
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		 event global::Windows.Foundation.TypedEventHandler<global::Microsoft.UI.Composition.Experimental.IExpContentTopLevelHost, object> StateChanged;
		#endif
	}
}
