#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Composition
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class CompositionProjectedShadowReceiver : global::Microsoft.UI.Composition.CompositionObject
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Microsoft.UI.Composition.Visual ReceivingVisual
		{
			get
			{
				throw new global::System.NotImplementedException("The member Visual CompositionProjectedShadowReceiver.ReceivingVisual is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Composition.CompositionProjectedShadowReceiver", "Visual CompositionProjectedShadowReceiver.ReceivingVisual");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Microsoft.UI.Composition.CompositionBrush Mask
		{
			get
			{
				throw new global::System.NotImplementedException("The member CompositionBrush CompositionProjectedShadowReceiver.Mask is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Composition.CompositionProjectedShadowReceiver", "CompositionBrush CompositionProjectedShadowReceiver.Mask");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Microsoft.UI.Composition.CompositionProjectedShadowDrawOrder DrawOrder
		{
			get
			{
				throw new global::System.NotImplementedException("The member CompositionProjectedShadowDrawOrder CompositionProjectedShadowReceiver.DrawOrder is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Composition.CompositionProjectedShadowReceiver", "CompositionProjectedShadowDrawOrder CompositionProjectedShadowReceiver.DrawOrder");
			}
		}
		#endif
		// Forced skipping of method Microsoft.UI.Composition.CompositionProjectedShadowReceiver.ReceivingVisual.get
		// Forced skipping of method Microsoft.UI.Composition.CompositionProjectedShadowReceiver.ReceivingVisual.set
		// Forced skipping of method Microsoft.UI.Composition.CompositionProjectedShadowReceiver.DrawOrder.get
		// Forced skipping of method Microsoft.UI.Composition.CompositionProjectedShadowReceiver.DrawOrder.set
		// Forced skipping of method Microsoft.UI.Composition.CompositionProjectedShadowReceiver.Mask.get
		// Forced skipping of method Microsoft.UI.Composition.CompositionProjectedShadowReceiver.Mask.set
	}
}
