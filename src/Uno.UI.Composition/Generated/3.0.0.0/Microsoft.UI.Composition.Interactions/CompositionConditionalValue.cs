#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Composition.Interactions
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class CompositionConditionalValue : global::Microsoft.UI.Composition.CompositionObject
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Microsoft.UI.Composition.ExpressionAnimation Value
		{
			get
			{
				throw new global::System.NotImplementedException("The member ExpressionAnimation CompositionConditionalValue.Value is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Composition.Interactions.CompositionConditionalValue", "ExpressionAnimation CompositionConditionalValue.Value");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Microsoft.UI.Composition.ExpressionAnimation Condition
		{
			get
			{
				throw new global::System.NotImplementedException("The member ExpressionAnimation CompositionConditionalValue.Condition is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Composition.Interactions.CompositionConditionalValue", "ExpressionAnimation CompositionConditionalValue.Condition");
			}
		}
		#endif
		// Forced skipping of method Microsoft.UI.Composition.Interactions.CompositionConditionalValue.Condition.get
		// Forced skipping of method Microsoft.UI.Composition.Interactions.CompositionConditionalValue.Condition.set
		// Forced skipping of method Microsoft.UI.Composition.Interactions.CompositionConditionalValue.Value.get
		// Forced skipping of method Microsoft.UI.Composition.Interactions.CompositionConditionalValue.Value.set
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Microsoft.UI.Composition.Interactions.CompositionConditionalValue Create( global::Microsoft.UI.Composition.Compositor compositor)
		{
			throw new global::System.NotImplementedException("The member CompositionConditionalValue CompositionConditionalValue.Create(Compositor compositor) is not implemented in Uno.");
		}
		#endif
	}
}
