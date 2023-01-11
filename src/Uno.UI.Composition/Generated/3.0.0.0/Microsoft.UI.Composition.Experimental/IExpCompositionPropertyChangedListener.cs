#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Composition.Experimental
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial interface IExpCompositionPropertyChangedListener 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		void NotifyBooleanPropertyChanged( global::Microsoft.UI.Composition.CompositionObject target,  global::Microsoft.UI.Composition.Experimental.ExpExpressionNotificationProperty property,  bool value);
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		void NotifyColorPropertyChanged( global::Microsoft.UI.Composition.CompositionObject target,  global::Microsoft.UI.Composition.Experimental.ExpExpressionNotificationProperty property,  global::Windows.UI.Color value);
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		void NotifyMatrix3x2PropertyChanged( global::Microsoft.UI.Composition.CompositionObject target,  global::Microsoft.UI.Composition.Experimental.ExpExpressionNotificationProperty property,  global::System.Numerics.Matrix3x2 value);
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		void NotifyMatrix4x4PropertyChanged( global::Microsoft.UI.Composition.CompositionObject target,  global::Microsoft.UI.Composition.Experimental.ExpExpressionNotificationProperty property,  global::System.Numerics.Matrix4x4 value);
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		void NotifyReferencePropertyChanged( global::Microsoft.UI.Composition.CompositionObject target,  global::Microsoft.UI.Composition.Experimental.ExpExpressionNotificationProperty property);
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		void NotifySinglePropertyChanged( global::Microsoft.UI.Composition.CompositionObject target,  global::Microsoft.UI.Composition.Experimental.ExpExpressionNotificationProperty property,  float value);
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		void NotifyVector2PropertyChanged( global::Microsoft.UI.Composition.CompositionObject target,  global::Microsoft.UI.Composition.Experimental.ExpExpressionNotificationProperty property,  global::System.Numerics.Vector2 value);
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		void NotifyVector3PropertyChanged( global::Microsoft.UI.Composition.CompositionObject target,  global::Microsoft.UI.Composition.Experimental.ExpExpressionNotificationProperty property,  global::System.Numerics.Vector3 value);
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		void NotifyVector4PropertyChanged( global::Microsoft.UI.Composition.CompositionObject target,  global::Microsoft.UI.Composition.Experimental.ExpExpressionNotificationProperty property,  global::System.Numerics.Vector4 value);
		#endif
	}
}
