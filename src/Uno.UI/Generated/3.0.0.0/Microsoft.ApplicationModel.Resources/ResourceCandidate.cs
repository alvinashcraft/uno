#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.ApplicationModel.Resources
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class ResourceCandidate 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Microsoft.ApplicationModel.Resources.ResourceCandidateKind Kind
		{
			get
			{
				throw new global::System.NotImplementedException("The member ResourceCandidateKind ResourceCandidate.Kind is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::System.Collections.Generic.IReadOnlyDictionary<string, string> QualifierValues
		{
			get
			{
				throw new global::System.NotImplementedException("The member IReadOnlyDictionary<string, string> ResourceCandidate.QualifierValues is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  byte[] ValueAsBytes
		{
			get
			{
				throw new global::System.NotImplementedException("The member byte[] ResourceCandidate.ValueAsBytes is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  string ValueAsString
		{
			get
			{
				throw new global::System.NotImplementedException("The member string ResourceCandidate.ValueAsString is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public ResourceCandidate( global::Microsoft.ApplicationModel.Resources.ResourceCandidateKind kind,  string data) 
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.ApplicationModel.Resources.ResourceCandidate", "ResourceCandidate.ResourceCandidate(ResourceCandidateKind kind, string data)");
		}
		#endif
		// Forced skipping of method Microsoft.ApplicationModel.Resources.ResourceCandidate.ResourceCandidate(Microsoft.ApplicationModel.Resources.ResourceCandidateKind, string)
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public ResourceCandidate( byte[] data) 
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.ApplicationModel.Resources.ResourceCandidate", "ResourceCandidate.ResourceCandidate(byte[] data)");
		}
		#endif
		// Forced skipping of method Microsoft.ApplicationModel.Resources.ResourceCandidate.ResourceCandidate(byte[])
		// Forced skipping of method Microsoft.ApplicationModel.Resources.ResourceCandidate.ValueAsString.get
		// Forced skipping of method Microsoft.ApplicationModel.Resources.ResourceCandidate.ValueAsBytes.get
		// Forced skipping of method Microsoft.ApplicationModel.Resources.ResourceCandidate.Kind.get
		// Forced skipping of method Microsoft.ApplicationModel.Resources.ResourceCandidate.QualifierValues.get
	}
}
