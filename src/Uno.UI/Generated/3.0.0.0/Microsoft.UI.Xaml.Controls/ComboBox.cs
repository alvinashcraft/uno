#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Controls
{
	#if false || false || false || false || false || false || false
	[global::Uno.NotImplemented]
	#endif
	public  partial class ComboBox : global::Microsoft.UI.Xaml.Controls.IInputValidationControl
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Microsoft.UI.Xaml.Style TextBoxStyle
		{
			get
			{
				return (global::Microsoft.UI.Xaml.Style)this.GetValue(TextBoxStyleProperty);
			}
			set
			{
				this.SetValue(TextBoxStyleProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  string Text
		{
			get
			{
				return (string)this.GetValue(TextProperty);
			}
			set
			{
				this.SetValue(TextProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Microsoft.UI.Xaml.Controls.ComboBoxSelectionChangedTrigger SelectionChangedTrigger
		{
			get
			{
				return (global::Microsoft.UI.Xaml.Controls.ComboBoxSelectionChangedTrigger)this.GetValue(SelectionChangedTriggerProperty);
			}
			set
			{
				this.SetValue(SelectionChangedTriggerProperty, value);
			}
		}
		#endif
		// Skipping already declared property PlaceholderText
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Microsoft.UI.Xaml.Media.Brush PlaceholderForeground
		{
			get
			{
				return (global::Microsoft.UI.Xaml.Media.Brush)this.GetValue(PlaceholderForegroundProperty);
			}
			set
			{
				this.SetValue(PlaceholderForegroundProperty, value);
			}
		}
		#endif
		// Skipping already declared property MaxDropDownHeight
		// Skipping already declared property LightDismissOverlayMode
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  bool IsTextSearchEnabled
		{
			get
			{
				return (bool)this.GetValue(IsTextSearchEnabledProperty);
			}
			set
			{
				this.SetValue(IsTextSearchEnabledProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  bool IsEditable
		{
			get
			{
				return (bool)this.GetValue(IsEditableProperty);
			}
			set
			{
				this.SetValue(IsEditableProperty, value);
			}
		}
		#endif
		// Skipping already declared property IsDropDownOpen
		// Skipping already declared property HeaderTemplate
		// Skipping already declared property Header
		// Skipping already declared property Description
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  bool IsSelectionBoxHighlighted
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool ComboBox.IsSelectionBoxHighlighted is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  object SelectionBoxItem
		{
			get
			{
				throw new global::System.NotImplementedException("The member object ComboBox.SelectionBoxItem is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Microsoft.UI.Xaml.DataTemplate SelectionBoxItemTemplate
		{
			get
			{
				throw new global::System.NotImplementedException("The member DataTemplate ComboBox.SelectionBoxItemTemplate is not implemented in Uno.");
			}
		}
		#endif
		// Skipping already declared property TemplateSettings
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Microsoft.UI.Xaml.Controls.InputValidationContext ValidationContext
		{
			get
			{
				throw new global::System.NotImplementedException("The member InputValidationContext ComboBox.ValidationContext is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.ComboBox", "InputValidationContext ComboBox.ValidationContext");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Microsoft.UI.Xaml.Controls.InputValidationMode InputValidationMode
		{
			get
			{
				return (global::Microsoft.UI.Xaml.Controls.InputValidationMode)this.GetValue(InputValidationModeProperty);
			}
			set
			{
				this.SetValue(InputValidationModeProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Microsoft.UI.Xaml.Controls.InputValidationKind InputValidationKind
		{
			get
			{
				return (global::Microsoft.UI.Xaml.Controls.InputValidationKind)this.GetValue(InputValidationKindProperty);
			}
			set
			{
				this.SetValue(InputValidationKindProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Microsoft.UI.Xaml.DataTemplate ErrorTemplate
		{
			get
			{
				return (global::Microsoft.UI.Xaml.DataTemplate)this.GetValue(ErrorTemplateProperty);
			}
			set
			{
				this.SetValue(ErrorTemplateProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  bool HasValidationErrors
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool ComboBox.HasValidationErrors is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.Collections.IObservableVector<global::Microsoft.UI.Xaml.Controls.InputValidationError> ValidationErrors
		{
			get
			{
				throw new global::System.NotImplementedException("The member IObservableVector<InputValidationError> ComboBox.ValidationErrors is not implemented in Uno.");
			}
		}
		#endif
		// Skipping already declared property DescriptionProperty
		// Skipping already declared property HeaderProperty
		// Skipping already declared property HeaderTemplateProperty
		// Skipping already declared property IsDropDownOpenProperty
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Microsoft.UI.Xaml.DependencyProperty IsEditableProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(IsEditable), typeof(bool), 
			typeof(global::Microsoft.UI.Xaml.Controls.ComboBox), 
			new FrameworkPropertyMetadata(default(bool)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Microsoft.UI.Xaml.DependencyProperty IsTextSearchEnabledProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(IsTextSearchEnabled), typeof(bool), 
			typeof(global::Microsoft.UI.Xaml.Controls.ComboBox), 
			new FrameworkPropertyMetadata(default(bool)));
		#endif
		// Skipping already declared property LightDismissOverlayModeProperty
		// Skipping already declared property MaxDropDownHeightProperty
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Microsoft.UI.Xaml.DependencyProperty PlaceholderForegroundProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(PlaceholderForeground), typeof(global::Microsoft.UI.Xaml.Media.Brush), 
			typeof(global::Microsoft.UI.Xaml.Controls.ComboBox), 
			new FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.Media.Brush)));
		#endif
		// Skipping already declared property PlaceholderTextProperty
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Microsoft.UI.Xaml.DependencyProperty SelectionChangedTriggerProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(SelectionChangedTrigger), typeof(global::Microsoft.UI.Xaml.Controls.ComboBoxSelectionChangedTrigger), 
			typeof(global::Microsoft.UI.Xaml.Controls.ComboBox), 
			new FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.Controls.ComboBoxSelectionChangedTrigger)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Microsoft.UI.Xaml.DependencyProperty TextBoxStyleProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(TextBoxStyle), typeof(global::Microsoft.UI.Xaml.Style), 
			typeof(global::Microsoft.UI.Xaml.Controls.ComboBox), 
			new FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.Style)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Microsoft.UI.Xaml.DependencyProperty TextProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(Text), typeof(string), 
			typeof(global::Microsoft.UI.Xaml.Controls.ComboBox), 
			new FrameworkPropertyMetadata(default(string)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Microsoft.UI.Xaml.DependencyProperty ErrorTemplateProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(ErrorTemplate), typeof(global::Microsoft.UI.Xaml.DataTemplate), 
			typeof(global::Microsoft.UI.Xaml.Controls.ComboBox), 
			new FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.DataTemplate)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Microsoft.UI.Xaml.DependencyProperty InputValidationKindProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(InputValidationKind), typeof(global::Microsoft.UI.Xaml.Controls.InputValidationKind), 
			typeof(global::Microsoft.UI.Xaml.Controls.ComboBox), 
			new FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.Controls.InputValidationKind)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Microsoft.UI.Xaml.DependencyProperty InputValidationModeProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(InputValidationMode), typeof(global::Microsoft.UI.Xaml.Controls.InputValidationMode), 
			typeof(global::Microsoft.UI.Xaml.Controls.ComboBox), 
			new FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.Controls.InputValidationMode)));
		#endif
		// Skipping already declared method Microsoft.UI.Xaml.Controls.ComboBox.ComboBox()
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ComboBox.ComboBox()
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ComboBox.IsDropDownOpen.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ComboBox.IsDropDownOpen.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ComboBox.IsEditable.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ComboBox.IsEditable.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ComboBox.IsSelectionBoxHighlighted.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ComboBox.MaxDropDownHeight.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ComboBox.MaxDropDownHeight.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ComboBox.SelectionBoxItem.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ComboBox.SelectionBoxItemTemplate.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ComboBox.TemplateSettings.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ComboBox.Header.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ComboBox.Header.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ComboBox.HeaderTemplate.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ComboBox.HeaderTemplate.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ComboBox.PlaceholderText.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ComboBox.PlaceholderText.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ComboBox.LightDismissOverlayMode.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ComboBox.LightDismissOverlayMode.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ComboBox.IsTextSearchEnabled.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ComboBox.IsTextSearchEnabled.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ComboBox.SelectionChangedTrigger.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ComboBox.SelectionChangedTrigger.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ComboBox.PlaceholderForeground.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ComboBox.PlaceholderForeground.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ComboBox.Text.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ComboBox.Text.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ComboBox.TextBoxStyle.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ComboBox.TextBoxStyle.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ComboBox.Description.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ComboBox.Description.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ComboBox.DropDownClosed.add
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ComboBox.DropDownClosed.remove
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ComboBox.DropDownOpened.add
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ComboBox.DropDownOpened.remove
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ComboBox.TextSubmitted.add
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ComboBox.TextSubmitted.remove
		// Skipping already declared method Microsoft.UI.Xaml.Controls.ComboBox.OnDropDownClosed(object)
		// Skipping already declared method Microsoft.UI.Xaml.Controls.ComboBox.OnDropDownOpened(object)
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ComboBox.ValidationErrors.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ComboBox.HasValidationErrors.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ComboBox.ValidationContext.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ComboBox.ValidationContext.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ComboBox.ErrorTemplate.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ComboBox.ErrorTemplate.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ComboBox.InputValidationMode.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ComboBox.InputValidationMode.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ComboBox.InputValidationKind.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ComboBox.InputValidationKind.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ComboBox.HasValidationErrorsChanged.add
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ComboBox.HasValidationErrorsChanged.remove
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ComboBox.ValidationError.add
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ComboBox.ValidationError.remove
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ComboBox.ErrorTemplateProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ComboBox.InputValidationModeProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ComboBox.InputValidationKindProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ComboBox.IsEditableProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ComboBox.IsDropDownOpenProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ComboBox.MaxDropDownHeightProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ComboBox.HeaderProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ComboBox.HeaderTemplateProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ComboBox.PlaceholderTextProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ComboBox.LightDismissOverlayModeProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ComboBox.IsTextSearchEnabledProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ComboBox.SelectionChangedTriggerProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ComboBox.PlaceholderForegroundProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ComboBox.TextProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ComboBox.TextBoxStyleProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ComboBox.DescriptionProperty.get
		// Skipping already declared event Microsoft.UI.Xaml.Controls.ComboBox.DropDownClosed
		// Skipping already declared event Microsoft.UI.Xaml.Controls.ComboBox.DropDownOpened
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  event global::Windows.Foundation.TypedEventHandler<global::Microsoft.UI.Xaml.Controls.ComboBox, global::Microsoft.UI.Xaml.Controls.ComboBoxTextSubmittedEventArgs> TextSubmitted
		{
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.ComboBox", "event TypedEventHandler<ComboBox, ComboBoxTextSubmittedEventArgs> ComboBox.TextSubmitted");
			}
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.ComboBox", "event TypedEventHandler<ComboBox, ComboBoxTextSubmittedEventArgs> ComboBox.TextSubmitted");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  event global::Windows.Foundation.TypedEventHandler<global::Microsoft.UI.Xaml.Controls.IInputValidationControl, global::Microsoft.UI.Xaml.Controls.HasValidationErrorsChangedEventArgs> HasValidationErrorsChanged
		{
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.ComboBox", "event TypedEventHandler<IInputValidationControl, HasValidationErrorsChangedEventArgs> ComboBox.HasValidationErrorsChanged");
			}
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.ComboBox", "event TypedEventHandler<IInputValidationControl, HasValidationErrorsChangedEventArgs> ComboBox.HasValidationErrorsChanged");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  event global::Windows.Foundation.TypedEventHandler<global::Microsoft.UI.Xaml.Controls.IInputValidationControl, global::Microsoft.UI.Xaml.Controls.InputValidationErrorEventArgs> ValidationError
		{
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.ComboBox", "event TypedEventHandler<IInputValidationControl, InputValidationErrorEventArgs> ComboBox.ValidationError");
			}
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.ComboBox", "event TypedEventHandler<IInputValidationControl, InputValidationErrorEventArgs> ComboBox.ValidationError");
			}
		}
		#endif
		// Processing: Microsoft.UI.Xaml.Controls.IInputValidationControl
	}
}
