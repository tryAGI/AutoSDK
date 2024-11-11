//HintName: G.Models.GetModeratedChannelsResponseDataItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetModeratedChannelsResponseDataItem
    {
        /// <summary>
        /// An ID that uniquely identifies the channel this user can moderate.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("broadcaster_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BroadcasterId { get; set; }

        /// <summary>
        /// The channel’s login name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("broadcaster_login")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BroadcasterLogin { get; set; }

        /// <summary>
        /// The channels’ display name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("broadcaster_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BroadcasterName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetModeratedChannelsResponseDataItem" /> class.
        /// </summary>
        /// <param name="broadcasterId">
        /// An ID that uniquely identifies the channel this user can moderate.
        /// </param>
        /// <param name="broadcasterLogin">
        /// The channel’s login name.
        /// </param>
        /// <param name="broadcasterName">
        /// The channels’ display name.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public GetModeratedChannelsResponseDataItem(
            string broadcasterId,
            string broadcasterLogin,
            string broadcasterName)
        {
            this.BroadcasterId = broadcasterId ?? throw new global::System.ArgumentNullException(nameof(broadcasterId));
            this.BroadcasterLogin = broadcasterLogin ?? throw new global::System.ArgumentNullException(nameof(broadcasterLogin));
            this.BroadcasterName = broadcasterName ?? throw new global::System.ArgumentNullException(nameof(broadcasterName));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetModeratedChannelsResponseDataItem" /> class.
        /// </summary>
        public GetModeratedChannelsResponseDataItem()
        {
        }
    }
}