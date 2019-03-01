﻿using System.Collections.Generic;

namespace com.youzan.open.sdk.gen.v3_0_0.model
{

////	using ArrayListMultimap = com.google.common.collect.ArrayListMultimap;
	using global::youzan.com.youzan.open.sdk.model;

	using global::youzan.com.youzan.open.sdk.model;

////	using Maps = com.google.common.collect.Maps;
	using global::youzan.com.youzan.open.sdk.model;

	using global::youzan.com.youzan.open.sdk.model;

////	using Multimap = com.google.common.collect.Multimap;
	using global::youzan.com.youzan.open.sdk.model;

	using global::youzan.com.youzan.open.sdk.model;

	using APIParams = com.youzan.open.sdk.model.APIParams;
	using ByteWrapper = com.youzan.open.sdk.model.ByteWrapper;
	using FileParams = com.youzan.open.sdk.model.FileParams;

	public class YouzanLogisticsOnlineCanceldelayParams : APIParams, FileParams
	{

		/// <summary>
		/// 待取消顺延期次
		/// </summary>
		private long? issue;
		/// <summary>
		/// 交易编号
		/// </summary>
		private string tid;

		public virtual long? Issue
		{
			set
			{
				this.issue = value;
			}
			get
			{
				return this.issue;
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



		public virtual IDictionary<string, object> toParams()
		{
			IDictionary<string, object> @params = Maps.newHashMap();
			if (issue != null)
			{
				@params["issue"] = issue;
			}
			if (!string.ReferenceEquals(tid, null))
			{
				@params["tid"] = tid;
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