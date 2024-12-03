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
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserId { get; set; }

        /// <summary>
        /// The banned user’s login name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_login")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserLogin { get; set; }

        /// <summary>
        /// The banned user’s display name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserName { get; set; }

        /// <summary>
        /// The UTC date and time (in RFC3339 format) of when the timeout expires, or an empty string if the user is permanently banned.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime ExpiresAt { get; set; }

        /// <summary>
        /// The UTC date and time (in RFC3339 format) of when the user was banned.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// The reason the user was banned or put in a timeout if the moderator provided one.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reason")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Reason { get; set; }

        /// <summary>
        /// The ID of the moderator that banned the user or put them in a timeout.
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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
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