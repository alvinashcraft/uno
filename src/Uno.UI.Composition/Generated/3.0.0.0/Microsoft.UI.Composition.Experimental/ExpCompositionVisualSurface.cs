#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Composition.Experimental
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public static partial class ExpCompositionVisualSurface 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Microsoft.UI.Composition.CompositionVisualSurface CreateVisualSurface( global::Microsoft.UI.Composition.Compositor compositor,  global::Windows.Graphics.SizeInt32 realizationSize,  bool frozen)
		{
			throw new global::System.NotImplementedException("The member CompositionVisualSurface ExpCompositionVisualSurface.CreateVisualSurface(Compositor compositor, SizeInt32 realizationSize, bool frozen) is not implemented in Uno.");
		}
		#endif
	}
}
