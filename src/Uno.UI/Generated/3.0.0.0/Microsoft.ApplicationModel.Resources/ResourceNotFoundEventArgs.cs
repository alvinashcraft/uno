#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.ApplicationModel.Resources
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class ResourceNotFoundEventArgs 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Microsoft.ApplicationModel.Resources.ResourceContext Context
		{
			get
			{
				throw new global::System.NotImplementedException("The member ResourceContext ResourceNotFoundEventArgs.Context is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  string Name
		{
			get
			{
				throw new global::System.NotImplementedException("The member string ResourceNotFoundEventArgs.Name is not implemented in Uno.");
			}
		}
		#endif
		// Forced skipping of method Microsoft.ApplicationModel.Resources.ResourceNotFoundEventArgs.Context.get
		// Forced skipping of method Microsoft.ApplicationModel.Resources.ResourceNotFoundEventArgs.Name.get
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  void SetResolvedCandidate( global::Microsoft.ApplicationModel.Resources.ResourceCandidate candidate)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.ApplicationModel.Resources.ResourceNotFoundEventArgs", "void ResourceNotFoundEventArgs.SetResolvedCandidate(ResourceCandidate candidate)");
		}
		#endif
	}
}
