﻿//HintName: G.Models.ResolveUnbanRequestsResponseDataItem.g.cs

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
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// User ID of broadcaster whose channel is receiving the unban request.
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
        /// User ID of moderator who approved/denied the request.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("moderator_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ModeratorId { get; set; } = default!;

        /// <summary>
        /// The moderator’s login name.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("moderator_login", Required = global::Newtonsoft.Json.Required.Always)]
        public string ModeratorLogin { get; set; } = default!;

        /// <summary>
        /// The moderator’s display name.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("moderator_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string ModeratorName { get; set; } = default!;

        /// <summary>
        /// User ID of the requestor who is asking for an unban.
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
        /// Text of the request from the requesting user.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text", Required = global::Newtonsoft.Json.Required.Always)]
        public string Text { get; set; } = default!;

        /// <summary>
        /// Status of the request. One of:   <br/>
        ///   <br/>
        /// * approved<br/>
        /// * denied
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        public string Status { get; set; } = default!;

        /// <summary>
        /// Timestamp of when the unban request was created.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// Timestamp of when moderator/broadcaster approved or denied the request.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("resolved_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime ResolvedAt { get; set; } = default!;

        /// <summary>
        /// Text input by the resolver (moderator) of the unban request.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("resolution_text", Required = global::Newtonsoft.Json.Required.Always)]
        public string ResolutionText { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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