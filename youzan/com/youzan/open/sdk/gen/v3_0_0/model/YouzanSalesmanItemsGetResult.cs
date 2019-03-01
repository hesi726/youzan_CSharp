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


	public class YouzanSalesmanItemsGetResult : APIResult
	{



		/// <summary>
		/// 商品设置信息
		/// </summary>
[Newtonsoft.Json.JsonProperty("items")]//) private SalesmanTradeGoods[] items;
		private SalesmanTradeGoods[] items;

		public virtual SalesmanTradeGoods[] Items
		{
			set
			{
				this.items = value;
			}
			get
			{
				return this.items;
			}
		}


		public class SalesmanTradeGoods
		{


			/// <summary>
			/// 商品是否参与推广0:不参与1参与
			/// </summary>
[Newtonsoft.Json.JsonProperty("is_join")]//) private Nullable<long> isJoin;
				internal long? isJoin;


			/// <summary>
			/// 商品ID
			/// </summary>
[Newtonsoft.Json.JsonProperty("num_iid")]//) private String numIid;
				internal string numIid;


			/// <summary>
			/// 商品邀请奖励提成比例(%)
			/// </summary>
[Newtonsoft.Json.JsonProperty("ii_rate")]//) private String iiRate;
				internal string iiRate;


			/// <summary>
			/// 商品提成比例(%)
			/// </summary>
[Newtonsoft.Json.JsonProperty("i_rate")]//) private String iRate;
				internal string iRate;

				public virtual long? IsJoin
				{
					set
					{
					this.isJoin = value;
					}
					get
					{
					return this.isJoin;
					}
				}


				public virtual string NumIid
				{
					set
					{
					this.numIid = value;
					}
					get
					{
					return this.numIid;
					}
				}


				public virtual string IiRate
				{
					set
					{
					this.iiRate = value;
					}
					get
					{
					return this.iiRate;
					}
				}


				public virtual string IRate
				{
					set
					{
					this.iRate = value;
					}
					get
					{
					return this.iRate;
					}
				}


		}


	}
}