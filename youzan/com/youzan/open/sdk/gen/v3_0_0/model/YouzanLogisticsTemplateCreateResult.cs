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


	public class YouzanLogisticsTemplateCreateResult : APIResult
	{



		/// <summary>
		/// 运费模板id
		/// </summary>
[Newtonsoft.Json.JsonProperty("templateId")]//) private Nullable<long> templateId;
		private long? templateId;

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



	}
}