namespace com.youzan.open.sdk.gen.v3_0_0.model
{

	////using ArrayListMultimap = com.google.common.collect.ArrayListMultimap;
	using global::youzan.com.youzan.open.sdk.model;


	//////using Maps = com.google.common.collect.Maps;
	using global::youzan.com.youzan.open.sdk.model;


	////using Multimap = com.google.common.collect.Multimap;
	using global::youzan.com.youzan.open.sdk.model;


	using APIParams = com.youzan.open.sdk.model.APIParams;
	using FileParams = com.youzan.open.sdk.model.FileParams;
	using APIResult = com.youzan.open.sdk.model.APIResult;
	using ByteWrapper = com.youzan.open.sdk.model.ByteWrapper;
	//using JsonProperty = com.fasterxml.jackson.annotation.JsonProperty;


	public class YouzanRetailProductsOnlineDisplayResult : APIResult
	{



		/// <summary>
		/// 上下架成功商品数量
		/// </summary>
[Newtonsoft.Json.JsonProperty("display_result")]//) private Nullable<long> displayResult;
		private long? displayResult;

		public virtual long? DisplayResult
		{
			set
			{
				this.displayResult = value;
			}
			get
			{
				return this.displayResult;
			}
		}



	}
}