#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.ApplicationModel.Email
{
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	[global::Uno.NotImplemented]
	#endif
	public   enum EmailMeetingResponseType 
	{
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		Accept,
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		Decline,
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		Tentative,
		#endif
	}
	#endif
}