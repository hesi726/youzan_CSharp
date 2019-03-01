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


	public class YouzanItemUpdateResult : APIResult
	{



		/// <summary>
		/// 商品ID
		/// </summary>
[Newtonsoft.Json.JsonProperty("item_id")]//) private Nullable<long> itemId;
		private long? itemId;


		/// <summary>
		/// 操作是否成功
		/// </summary>
[Newtonsoft.Json.JsonProperty("is_success")]//) private Nullable<bool> isSuccess;
		private bool? isSuccess;

		public virtual long? ItemId
		{
			set
			{
				this.itemId = value;
			}
			get
			{
				return this.itemId;
			}
		}

		public virtual bool? IsSuccess
		{
			set
			{
				this.isSuccess = value;
			}
			get
			{
				return this.isSuccess;
			}
		}



	}
}