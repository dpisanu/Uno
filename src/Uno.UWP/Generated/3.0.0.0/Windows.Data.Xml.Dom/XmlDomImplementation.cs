#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Data.Xml.Dom
{
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	[global::Uno.NotImplemented]
	#endif
	public  partial class XmlDomImplementation 
	{
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		[global::Uno.NotImplemented]
		public  bool HasFeature( string feature,  object version)
		{
			throw new global::System.NotImplementedException("The member bool XmlDomImplementation.HasFeature(string feature, object version) is not implemented in Uno.");
		}
		#endif
	}
}