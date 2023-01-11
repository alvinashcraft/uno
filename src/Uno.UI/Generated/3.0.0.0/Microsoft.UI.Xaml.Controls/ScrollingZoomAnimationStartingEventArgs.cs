#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Controls
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class ScrollingZoomAnimationStartingEventArgs 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Microsoft.UI.Composition.CompositionAnimation Animation
		{
			get
			{
				throw new global::System.NotImplementedException("The member CompositionAnimation ScrollingZoomAnimationStartingEventArgs.Animation is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.ScrollingZoomAnimationStartingEventArgs", "CompositionAnimation ScrollingZoomAnimationStartingEventArgs.Animation");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::System.Numerics.Vector2 CenterPoint
		{
			get
			{
				throw new global::System.NotImplementedException("The member Vector2 ScrollingZoomAnimationStartingEventArgs.CenterPoint is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  int CorrelationId
		{
			get
			{
				throw new global::System.NotImplementedException("The member int ScrollingZoomAnimationStartingEventArgs.CorrelationId is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  float EndZoomFactor
		{
			get
			{
				throw new global::System.NotImplementedException("The member float ScrollingZoomAnimationStartingEventArgs.EndZoomFactor is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  float StartZoomFactor
		{
			get
			{
				throw new global::System.NotImplementedException("The member float ScrollingZoomAnimationStartingEventArgs.StartZoomFactor is not implemented in Uno.");
			}
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ScrollingZoomAnimationStartingEventArgs.CenterPoint.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ScrollingZoomAnimationStartingEventArgs.StartZoomFactor.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ScrollingZoomAnimationStartingEventArgs.EndZoomFactor.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ScrollingZoomAnimationStartingEventArgs.Animation.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ScrollingZoomAnimationStartingEventArgs.Animation.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ScrollingZoomAnimationStartingEventArgs.CorrelationId.get
	}
}
