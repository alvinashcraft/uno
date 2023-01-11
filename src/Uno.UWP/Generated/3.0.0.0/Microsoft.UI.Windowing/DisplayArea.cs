#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Windowing
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class DisplayArea 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Microsoft.UI.DisplayId DisplayId
		{
			get
			{
				throw new global::System.NotImplementedException("The member DisplayId DisplayArea.DisplayId is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  bool IsPrimary
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool DisplayArea.IsPrimary is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Graphics.RectInt32 OuterBounds
		{
			get
			{
				throw new global::System.NotImplementedException("The member RectInt32 DisplayArea.OuterBounds is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Graphics.RectInt32 WorkArea
		{
			get
			{
				throw new global::System.NotImplementedException("The member RectInt32 DisplayArea.WorkArea is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Microsoft.UI.Windowing.DisplayArea Primary
		{
			get
			{
				throw new global::System.NotImplementedException("The member DisplayArea DisplayArea.Primary is not implemented in Uno.");
			}
		}
		#endif
		// Forced skipping of method Microsoft.UI.Windowing.DisplayArea.DisplayId.get
		// Forced skipping of method Microsoft.UI.Windowing.DisplayArea.IsPrimary.get
		// Forced skipping of method Microsoft.UI.Windowing.DisplayArea.OuterBounds.get
		// Forced skipping of method Microsoft.UI.Windowing.DisplayArea.WorkArea.get
		// Forced skipping of method Microsoft.UI.Windowing.DisplayArea.Primary.get
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Microsoft.UI.Windowing.DisplayAreaWatcher CreateWatcher()
		{
			throw new global::System.NotImplementedException("The member DisplayAreaWatcher DisplayArea.CreateWatcher() is not implemented in Uno.");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::System.Collections.Generic.IReadOnlyList<global::Microsoft.UI.Windowing.DisplayArea> FindAll()
		{
			throw new global::System.NotImplementedException("The member IReadOnlyList<DisplayArea> DisplayArea.FindAll() is not implemented in Uno.");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Microsoft.UI.Windowing.DisplayArea GetFromWindowId( global::Microsoft.UI.WindowId windowId,  global::Microsoft.UI.Windowing.DisplayAreaFallback displayAreaFallback)
		{
			throw new global::System.NotImplementedException("The member DisplayArea DisplayArea.GetFromWindowId(WindowId windowId, DisplayAreaFallback displayAreaFallback) is not implemented in Uno.");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Microsoft.UI.Windowing.DisplayArea GetFromPoint( global::Windows.Graphics.PointInt32 point,  global::Microsoft.UI.Windowing.DisplayAreaFallback displayAreaFallback)
		{
			throw new global::System.NotImplementedException("The member DisplayArea DisplayArea.GetFromPoint(PointInt32 point, DisplayAreaFallback displayAreaFallback) is not implemented in Uno.");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Microsoft.UI.Windowing.DisplayArea GetFromRect( global::Windows.Graphics.RectInt32 rect,  global::Microsoft.UI.Windowing.DisplayAreaFallback displayAreaFallback)
		{
			throw new global::System.NotImplementedException("The member DisplayArea DisplayArea.GetFromRect(RectInt32 rect, DisplayAreaFallback displayAreaFallback) is not implemented in Uno.");
		}
		#endif
	}
}
