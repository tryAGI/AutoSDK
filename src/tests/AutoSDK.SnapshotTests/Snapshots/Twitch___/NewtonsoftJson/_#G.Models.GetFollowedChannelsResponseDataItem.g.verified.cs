//HintName: G.Models.GetFollowedChannelsResponseDataItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetFollowedChannelsResponseDataItem
    {
        /// <summary>
        /// An ID that uniquely identifies the broadcaster that this user is following.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("broadcaster_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string BroadcasterId { get; set; } = default!;

        /// <summary>
        /// The broadcaster’s login name.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("broadcaster_login", Required = global::Newtonsoft.Json.Required.Always)]
        public string BroadcasterLogin { get; set; } = default!;

        /// <summary>
        /// The broadcaster’s display name.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("broadcaster_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string BroadcasterName { get; set; } = default!;

        /// <summary>
        /// The UTC timestamp when the user started following the broadcaster.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("followed_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime FollowedAt { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetFollowedChannelsResponseDataItem" /> class.
        /// </summary>
        /// <param name="broadcasterId">
        /// An ID that uniquely identifies the broadcaster that this user is following.
        /// </param>
        /// <param name="broadcasterLogin">
        /// The broadcaster’s login name.
        /// </param>
        /// <param name="broadcasterName">
        /// The broadcaster’s display name.
        /// </param>
        /// <param name="followedAt">
        /// The UTC timestamp when the user started following the broadcaster.
        /// </param>
        public GetFollowedChannelsResponseDataItem(
            string broadcasterId,
            string broadcasterLogin,
            string broadcasterName,
            global::System.DateTime followedAt)
        {
            this.BroadcasterId = broadcasterId ?? throw new global::System.ArgumentNullException(nameof(broadcasterId));
            this.BroadcasterLogin = broadcasterLogin ?? throw new global::System.ArgumentNullException(nameof(broadcasterLogin));
            this.BroadcasterName = broadcasterName ?? throw new global::System.ArgumentNullException(nameof(broadcasterName));
            this.FollowedAt = followedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetFollowedChannelsResponseDataItem" /> class.
        /// </summary>
        public GetFollowedChannelsResponseDataItem()
        {
        }
    }
}