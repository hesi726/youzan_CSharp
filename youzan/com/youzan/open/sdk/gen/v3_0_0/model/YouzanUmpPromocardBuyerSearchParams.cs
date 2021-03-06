﻿using System.Collections.Generic;

namespace com.youzan.open.sdk.gen.v3_0_0.model
{

    ////	using ArrayListMultimap = com.google.common.collect.ArrayListMultimap;
    using global::youzan.com.youzan.open.sdk.model;

    ////	using Maps = com.google.common.collect.Maps;


    ////	using Multimap = com.google.common.collect.Multimap;


    using APIParams = com.youzan.open.sdk.model.APIParams;
    using ByteWrapper = com.youzan.open.sdk.model.ByteWrapper;
    using FileParams = com.youzan.open.sdk.model.FileParams;

    public class YouzanUmpPromocardBuyerSearchParams : APIParams, FileParams
	{

		/// <summary>
		/// fans_id 
		/// </summary>
		private long? fansId;
		/// <summary>
		/// fans_type
		/// </summary>
		private long? fansType;
		/// <summary>
		/// 手机号
		/// </summary>
		private long? mobile;
		/// <summary>
		/// open_user_id
		/// </summary>
		private long? openUserId;
		/// <summary>
		/// VALID 有效（未使用） USED 已使用 INVALID 已失效
		/// </summary>
		private string status;

		public virtual long? FansId
		{
			set
			{
				this.fansId = value;
			}
			get
			{
				return this.fansId;
			}
		}


		public virtual long? FansType
		{
			set
			{
				this.fansType = value;
			}
			get
			{
				return this.fansType;
			}
		}


		public virtual long? Mobile
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


		public virtual long? OpenUserId
		{
			set
			{
				this.openUserId = value;
			}
			get
			{
				return this.openUserId;
			}
		}


		public virtual string Status
		{
			set
			{
				this.status = value;
			}
			get
			{
				return this.status;
			}
		}



		public virtual IDictionary<string, object> toParams()
		{
			IDictionary<string, object> @params = Maps.newHashMap();
			if (fansId != null)
			{
				@params["fans_id"] = fansId;
			}
			if (fansType != null)
			{
				@params["fans_type"] = fansType;
			}
			if (mobile != null)
			{
				@params["mobile"] = mobile;
			}
			if (openUserId != null)
			{
				@params["open_user_id"] = openUserId;
			}
			if (!string.ReferenceEquals(status, null))
			{
				@params["status"] = status;
			}
			return @params;
		}

		public virtual IDictionary<string,ByteWrapper> toFileParams()
		{
			Multimap<string, ByteWrapper> @params = ArrayListMultimap.create<string, ByteWrapper>();

				return @params;
		}


	}
}