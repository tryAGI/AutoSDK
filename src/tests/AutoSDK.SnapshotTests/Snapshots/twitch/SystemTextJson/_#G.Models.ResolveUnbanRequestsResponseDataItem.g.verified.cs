//HintName: G.Models.ResolveUnbanRequestsResponseDataItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResolveUnbanRequestsResponseDataItem
    {
        /// <summary>
        /// Unban request ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// User ID of broadcaster whose channel is receiving the unban request.
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
        /// User ID of moderator who approved/denied the request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("moderator_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ModeratorId { get; set; }

        /// <summary>
        /// The moderator’s login name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("moderator_login")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ModeratorLogin { get; set; }

        /// <summary>
        /// The moderator’s display name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("moderator_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ModeratorName { get; set; }

        /// <summary>
        /// User ID of the requestor who is asking for an unban.
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
        /// Text of the request from the requesting user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// Status of the request. One of:   <br/>
        ///   <br/>
        /// * approved<br/>
        /// * denied
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Status { get; set; }

        /// <summary>
        /// Timestamp of when the unban request was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Timestamp of when moderator/broadcaster approved or denied the request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolved_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime ResolvedAt { get; set; }

        /// <summary>
        /// Text input by the resolver (moderator) of the unban request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolution_text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ResolutionText { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResolveUnbanRequestsResponseDataItem" /> class.
        /// </summary>
        /// <param name="id">
        /// Unban request ID.
        /// </param>
        /// <param name="broadcasterId">
        /// User ID of broadcaster whose channel is receiving the unban request.
        /// </param>
        /// <param name="broadcasterLogin">
        /// The broadcaster’s login name.
        /// </param>
        /// <param name="broadcasterName">
        /// The broadcaster’s display name.
        /// </param>
        /// <param name="moderatorId">
        /// User ID of moderator who approved/denied the request.
        /// </param>
        /// <param name="moderatorLogin">
        /// The moderator’s login name.
        /// </param>
        /// <param name="moderatorName">
        /// The moderator’s display name.
        /// </param>
        /// <param name="userId">
        /// User ID of the requestor who is asking for an unban.
        /// </param>
        /// <param name="userLogin">
        /// The user’s login name.
        /// </param>
        /// <param name="userName">
        /// The user’s display name.
        /// </param>
        /// <param name="text">
        /// Text of the request from the requesting user.
        /// </param>
        /// <param name="status">
        /// Status of the request. One of:   <br/>
        ///   <br/>
        /// * approved<br/>
        /// * denied
        /// </param>
        /// <param name="createdAt">
        /// Timestamp of when the unban request was created.
        /// </param>
        /// <param name="resolvedAt">
        /// Timestamp of when moderator/broadcaster approved or denied the request.
        /// </param>
        /// <param name="resolutionText">
        /// Text input by the resolver (moderator) of the unban request.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResolveUnbanRequestsResponseDataItem(
            string id,
            string broadcasterId,
            string broadcasterLogin,
            string broadcasterName,
            string moderatorId,
            string moderatorLogin,
            string moderatorName,
            string userId,
            string userLogin,
            string userName,
            string text,
            string status,
            global::System.DateTime createdAt,
            global::System.DateTime resolvedAt,
            string resolutionText)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.BroadcasterId = broadcasterId ?? throw new global::System.ArgumentNullException(nameof(broadcasterId));
            this.BroadcasterLogin = broadcasterLogin ?? throw new global::System.ArgumentNullException(nameof(broadcasterLogin));
            this.BroadcasterName = broadcasterName ?? throw new global::System.ArgumentNullException(nameof(broadcasterName));
            this.ModeratorId = moderatorId ?? throw new global::System.ArgumentNullException(nameof(moderatorId));
            this.ModeratorLogin = moderatorLogin ?? throw new global::System.ArgumentNullException(nameof(moderatorLogin));
            this.ModeratorName = moderatorName ?? throw new global::System.ArgumentNullException(nameof(moderatorName));
            this.UserId = userId ?? throw new global::System.ArgumentNullException(nameof(userId));
            this.UserLogin = userLogin ?? throw new global::System.ArgumentNullException(nameof(userLogin));
            this.UserName = userName ?? throw new global::System.ArgumentNullException(nameof(userName));
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Status = status ?? throw new global::System.ArgumentNullException(nameof(status));
            this.CreatedAt = createdAt;
            this.ResolvedAt = resolvedAt;
            this.ResolutionText = resolutionText ?? throw new global::System.ArgumentNullException(nameof(resolutionText));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResolveUnbanRequestsResponseDataItem" /> class.
        /// </summary>
        public ResolveUnbanRequestsResponseDataItem()
        {
        }
    }
}