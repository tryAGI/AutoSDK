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
        [global::System.Text.Json.Serialization.JsonPropertyName("followed_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime FollowedAt { get; set; }

        /// <summary>
        /// An ID that uniquely identifies the user that’s following the broadcaster.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserId { get; set; }

        /// <summary>
        /// The user’s login name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_login")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserLogin { get; set; }

        /// <summary>
        /// The user’s display name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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