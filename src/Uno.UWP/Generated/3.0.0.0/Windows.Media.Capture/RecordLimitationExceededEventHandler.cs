#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Media.Capture
{
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	public delegate void RecordLimitationExceededEventHandler(global::Windows.Media.Capture.MediaCapture @sender);
	#endif
}