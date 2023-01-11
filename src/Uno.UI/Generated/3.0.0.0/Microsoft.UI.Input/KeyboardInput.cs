#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Input
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public static partial class KeyboardInput 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.UI.Core.CoreVirtualKeyStates GetKeyStateForCurrentThread( global::Windows.System.VirtualKey virtualKey)
		{
			throw new global::System.NotImplementedException("The member CoreVirtualKeyStates KeyboardInput.GetKeyStateForCurrentThread(VirtualKey virtualKey) is not implemented in Uno.");
		}
		#endif
	}
}
