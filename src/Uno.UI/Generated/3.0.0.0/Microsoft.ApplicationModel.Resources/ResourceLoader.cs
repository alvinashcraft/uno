#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.ApplicationModel.Resources
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class ResourceLoader 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public ResourceLoader( string fileName) 
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.ApplicationModel.Resources.ResourceLoader", "ResourceLoader.ResourceLoader(string fileName)");
		}
		#endif
		// Forced skipping of method Microsoft.ApplicationModel.Resources.ResourceLoader.ResourceLoader(string)
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public ResourceLoader( string fileName,  string resourceMap) 
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.ApplicationModel.Resources.ResourceLoader", "ResourceLoader.ResourceLoader(string fileName, string resourceMap)");
		}
		#endif
		// Forced skipping of method Microsoft.ApplicationModel.Resources.ResourceLoader.ResourceLoader(string, string)
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public ResourceLoader() 
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.ApplicationModel.Resources.ResourceLoader", "ResourceLoader.ResourceLoader()");
		}
		#endif
		// Forced skipping of method Microsoft.ApplicationModel.Resources.ResourceLoader.ResourceLoader()
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  string GetString( string resourceId)
		{
			throw new global::System.NotImplementedException("The member string ResourceLoader.GetString(string resourceId) is not implemented in Uno.");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  string GetStringForUri( global::System.Uri resourceUri)
		{
			throw new global::System.NotImplementedException("The member string ResourceLoader.GetStringForUri(Uri resourceUri) is not implemented in Uno.");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static string GetDefaultResourceFilePath()
		{
			throw new global::System.NotImplementedException("The member string ResourceLoader.GetDefaultResourceFilePath() is not implemented in Uno.");
		}
		#endif
	}
}
