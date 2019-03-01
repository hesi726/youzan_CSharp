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


	public class YouzanRetailStockStockreturnCreateResult : APIResult
	{



		/// <summary>
		/// 退货入库单号
		/// </summary>
[Newtonsoft.Json.JsonProperty("returnInOrder")]//) private String returnInOrder;
		private string returnInOrder;

		public virtual string ReturnInOrder
		{
			set
			{
				this.returnInOrder = value;
			}
			get
			{
				return this.returnInOrder;
			}
		}



	}
}