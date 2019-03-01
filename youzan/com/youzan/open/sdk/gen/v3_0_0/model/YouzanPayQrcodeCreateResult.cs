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


	public class YouzanPayQrcodeCreateResult : APIResult
	{



		/// <summary>
		/// 二维码收银台Url
		/// </summary>
[Newtonsoft.Json.JsonProperty("qr_url")]//) private String qrUrl;
		private string qrUrl;


		/// <summary>
		/// 二维码图标
		/// </summary>
[Newtonsoft.Json.JsonProperty("qr_code")]//) private String qrCode;
		private string qrCode;


		/// <summary>
		/// 二维码标识
		/// </summary>
[Newtonsoft.Json.JsonProperty("qr_id")]//) private Nullable<long> qrId;
		private long? qrId;

		public virtual string QrUrl
		{
			set
			{
				this.qrUrl = value;
			}
			get
			{
				return this.qrUrl;
			}
		}

		public virtual string QrCode
		{
			set
			{
				this.qrCode = value;
			}
			get
			{
				return this.qrCode;
			}
		}

		public virtual long? QrId
		{
			set
			{
				this.qrId = value;
			}
			get
			{
				return this.qrId;
			}
		}



	}
}