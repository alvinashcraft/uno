#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Composition.Experimental
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class ExpCompositionContentAutomationProviderRequestedEventArgs 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  bool Handled
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool ExpCompositionContentAutomationProviderRequestedEventArgs.Handled is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Composition.Experimental.ExpCompositionContentAutomationProviderRequestedEventArgs", "bool ExpCompositionContentAutomationProviderRequestedEventArgs.Handled");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  object AutomationProvider
		{
			get
			{
				throw new global::System.NotImplementedException("The member object ExpCompositionContentAutomationProviderRequestedEventArgs.AutomationProvider is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Composition.Experimental.ExpCompositionContentAutomationProviderRequestedEventArgs", "object ExpCompositionContentAutomationProviderRequestedEventArgs.AutomationProvider");
			}
		}
		#endif
		// Forced skipping of method Microsoft.UI.Composition.Experimental.ExpCompositionContentAutomationProviderRequestedEventArgs.AutomationProvider.get
		// Forced skipping of method Microsoft.UI.Composition.Experimental.ExpCompositionContentAutomationProviderRequestedEventArgs.AutomationProvider.set
		// Forced skipping of method Microsoft.UI.Composition.Experimental.ExpCompositionContentAutomationProviderRequestedEventArgs.Handled.get
		// Forced skipping of method Microsoft.UI.Composition.Experimental.ExpCompositionContentAutomationProviderRequestedEventArgs.Handled.set
	}
}
