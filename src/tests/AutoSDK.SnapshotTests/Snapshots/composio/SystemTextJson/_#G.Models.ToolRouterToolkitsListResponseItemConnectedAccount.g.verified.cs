//HintName: G.Models.ToolRouterToolkitsListResponseItemConnectedAccount.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Connected account if available
    /// </summary>
    public sealed partial class ToolRouterToolkitsListResponseItemConnectedAccount
    {
        /// <summary>
        /// Connected account identifier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// User identifier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserId { get; set; }

        /// <summary>
        /// Connection status
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Status { get; set; }

        /// <summary>
        /// Creation timestamp
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Auth config details
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auth_config")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ToolRouterToolkitsListResponseItemConnectedAccountAuthConfig AuthConfig { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolRouterToolkitsListResponseItemConnectedAccount" /> class.
        /// </summary>
        /// <param name="id">
        /// Connected account identifier
        /// </param>
        /// <param name="userId">
        /// User identifier
        /// </param>
        /// <param name="status">
        /// Connection status
        /// </param>
        /// <param name="createdAt">
        /// Creation timestamp
        /// </param>
        /// <param name="authConfig">
        /// Auth config details
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolRouterToolkitsListResponseItemConnectedAccount(
            string id,
            string userId,
            string status,
            global::System.DateTime createdAt,
            global::G.ToolRouterToolkitsListResponseItemConnectedAccountAuthConfig authConfig)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.UserId = userId ?? throw new global::System.ArgumentNullException(nameof(userId));
            this.Status = status ?? throw new global::System.ArgumentNullException(nameof(status));
            this.CreatedAt = createdAt;
            this.AuthConfig = authConfig ?? throw new global::System.ArgumentNullException(nameof(authConfig));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolRouterToolkitsListResponseItemConnectedAccount" /> class.
        /// </summary>
        public ToolRouterToolkitsListResponseItemConnectedAccount()
        {
        }
    }
}