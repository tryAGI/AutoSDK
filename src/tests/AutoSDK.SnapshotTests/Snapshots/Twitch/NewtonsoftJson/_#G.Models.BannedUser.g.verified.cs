//HintName: G.Models.BannedUser.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BannedUser
    {
        /// <summary>
        /// The ID of the banned user.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string UserId { get; set; } = default!;

        /// <summary>
        /// The banned user’s login name.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user_login", Required = global::Newtonsoft.Json.Required.Always)]
        public string UserLogin { get; set; } = default!;

        /// <summary>
        /// The banned user’s display name.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string UserName { get; set; } = default!;

        /// <summary>
        /// The UTC date and time (in RFC3339 format) of when the timeout expires, or an empty string if the user is permanently banned.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("expires_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime ExpiresAt { get; set; } = default!;

        /// <summary>
        /// The UTC date and time (in RFC3339 format) of when the user was banned.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// The reason the user was banned or put in a timeout if the moderator provided one.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("reason", Required = global::Newtonsoft.Json.Required.Always)]
        public string Reason { get; set; } = default!;

        /// <summary>
        /// The ID of the moderator that banned the user or put them in a timeout.
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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BannedUser" /> class.
        /// </summary>
        /// <param name="userId">
        /// The ID of the banned user.
        /// </param>
        /// <param name="userLogin">
        /// The banned user’s login name.
        /// </param>
        /// <param name="userName">
        /// The banned user’s display name.
        /// </param>
        /// <param name="expiresAt">
        /// The UTC date and time (in RFC3339 format) of when the timeout expires, or an empty string if the user is permanently banned.
        /// </param>
        /// <param name="createdAt">
        /// The UTC date and time (in RFC3339 format) of when the user was banned.
        /// </param>
        /// <param name="reason">
        /// The reason the user was banned or put in a timeout if the moderator provided one.
        /// </param>
        /// <param name="moderatorId">
        /// The ID of the moderator that banned the user or put them in a timeout.
        /// </param>
        /// <param name="moderatorLogin">
        /// The moderator’s login name.
        /// </param>
        /// <param name="moderatorName">
        /// The moderator’s display name.
        /// </param>
        public BannedUser(
            string userId,
            string userLogin,
            string userName,
            global::System.DateTime expiresAt,
            global::System.DateTime createdAt,
            string reason,
            string moderatorId,
            string moderatorLogin,
            string moderatorName)
        {
            this.UserId = userId ?? throw new global::System.ArgumentNullException(nameof(userId));
            this.UserLogin = userLogin ?? throw new global::System.ArgumentNullException(nameof(userLogin));
            this.UserName = userName ?? throw new global::System.ArgumentNullException(nameof(userName));
            this.ExpiresAt = expiresAt;
            this.CreatedAt = createdAt;
            this.Reason = reason ?? throw new global::System.ArgumentNullException(nameof(reason));
            this.ModeratorId = moderatorId ?? throw new global::System.ArgumentNullException(nameof(moderatorId));
            this.ModeratorLogin = moderatorLogin ?? throw new global::System.ArgumentNullException(nameof(moderatorLogin));
            this.ModeratorName = moderatorName ?? throw new global::System.ArgumentNullException(nameof(moderatorName));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BannedUser" /> class.
        /// </summary>
        public BannedUser()
        {
        }
    }
}