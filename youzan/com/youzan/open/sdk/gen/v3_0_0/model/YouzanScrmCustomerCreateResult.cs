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


	public class YouzanScrmCustomerCreateResult : APIResult
	{



		/// <summary>
		/// 帐号ID
		/// </summary>
[Newtonsoft.Json.JsonProperty("account_id")]//) private String accountId;
		private string accountId;


		/// <summary>
		/// 帐号类型。目前支持以下选项（只支持传一种）： FansID：自有粉丝ID， Mobile：手机号， YouZanAccount：有赞账号
		/// </summary>
[Newtonsoft.Json.JsonProperty("account_type")]//) private String accountType;
		private string accountType;

		public virtual string AccountId
		{
			set
			{
				this.accountId = value;
			}
			get
			{
				return this.accountId;
			}
		}

		public virtual string AccountType
		{
			set
			{
				this.accountType = value;
			}
			get
			{
				return this.accountType;
			}
		}



	}
}