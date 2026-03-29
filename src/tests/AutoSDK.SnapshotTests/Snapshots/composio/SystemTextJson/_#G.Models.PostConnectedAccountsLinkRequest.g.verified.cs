//HintName: G.Models.PostConnectedAccountsLinkRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PostConnectedAccountsLinkRequest
    {
        /// <summary>
        /// The auth config id to create a link for
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auth_config_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AuthConfigId { get; set; }

        /// <summary>
        /// The user id to create a link for
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserId { get; set; }

        /// <summary>
        /// The callback url to create a link for
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("callback_url")]
        public string? CallbackUrl { get; set; }

        /// <summary>
        /// Connection data for the linked account (provider-specific key-value pairs)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("connection_data")]
        public object? ConnectionData { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostConnectedAccountsLinkRequest" /> class.
        /// </summary>
        /// <param name="authConfigId">
        /// The auth config id to create a link for
        /// </param>
        /// <param name="userId">
        /// The user id to create a link for
        /// </param>
        /// <param name="callbackUrl">
        /// The callback url to create a link for
        /// </param>
        /// <param name="connectionData">
        /// Connection data for the linked account (provider-specific key-value pairs)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PostConnectedAccountsLinkRequest(
            string authConfigId,
            string userId,
            string? callbackUrl,
            object? connectionData)
        {
            this.AuthConfigId = authConfigId ?? throw new global::System.ArgumentNullException(nameof(authConfigId));
            this.UserId = userId ?? throw new global::System.ArgumentNullException(nameof(userId));
            this.CallbackUrl = callbackUrl;
            this.ConnectionData = connectionData;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostConnectedAccountsLinkRequest" /> class.
        /// </summary>
        public PostConnectedAccountsLinkRequest()
        {
        }
    }
}