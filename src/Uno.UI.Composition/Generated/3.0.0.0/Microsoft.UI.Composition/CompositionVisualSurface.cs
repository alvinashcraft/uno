#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Composition
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class CompositionVisualSurface : global::Microsoft.UI.Composition.CompositionObject,global::Microsoft.UI.Composition.ICompositionSurface
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Microsoft.UI.Composition.Visual SourceVisual
		{
			get
			{
				throw new global::System.NotImplementedException("The member Visual CompositionVisualSurface.SourceVisual is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Composition.CompositionVisualSurface", "Visual CompositionVisualSurface.SourceVisual");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::System.Numerics.Vector2 SourceSize
		{
			get
			{
				throw new global::System.NotImplementedException("The member Vector2 CompositionVisualSurface.SourceSize is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Composition.CompositionVisualSurface", "Vector2 CompositionVisualSurface.SourceSize");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::System.Numerics.Vector2 SourceOffset
		{
			get
			{
				throw new global::System.NotImplementedException("The member Vector2 CompositionVisualSurface.SourceOffset is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Composition.CompositionVisualSurface", "Vector2 CompositionVisualSurface.SourceOffset");
			}
		}
		#endif
		// Forced skipping of method Microsoft.UI.Composition.CompositionVisualSurface.SourceVisual.get
		// Forced skipping of method Microsoft.UI.Composition.CompositionVisualSurface.SourceVisual.set
		// Forced skipping of method Microsoft.UI.Composition.CompositionVisualSurface.SourceOffset.get
		// Forced skipping of method Microsoft.UI.Composition.CompositionVisualSurface.SourceOffset.set
		// Forced skipping of method Microsoft.UI.Composition.CompositionVisualSurface.SourceSize.get
		// Forced skipping of method Microsoft.UI.Composition.CompositionVisualSurface.SourceSize.set
		// Processing: Microsoft.UI.Composition.ICompositionSurface
	}
}
