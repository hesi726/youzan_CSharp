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


	public class YouzanMaterialsVideoUploadPublishResult : APIResult
	{



		/// <summary>
		/// 视频video_id
		/// </summary>
[Newtonsoft.Json.JsonProperty("video_id")]//) private Nullable<long> videoId;
		private long? videoId;

		public virtual long? VideoId
		{
			set
			{
				this.videoId = value;
			}
			get
			{
				return this.videoId;
			}
		}



	}
}