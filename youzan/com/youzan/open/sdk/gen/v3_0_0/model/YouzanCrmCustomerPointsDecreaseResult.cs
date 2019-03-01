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


	public class YouzanCrmCustomerPointsDecreaseResult : APIResult
	{



		/// <summary>
		/// true表示操作成功，false表示操作失败
		/// </summary>
[Newtonsoft.Json.JsonProperty("is_success")]//) private String isSuccess;
		private string isSuccess;

		public virtual string IsSuccess
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