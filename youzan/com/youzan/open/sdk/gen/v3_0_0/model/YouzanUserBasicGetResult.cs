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


	public class YouzanUserBasicGetResult : APIResult
	{



		/// <summary>
		/// 用户ID
		/// </summary>
[Newtonsoft.Json.JsonProperty("user_id")]//) private Nullable<long> userId;
		private long? userId;


		/// <summary>
		/// 昵称
		/// </summary>
[Newtonsoft.Json.JsonProperty("nick_name")]//) private String nickName;
		private string nickName;


		/// <summary>
		/// 图片地址
		/// </summary>
[Newtonsoft.Json.JsonProperty("avatar")]//) private String avatar;
		private string avatar;

		public virtual long? UserId
		{
			set
			{
				this.userId = value;
			}
			get
			{
				return this.userId;
			}
		}

		public virtual string NickName
		{
			set
			{
				this.nickName = value;
			}
			get
			{
				return this.nickName;
			}
		}

		public virtual string Avatar
		{
			set
			{
				this.avatar = value;
			}
			get
			{
				return this.avatar;
			}
		}



	}
}