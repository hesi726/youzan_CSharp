using System.Collections;

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


	public class YouzanLogisticsFeeGetResult : APIResult
	{



		/// <summary>
		/// 区县id
		/// </summary>
[Newtonsoft.Json.JsonProperty("countyId")]//) private Nullable<long> countyId;
		private long? countyId;


		/// <summary>
		/// 订单总快递费
		/// </summary>
[Newtonsoft.Json.JsonProperty("totalPostage")]//) private Nullable<long> totalPostage;
		private long? totalPostage;


		/// <summary>
		/// 商品运费详情 key=itemId, value=postage
		/// </summary>
[Newtonsoft.Json.JsonProperty("itemsPostage")]//) private java.util.Map itemsPostage;
		private IDictionary itemsPostage;

		public virtual long? CountyId
		{
			set
			{
				this.countyId = value;
			}
			get
			{
				return this.countyId;
			}
		}

		public virtual long? TotalPostage
		{
			set
			{
				this.totalPostage = value;
			}
			get
			{
				return this.totalPostage;
			}
		}

		public virtual IDictionary ItemsPostage
		{
			set
			{
				this.itemsPostage = value;
			}
			get
			{
				return this.itemsPostage;
			}
		}


		public class Map
		{


			/// <summary>
			/// 待更新商品id
			/// </summary>
[Newtonsoft.Json.JsonProperty("skuId")]//) private Nullable<long> skuId;
				internal long? skuId;


			/// <summary>
			/// 是否更新成功
			/// </summary>
[Newtonsoft.Json.JsonProperty("result")]//) private Nullable<bool> result;
				internal bool? result;

				public virtual long? SkuId
				{
					set
					{
					this.skuId = value;
					}
					get
					{
					return this.skuId;
					}
				}


				public virtual bool? Result
				{
					set
					{
					this.result = value;
					}
					get
					{
					return this.result;
					}
				}


		}


	}
}