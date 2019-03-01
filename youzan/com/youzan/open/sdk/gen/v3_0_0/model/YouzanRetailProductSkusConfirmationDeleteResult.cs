﻿namespace com.youzan.open.sdk.gen.v3_0_0.model
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


	public class YouzanRetailProductSkusConfirmationDeleteResult : APIResult
	{



		/// <summary>
		/// 关联门店商品数量
		/// </summary>
[Newtonsoft.Json.JsonProperty("offlineTotalCount")]//) private Nullable<long> offlineTotalCount;
		private long? offlineTotalCount;


		/// <summary>
		/// 关联网店商品数量
		/// </summary>
[Newtonsoft.Json.JsonProperty("onlineTotalCount")]//) private Nullable<long> onlineTotalCount;
		private long? onlineTotalCount;

		public virtual long? OfflineTotalCount
		{
			set
			{
				this.offlineTotalCount = value;
			}
			get
			{
				return this.offlineTotalCount;
			}
		}

		public virtual long? OnlineTotalCount
		{
			set
			{
				this.onlineTotalCount = value;
			}
			get
			{
				return this.onlineTotalCount;
			}
		}



	}
}