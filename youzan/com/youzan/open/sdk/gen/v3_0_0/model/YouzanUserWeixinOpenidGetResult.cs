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


	public class YouzanUserWeixinOpenidGetResult : APIResult
	{



		/// <summary>
		/// 获取到的用户open_id
		/// </summary>
[Newtonsoft.Json.JsonProperty("open_id")]//) private String openId;
		private string openId;

		public virtual string OpenId
		{
			set
			{
				this.openId = value;
			}
			get
			{
				return this.openId;
			}
		}



	}
}