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

    public class YouzanTradeRefundSellerActiveParams : APIParams, FileParams
	{

		/// <summary>
		/// 退款原因
		/// </summary>
		private string desc;
		/// <summary>
		/// 订单商品id
		/// </summary>
		private long? oid;
		/// <summary>
		/// 退款金额
		/// </summary>
		private float? refundFee;
		/// <summary>
		/// 订单号
		/// </summary>
		private string tid;

		public virtual string Desc
		{
			set
			{
				this.desc = value;
			}
			get
			{
				return this.desc;
			}
		}


		public virtual long? Oid
		{
			set
			{
				this.oid = value;
			}
			get
			{
				return this.oid;
			}
		}


		public virtual float? RefundFee
		{
			set
			{
				this.refundFee = value;
			}
			get
			{
				return this.refundFee;
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
			if (!string.ReferenceEquals(desc, null))
			{
				@params["desc"] = desc;
			}
			if (oid != null)
			{
				@params["oid"] = oid;
			}
			if (refundFee != null)
			{
				@params["refund_fee"] = refundFee;
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