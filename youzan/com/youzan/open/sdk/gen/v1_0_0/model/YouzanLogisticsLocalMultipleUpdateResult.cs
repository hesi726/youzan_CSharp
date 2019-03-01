﻿namespace com.youzan.open.sdk.gen.v1_0_0.model
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


	public class YouzanLogisticsLocalMultipleUpdateResult : APIResult
	{



		/// <summary>
		/// 返回成功或失败
		/// </summary>
[Newtonsoft.Json.JsonProperty("isSucess")]//) private Nullable<bool> isSucess;
		private bool? isSucess;

		public virtual bool? IsSucess
		{
			set
			{
				this.isSucess = value;
			}
			get
			{
				return this.isSucess;
			}
		}



	}
}