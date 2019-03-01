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


	public class YouzanTradeRefundSellerActiveResult : APIResult
	{



		/// <summary>
		/// 操作是否成功
		/// </summary>
[Newtonsoft.Json.JsonProperty("is_success")]//) private Nullable<bool> isSuccess;
		private bool? isSuccess;


		/// <summary>
		/// 成功退款的ID
		/// </summary>
[Newtonsoft.Json.JsonProperty("refund_id")]//) private String refundId;
		private string refundId;

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

		public virtual string RefundId
		{
			set
			{
				this.refundId = value;
			}
			get
			{
				return this.refundId;
			}
		}



	}
}