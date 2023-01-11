#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Controls.Primitives
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial interface IScrollController 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		bool AreScrollControllerInteractionsAllowed
		{
			get;
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		bool AreScrollerInteractionsAllowed
		{
			get;
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		global::Microsoft.UI.Xaml.UIElement InteractionElement
		{
			get;
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		global::Microsoft.UI.Xaml.Controls.Orientation InteractionElementScrollOrientation
		{
			get;
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		bool IsInteracting
		{
			get;
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		bool IsInteractionElementRailEnabled
		{
			get;
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.IScrollController.AreScrollControllerInteractionsAllowed.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.IScrollController.AreScrollerInteractionsAllowed.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.IScrollController.IsInteracting.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.IScrollController.IsInteractionElementRailEnabled.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.IScrollController.InteractionElement.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.IScrollController.InteractionElementScrollOrientation.get
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		void SetExpressionAnimationSources( global::Microsoft.UI.Composition.CompositionPropertySet propertySet,  string minOffsetPropertyName,  string maxOffsetPropertyName,  string offsetPropertyName,  string multiplierPropertyName);
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		void SetScrollMode( global::Microsoft.UI.Xaml.Controls.ScrollingScrollMode scrollMode);
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		void SetValues( double minOffset,  double maxOffset,  double offset,  double viewport);
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		global::Microsoft.UI.Composition.CompositionAnimation GetScrollAnimation( int correlationId,  global::System.Numerics.Vector2 currentPosition,  global::Microsoft.UI.Composition.CompositionAnimation defaultAnimation);
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		void NotifyScrollCompleted( int correlationId);
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.IScrollController.ScrollToRequested.add
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.IScrollController.ScrollToRequested.remove
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.IScrollController.ScrollByRequested.add
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.IScrollController.ScrollByRequested.remove
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.IScrollController.AddScrollVelocityRequested.add
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.IScrollController.AddScrollVelocityRequested.remove
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.IScrollController.InteractionRequested.add
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.IScrollController.InteractionRequested.remove
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.IScrollController.InteractionInfoChanged.add
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.IScrollController.InteractionInfoChanged.remove
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		 event global::Windows.Foundation.TypedEventHandler<global::Microsoft.UI.Xaml.Controls.Primitives.IScrollController, global::Microsoft.UI.Xaml.Controls.Primitives.ScrollControllerAddScrollVelocityRequestedEventArgs> AddScrollVelocityRequested;
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		 event global::Windows.Foundation.TypedEventHandler<global::Microsoft.UI.Xaml.Controls.Primitives.IScrollController, object> InteractionInfoChanged;
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		 event global::Windows.Foundation.TypedEventHandler<global::Microsoft.UI.Xaml.Controls.Primitives.IScrollController, global::Microsoft.UI.Xaml.Controls.Primitives.ScrollControllerInteractionRequestedEventArgs> InteractionRequested;
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		 event global::Windows.Foundation.TypedEventHandler<global::Microsoft.UI.Xaml.Controls.Primitives.IScrollController, global::Microsoft.UI.Xaml.Controls.Primitives.ScrollControllerScrollByRequestedEventArgs> ScrollByRequested;
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		 event global::Windows.Foundation.TypedEventHandler<global::Microsoft.UI.Xaml.Controls.Primitives.IScrollController, global::Microsoft.UI.Xaml.Controls.Primitives.ScrollControllerScrollToRequestedEventArgs> ScrollToRequested;
		#endif
	}
}
