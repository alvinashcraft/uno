#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Controls
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial interface IInputValidationControl 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		global::Microsoft.UI.Xaml.DataTemplate ErrorTemplate
		{
			get;
			set;
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		bool HasValidationErrors
		{
			get;
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		global::Microsoft.UI.Xaml.Controls.InputValidationKind InputValidationKind
		{
			get;
			set;
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		global::Microsoft.UI.Xaml.Controls.InputValidationMode InputValidationMode
		{
			get;
			set;
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		global::Microsoft.UI.Xaml.Controls.InputValidationContext ValidationContext
		{
			get;
			set;
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		global::Windows.Foundation.Collections.IObservableVector<global::Microsoft.UI.Xaml.Controls.InputValidationError> ValidationErrors
		{
			get;
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Controls.IInputValidationControl.ValidationErrors.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.IInputValidationControl.HasValidationErrors.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.IInputValidationControl.ValidationContext.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.IInputValidationControl.ValidationContext.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.IInputValidationControl.ErrorTemplate.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.IInputValidationControl.ErrorTemplate.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.IInputValidationControl.InputValidationMode.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.IInputValidationControl.InputValidationMode.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.IInputValidationControl.InputValidationKind.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.IInputValidationControl.InputValidationKind.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.IInputValidationControl.HasValidationErrorsChanged.add
		// Forced skipping of method Microsoft.UI.Xaml.Controls.IInputValidationControl.HasValidationErrorsChanged.remove
		// Forced skipping of method Microsoft.UI.Xaml.Controls.IInputValidationControl.ValidationError.add
		// Forced skipping of method Microsoft.UI.Xaml.Controls.IInputValidationControl.ValidationError.remove
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		 event global::Windows.Foundation.TypedEventHandler<global::Microsoft.UI.Xaml.Controls.IInputValidationControl, global::Microsoft.UI.Xaml.Controls.HasValidationErrorsChangedEventArgs> HasValidationErrorsChanged;
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		 event global::Windows.Foundation.TypedEventHandler<global::Microsoft.UI.Xaml.Controls.IInputValidationControl, global::Microsoft.UI.Xaml.Controls.InputValidationErrorEventArgs> ValidationError;
		#endif
	}
}
