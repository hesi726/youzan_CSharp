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


	public class YouzanSalesmanTradesAccountGetResult : APIResult
	{



		/// <summary>
		/// 分销员手机号
		/// </summary>
[Newtonsoft.Json.JsonProperty("mobile")]//) private String mobile;
		private string mobile;

		public virtual string Mobile
		{
			set
			{
				this.mobile = value;
			}
			get
			{
				return this.mobile;
			}
		}



	}
}