//HintName: G.Models.GetChannelFollowersResponseDataItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetChannelFollowersResponseDataItem
    {
        /// <summary>
        /// The UTC timestamp when the user started following the broadcaster.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("followed_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime FollowedAt { get; set; } = default!;

        /// <summary>
        /// An ID that uniquely identifies the user that’s following the broadcaster.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string UserId { get; set; } = default!;

        /// <summary>
        /// The user’s login name.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user_login", Required = global::Newtonsoft.Json.Required.Always)]
        public string UserLogin { get; set; } = default!;

        /// <summary>
        /// The user’s display name.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string UserName { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetChannelFollowersResponseDataItem" /> class.
        /// </summary>
        /// <param name="followedAt">
        /// The UTC timestamp when the user started following the broadcaster.
        /// </param>
        /// <param name="userId">
        /// An ID that uniquely identifies the user that’s following the broadcaster.
        /// </param>
        /// <param name="userLogin">
        /// The user’s login name.
        /// </param>
        /// <param name="userName">
        /// The user’s display name.
        /// </param>
        public GetChannelFollowersResponseDataItem(
            global::System.DateTime followedAt,
            string userId,
            string userLogin,
            string userName)
        {
            this.FollowedAt = followedAt;
            this.UserId = userId ?? throw new global::System.ArgumentNullException(nameof(userId));
            this.UserLogin = userLogin ?? throw new global::System.ArgumentNullException(nameof(userLogin));
            this.UserName = userName ?? throw new global::System.ArgumentNullException(nameof(userName));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetChannelFollowersResponseDataItem" /> class.
        /// </summary>
        public GetChannelFollowersResponseDataItem()
        {
        }
    }
}