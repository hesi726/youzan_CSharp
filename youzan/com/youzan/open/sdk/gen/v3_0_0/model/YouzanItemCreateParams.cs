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

	public class YouzanItemCreateParams : APIParams, FileParams
	{

		/// <summary>
		/// 开始出售时间。默认0，设置为0 立即出售
		/// </summary>
		private long? autoListingTime;
		/// <summary>
		/// 每人限购多少件。0代表无限购，默认为0
		/// </summary>
		private long? buyQuota;
		/// <summary>
		/// 商品分类的叶子类目id
		/// </summary>
		private long? cid;
		/// <summary>
		/// 运费模版id
		/// </summary>
		private long? deliveryTemplateId;
		/// <summary>
		/// 商品描述。字数要大于5个字符，小于25000个字符 ，受违禁词控制
		/// </summary>
		private string desc;
		/// <summary>
		/// 付款成功 后发货天数, 默认0
		/// </summary>
		private long? etdDays;
		/// <summary>
		/// 预计发货结束时间, 字符串格式的时间
		/// </summary>
		private string etdEnd;
		/// <summary>
		/// 预计发货开始时间, 字符串格式的时间
		/// </summary>
		private string etdStart;
		/// <summary>
		/// 发货类型: 0, xxx 时间开始发货, 1, 付款 n 天后发货。
		/// </summary>
		private long? etdType;
		/// <summary>
		/// 是否隐藏商品库存。在商品展示时不显示商品的库存，默认0 显示库存，设置为1 不显示库存
		/// </summary>
		private long? hideStock;
		/// <summary>
		/// 酒店扩展信息，按以下格式：
		/// {
		/// "service_tel_code":"0571",//服务电话区号
		/// "service_tel":"4790043"//服务电话
		/// }
		/// </summary>
		private string hotelExtra;
		/// <summary>
		/// 图片id列表，用逗号分隔。可以通过 youzan.materials.storage.platform.img.upload 上传图片接口去上传图片后获取图片id 。
		/// </summary>
		private string imageIds;
		/// <summary>
		/// 是否上架商品。默认1 上架商品，设置为0 不上架商品，放入仓库
		/// </summary>
		private long? isDisplay;
		/// <summary>
		/// 商品货号（商家为商品设置的外部编号）
		/// </summary>
		private string itemNo;
		/// <summary>
		/// 商品类型
		/// 0：普通商品
		/// 35：酒店商品
		/// 60：虚拟商品
		/// 61：电子卡券
		/// </summary>
		private long? itemType;
		/// <summary>
		/// 商品重量，没有SKU时用
		/// </summary>
		private long? itemWeight;
		/// <summary>
		/// 是否参加会员折扣。默认1，设置为1 参加会员折扣
		/// </summary>
		private long? joinLevelDiscount;
		/// <summary>
		/// 商品留言
		/// </summary>
		private string messages;
		/// <summary>
		/// 商品划线价格，可以自定义。例如 促销价：888
		/// </summary>
		private string originPrice;
		/// <summary>
		/// 运费，单位分
		/// </summary>
		private long? postFee;
		/// <summary>
		/// 是否预售
		/// </summary>
		private bool? preSale;
		/// <summary>
		/// 预售结束时间, 字符串格式的时间
		/// </summary>
		private string preSaleEnd;
		/// <summary>
		/// 价格，单位分
		/// </summary>
		private long? price;
		/// <summary>
		/// 是否设置商品购买权限
		/// </summary>
		private bool? purchaseRight;
		/// <summary>
		/// 总库存
		/// </summary>
		private long? quantity;
		/// <summary>
		/// 商品卖点信息
		/// </summary>
		private string sellPoint;
		/// <summary>
		/// SKU图片，仅支持第一级规格，
		/// 参数一定要与sku_stocks参数匹配，
		/// 如sku_stocks参数是这样的
		/// [ { "price":10000, "quantity":100, "item_no":"MOYU-1", "skus":[ { "k":"颜色", "v":"绿色", }, { "k":"尺寸", "v":"l", }, { "k":"内存", "v":"1024G", } ] }, { "price":10000, "quantity":100, "item_no":"MOYU-2","skus":[ { "k":"颜色", "v":"绿色", }, { "k":"尺寸", "v":"l", }, { "k":"内存", "v":"16G", } ] } ]
		/// 颜色就是第一级规格。它下面的规格只有"绿色"这一项，sku_images应该与之一一对应，如下
		/// [{"v":"绿色","img_url":"www.youzan.com"}]
		/// 请务必按此格式传参数，不然校验通不过，无法新增商品
		/// 
		/// </summary>
		private string skuImages;
		/// <summary>
		/// sku 的JSON字符串，传入一定要按照这个格式[ { "price":10000, "quantity":100, "item_no":"MOYU-1", "skus":[ { "k":"颜色", "v":"绿色", }, { "k":"尺寸", "v":"l", }, { "k":"内存", "v":"1024G", } ] }, { "price":10000, "quantity":100, "item_no":"MOYU-2","skus":[ { "k":"颜色", "v":"绿色", }, { "k":"尺寸", "v":"l", }, { "k":"内存", "v":"16G", } ] } ] price是 sku 价格，quantity 是sku 的库存，item_no 是 sku 的商家编码，k 是规格名称，v 是规格值名称
		/// 要注意：sku_stocks数量=规格1数量 * 规格2数量 * 规格3数量
		/// </summary>
		private string skuStocks;
		/// <summary>
		/// SKU重量带有SKU时用
		/// 按如下格式
		/// [
		/// {
		/// "s1":1217,
		/// "s2":1367,
		/// "s3":303435,
		/// "weight":100
		/// },
		/// {
		/// "s1":1217,
		/// "s2":1367,
		/// "s3":6356,
		/// "weight":100
		/// }
		/// ]
		/// 并且和SKU对应
		/// </summary>
		private string skuWeight;
		/// <summary>
		/// 分组列表
		/// </summary>
		private string tagIds;
		/// <summary>
		/// 商品页模板
		/// </summary>
		private long? templateId;
		/// <summary>
		/// 商品标题。不能超过100字，受违禁词控制
		/// </summary>
		private string title;
		/// <summary>
		/// 允许购买的粉丝等级，用逗号分隔
		/// </summary>
		private string umpLevel;
		/// <summary>
		/// 允许购买的粉丝标签，用,号分隔
		/// </summary>
		private string umpTags;
		/// <summary>
		/// 虚拟信息扩展信息，一定要按如下JSON格式，否则校验不通过
		/// {
		/// "item_validity_start":2322222,//虚拟商品有效期开始时间, 1970-01-01 开始的秒数,留空表示长期有效
		/// "item_validity_end":2322222,//虚拟商品有效期结束时间,1970-01-01 开始的秒数,留空表示长期有效
		/// "effective_type":1,//电子凭证生效类型，0 立即生效， 1 自定义推迟时间， 2 隔天生效
		/// "effective_delay_hours":1,//电子凭证自定义推迟时间
		/// "holidays_available":true//节假日是否可用
		/// }
		/// </summary>
		private string virtualExtra;

		public virtual long? AutoListingTime
		{
			set
			{
				this.autoListingTime = value;
			}
			get
			{
				return this.autoListingTime;
			}
		}


		public virtual long? BuyQuota
		{
			set
			{
				this.buyQuota = value;
			}
			get
			{
				return this.buyQuota;
			}
		}


		public virtual long? Cid
		{
			set
			{
				this.cid = value;
			}
			get
			{
				return this.cid;
			}
		}


		public virtual long? DeliveryTemplateId
		{
			set
			{
				this.deliveryTemplateId = value;
			}
			get
			{
				return this.deliveryTemplateId;
			}
		}


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


		public virtual long? EtdDays
		{
			set
			{
				this.etdDays = value;
			}
			get
			{
				return this.etdDays;
			}
		}


		public virtual string EtdEnd
		{
			set
			{
				this.etdEnd = value;
			}
			get
			{
				return this.etdEnd;
			}
		}


		public virtual string EtdStart
		{
			set
			{
				this.etdStart = value;
			}
			get
			{
				return this.etdStart;
			}
		}


		public virtual long? EtdType
		{
			set
			{
				this.etdType = value;
			}
			get
			{
				return this.etdType;
			}
		}


		public virtual long? HideStock
		{
			set
			{
				this.hideStock = value;
			}
			get
			{
				return this.hideStock;
			}
		}


		public virtual string HotelExtra
		{
			set
			{
				this.hotelExtra = value;
			}
			get
			{
				return this.hotelExtra;
			}
		}


		public virtual string ImageIds
		{
			set
			{
				this.imageIds = value;
			}
			get
			{
				return this.imageIds;
			}
		}


		public virtual long? IsDisplay
		{
			set
			{
				this.isDisplay = value;
			}
			get
			{
				return this.isDisplay;
			}
		}


		public virtual string ItemNo
		{
			set
			{
				this.itemNo = value;
			}
			get
			{
				return this.itemNo;
			}
		}


		public virtual long? ItemType
		{
			set
			{
				this.itemType = value;
			}
			get
			{
				return this.itemType;
			}
		}


		public virtual long? ItemWeight
		{
			set
			{
				this.itemWeight = value;
			}
			get
			{
				return this.itemWeight;
			}
		}


		public virtual long? JoinLevelDiscount
		{
			set
			{
				this.joinLevelDiscount = value;
			}
			get
			{
				return this.joinLevelDiscount;
			}
		}


		public virtual string Messages
		{
			set
			{
				this.messages = value;
			}
			get
			{
				return this.messages;
			}
		}


		public virtual string OriginPrice
		{
			set
			{
				this.originPrice = value;
			}
			get
			{
				return this.originPrice;
			}
		}


		public virtual long? PostFee
		{
			set
			{
				this.postFee = value;
			}
			get
			{
				return this.postFee;
			}
		}


		public virtual bool? PreSale
		{
			set
			{
				this.preSale = value;
			}
			get
			{
				return this.preSale;
			}
		}


		public virtual string PreSaleEnd
		{
			set
			{
				this.preSaleEnd = value;
			}
			get
			{
				return this.preSaleEnd;
			}
		}


		public virtual long? Price
		{
			set
			{
				this.price = value;
			}
			get
			{
				return this.price;
			}
		}


		public virtual bool? PurchaseRight
		{
			set
			{
				this.purchaseRight = value;
			}
			get
			{
				return this.purchaseRight;
			}
		}


		public virtual long? Quantity
		{
			set
			{
				this.quantity = value;
			}
			get
			{
				return this.quantity;
			}
		}


		public virtual string SellPoint
		{
			set
			{
				this.sellPoint = value;
			}
			get
			{
				return this.sellPoint;
			}
		}


		public virtual string SkuImages
		{
			set
			{
				this.skuImages = value;
			}
			get
			{
				return this.skuImages;
			}
		}


		public virtual string SkuStocks
		{
			set
			{
				this.skuStocks = value;
			}
			get
			{
				return this.skuStocks;
			}
		}


		public virtual string SkuWeight
		{
			set
			{
				this.skuWeight = value;
			}
			get
			{
				return this.skuWeight;
			}
		}


		public virtual string TagIds
		{
			set
			{
				this.tagIds = value;
			}
			get
			{
				return this.tagIds;
			}
		}


		public virtual long? TemplateId
		{
			set
			{
				this.templateId = value;
			}
			get
			{
				return this.templateId;
			}
		}


		public virtual string Title
		{
			set
			{
				this.title = value;
			}
			get
			{
				return this.title;
			}
		}


		public virtual string UmpLevel
		{
			set
			{
				this.umpLevel = value;
			}
			get
			{
				return this.umpLevel;
			}
		}


		public virtual string UmpTags
		{
			set
			{
				this.umpTags = value;
			}
			get
			{
				return this.umpTags;
			}
		}


		public virtual string VirtualExtra
		{
			set
			{
				this.virtualExtra = value;
			}
			get
			{
				return this.virtualExtra;
			}
		}



		public virtual IDictionary<string, object> toParams()
		{
			IDictionary<string, object> @params = Maps.newHashMap();
			if (autoListingTime != null)
			{
				@params["auto_listing_time"] = autoListingTime;
			}
			if (buyQuota != null)
			{
				@params["buy_quota"] = buyQuota;
			}
			if (cid != null)
			{
				@params["cid"] = cid;
			}
			if (deliveryTemplateId != null)
			{
				@params["delivery_template_id"] = deliveryTemplateId;
			}
			if (!string.ReferenceEquals(desc, null))
			{
				@params["desc"] = desc;
			}
			if (etdDays != null)
			{
				@params["etd_days"] = etdDays;
			}
			if (!string.ReferenceEquals(etdEnd, null))
			{
				@params["etd_end"] = etdEnd;
			}
			if (!string.ReferenceEquals(etdStart, null))
			{
				@params["etd_start"] = etdStart;
			}
			if (etdType != null)
			{
				@params["etd_type"] = etdType;
			}
			if (hideStock != null)
			{
				@params["hide_stock"] = hideStock;
			}
			if (!string.ReferenceEquals(hotelExtra, null))
			{
				@params["hotel_extra"] = hotelExtra;
			}
			if (!string.ReferenceEquals(imageIds, null))
			{
				@params["image_ids"] = imageIds;
			}
			if (isDisplay != null)
			{
				@params["is_display"] = isDisplay;
			}
			if (!string.ReferenceEquals(itemNo, null))
			{
				@params["item_no"] = itemNo;
			}
			if (itemType != null)
			{
				@params["item_type"] = itemType;
			}
			if (itemWeight != null)
			{
				@params["item_weight"] = itemWeight;
			}
			if (joinLevelDiscount != null)
			{
				@params["join_level_discount"] = joinLevelDiscount;
			}
			if (!string.ReferenceEquals(messages, null))
			{
				@params["messages"] = messages;
			}
			if (!string.ReferenceEquals(originPrice, null))
			{
				@params["origin_price"] = originPrice;
			}
			if (postFee != null)
			{
				@params["post_fee"] = postFee;
			}
			if (preSale != null)
			{
				@params["pre_sale"] = preSale;
			}
			if (!string.ReferenceEquals(preSaleEnd, null))
			{
				@params["pre_sale_end"] = preSaleEnd;
			}
			if (price != null)
			{
				@params["price"] = price;
			}
			if (purchaseRight != null)
			{
				@params["purchase_right"] = purchaseRight;
			}
			if (quantity != null)
			{
				@params["quantity"] = quantity;
			}
			if (!string.ReferenceEquals(sellPoint, null))
			{
				@params["sell_point"] = sellPoint;
			}
			if (!string.ReferenceEquals(skuImages, null))
			{
				@params["sku_images"] = skuImages;
			}
			if (!string.ReferenceEquals(skuStocks, null))
			{
				@params["sku_stocks"] = skuStocks;
			}
			if (!string.ReferenceEquals(skuWeight, null))
			{
				@params["sku_weight"] = skuWeight;
			}
			if (!string.ReferenceEquals(tagIds, null))
			{
				@params["tag_ids"] = tagIds;
			}
			if (templateId != null)
			{
				@params["template_id"] = templateId;
			}
			if (!string.ReferenceEquals(title, null))
			{
				@params["title"] = title;
			}
			if (!string.ReferenceEquals(umpLevel, null))
			{
				@params["ump_level"] = umpLevel;
			}
			if (!string.ReferenceEquals(umpTags, null))
			{
				@params["ump_tags"] = umpTags;
			}
			if (!string.ReferenceEquals(virtualExtra, null))
			{
				@params["virtual_extra"] = virtualExtra;
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