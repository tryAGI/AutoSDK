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
        [global::System.Text.Json.Serialization.JsonPropertyName("broadcaster_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BroadcasterId { get; set; }

        /// <summary>
        /// The broadcaster’s login name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("broadcaster_login")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BroadcasterLogin { get; set; }

        /// <summary>
        /// The broadcaster’s display name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("broadcaster_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BroadcasterName { get; set; }

        /// <summary>
        /// The UTC timestamp when the user started following the broadcaster.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("followed_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime FollowedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
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