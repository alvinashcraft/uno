#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Composition.Scenes
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class SceneMeshRendererComponent : global::Microsoft.UI.Composition.Scenes.SceneRendererComponent
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Microsoft.UI.Composition.Scenes.SceneMesh Mesh
		{
			get
			{
				throw new global::System.NotImplementedException("The member SceneMesh SceneMeshRendererComponent.Mesh is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Composition.Scenes.SceneMeshRendererComponent", "SceneMesh SceneMeshRendererComponent.Mesh");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Microsoft.UI.Composition.Scenes.SceneMaterial Material
		{
			get
			{
				throw new global::System.NotImplementedException("The member SceneMaterial SceneMeshRendererComponent.Material is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Composition.Scenes.SceneMeshRendererComponent", "SceneMaterial SceneMeshRendererComponent.Material");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Microsoft.UI.Composition.Scenes.SceneMeshMaterialAttributeMap UVMappings
		{
			get
			{
				throw new global::System.NotImplementedException("The member SceneMeshMaterialAttributeMap SceneMeshRendererComponent.UVMappings is not implemented in Uno.");
			}
		}
		#endif
		// Forced skipping of method Microsoft.UI.Composition.Scenes.SceneMeshRendererComponent.Material.get
		// Forced skipping of method Microsoft.UI.Composition.Scenes.SceneMeshRendererComponent.Material.set
		// Forced skipping of method Microsoft.UI.Composition.Scenes.SceneMeshRendererComponent.Mesh.get
		// Forced skipping of method Microsoft.UI.Composition.Scenes.SceneMeshRendererComponent.Mesh.set
		// Forced skipping of method Microsoft.UI.Composition.Scenes.SceneMeshRendererComponent.UVMappings.get
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Microsoft.UI.Composition.Scenes.SceneMeshRendererComponent Create( global::Microsoft.UI.Composition.Compositor compositor)
		{
			throw new global::System.NotImplementedException("The member SceneMeshRendererComponent SceneMeshRendererComponent.Create(Compositor compositor) is not implemented in Uno.");
		}
		#endif
	}
}
