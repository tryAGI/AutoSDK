//HintName: G.Models.KPIUserInfo.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Serializer for user information (compact format).
    /// </summary>
    public sealed partial class KPIUserInfo
    {
        /// <summary>
        /// User email
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_email")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserEmail { get; set; }

        /// <summary>
        /// User ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int UserId { get; set; }

        /// <summary>
        /// Username
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("username")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Username { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="KPIUserInfo" /> class.
        /// </summary>
        /// <param name="userEmail">
        /// User email
        /// </param>
        /// <param name="userId">
        /// User ID
        /// </param>
        /// <param name="username">
        /// Username
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public KPIUserInfo(
            string userEmail,
            int userId,
            string username)
        {
            this.UserEmail = userEmail ?? throw new global::System.ArgumentNullException(nameof(userEmail));
            this.UserId = userId;
            this.Username = username ?? throw new global::System.ArgumentNullException(nameof(username));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KPIUserInfo" /> class.
        /// </summary>
        public KPIUserInfo()
        {
        }
    }
}