#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.ApplicationModel.Resources
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class ResourceMap 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  uint ResourceCount
		{
			get
			{
				throw new global::System.NotImplementedException("The member uint ResourceMap.ResourceCount is not implemented in Uno.");
			}
		}
		#endif
		// Forced skipping of method Microsoft.ApplicationModel.Resources.ResourceMap.ResourceCount.get
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Microsoft.ApplicationModel.Resources.ResourceMap GetSubtree( string reference)
		{
			throw new global::System.NotImplementedException("The member ResourceMap ResourceMap.GetSubtree(string reference) is not implemented in Uno.");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Microsoft.ApplicationModel.Resources.ResourceCandidate GetValue( string resource)
		{
			throw new global::System.NotImplementedException("The member ResourceCandidate ResourceMap.GetValue(string resource) is not implemented in Uno.");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Microsoft.ApplicationModel.Resources.ResourceCandidate GetValue( string resource,  global::Microsoft.ApplicationModel.Resources.ResourceContext context)
		{
			throw new global::System.NotImplementedException("The member ResourceCandidate ResourceMap.GetValue(string resource, ResourceContext context) is not implemented in Uno.");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::System.Collections.Generic.KeyValuePair<string, global::Microsoft.ApplicationModel.Resources.ResourceCandidate> GetValueByIndex( uint index)
		{
			throw new global::System.NotImplementedException("The member KeyValuePair<string, ResourceCandidate> ResourceMap.GetValueByIndex(uint index) is not implemented in Uno.");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::System.Collections.Generic.KeyValuePair<string, global::Microsoft.ApplicationModel.Resources.ResourceCandidate> GetValueByIndex( uint index,  global::Microsoft.ApplicationModel.Resources.ResourceContext context)
		{
			throw new global::System.NotImplementedException("The member KeyValuePair<string, ResourceCandidate> ResourceMap.GetValueByIndex(uint index, ResourceContext context) is not implemented in Uno.");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Microsoft.ApplicationModel.Resources.ResourceCandidate TryGetValue( string resource)
		{
			throw new global::System.NotImplementedException("The member ResourceCandidate ResourceMap.TryGetValue(string resource) is not implemented in Uno.");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Microsoft.ApplicationModel.Resources.ResourceCandidate TryGetValue( string resource,  global::Microsoft.ApplicationModel.Resources.ResourceContext context)
		{
			throw new global::System.NotImplementedException("The member ResourceCandidate ResourceMap.TryGetValue(string resource, ResourceContext context) is not implemented in Uno.");
		}
		#endif
	}
}
