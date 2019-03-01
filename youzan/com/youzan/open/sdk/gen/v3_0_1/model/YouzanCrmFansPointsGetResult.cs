namespace com.youzan.open.sdk.gen.v3_0_1.model
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


	public class YouzanCrmFansPointsGetResult : APIResult
	{



		/// <summary>
		/// 积分
		/// </summary>
[Newtonsoft.Json.JsonProperty("point")]//) private String point;
		private string point;

		public virtual string Point
		{
			set
			{
				this.point = value;
			}
			get
			{
				return this.point;
			}
		}



	}
}