#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.ApplicationModel.Resources
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class ResourceManager 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Microsoft.ApplicationModel.Resources.ResourceMap MainResourceMap
		{
			get
			{
				throw new global::System.NotImplementedException("The member ResourceMap ResourceManager.MainResourceMap is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public ResourceManager( string fileName) 
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.ApplicationModel.Resources.ResourceManager", "ResourceManager.ResourceManager(string fileName)");
		}
		#endif
		// Forced skipping of method Microsoft.ApplicationModel.Resources.ResourceManager.ResourceManager(string)
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public ResourceManager() 
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.ApplicationModel.Resources.ResourceManager", "ResourceManager.ResourceManager()");
		}
		#endif
		// Forced skipping of method Microsoft.ApplicationModel.Resources.ResourceManager.ResourceManager()
		// Forced skipping of method Microsoft.ApplicationModel.Resources.ResourceManager.MainResourceMap.get
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Microsoft.ApplicationModel.Resources.ResourceContext CreateResourceContext()
		{
			throw new global::System.NotImplementedException("The member ResourceContext ResourceManager.CreateResourceContext() is not implemented in Uno.");
		}
		#endif
		// Forced skipping of method Microsoft.ApplicationModel.Resources.ResourceManager.ResourceNotFound.add
		// Forced skipping of method Microsoft.ApplicationModel.Resources.ResourceManager.ResourceNotFound.remove
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  event global::Windows.Foundation.TypedEventHandler<global::Microsoft.ApplicationModel.Resources.ResourceManager, global::Microsoft.ApplicationModel.Resources.ResourceNotFoundEventArgs> ResourceNotFound
		{
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.ApplicationModel.Resources.ResourceManager", "event TypedEventHandler<ResourceManager, ResourceNotFoundEventArgs> ResourceManager.ResourceNotFound");
			}
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.ApplicationModel.Resources.ResourceManager", "event TypedEventHandler<ResourceManager, ResourceNotFoundEventArgs> ResourceManager.ResourceNotFound");
			}
		}
		#endif
	}
}
