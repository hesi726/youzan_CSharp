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


	public class YouzanTradeQrcodeHasoutidGetResult : APIResult
	{



		/// <summary>
		/// 0未支付，1已支付
		/// </summary>
[Newtonsoft.Json.JsonProperty("pay_state")]//) private Nullable<long> payState;
		private long? payState;


		/// <summary>
		/// 支付时间
		/// </summary>
[Newtonsoft.Json.JsonProperty("pay_time")]//) private Nullable<long> payTime;
		private long? payTime;


		/// <summary>
		/// 支付方式
		/// </summary>
[Newtonsoft.Json.JsonProperty("pay_way")]//) private String payWay;
		private string payWay;


		/// <summary>
		/// 交易单号
		/// </summary>
[Newtonsoft.Json.JsonProperty("tid")]//) private String tid;
		private string tid;

		public virtual long? PayState
		{
			set
			{
				this.payState = value;
			}
			get
			{
				return this.payState;
			}
		}

		public virtual long? PayTime
		{
			set
			{
				this.payTime = value;
			}
			get
			{
				return this.payTime;
			}
		}

		public virtual string PayWay
		{
			set
			{
				this.payWay = value;
			}
			get
			{
				return this.payWay;
			}
		}

		public virtual string Tid
		{
			set
			{
				this.tid = value;
			}
			get
			{
				return this.tid;
			}
		}



	}
}