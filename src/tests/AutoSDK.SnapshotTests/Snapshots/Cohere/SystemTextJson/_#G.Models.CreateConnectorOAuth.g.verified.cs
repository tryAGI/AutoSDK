//HintName: G.Models.CreateConnectorOAuth.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateConnectorOAuth
    {
        /// <summary>
        /// The OAuth 2.0 client ID. This fields is encrypted at rest.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("client_id")]
        public string? ClientId { get; set; }

        /// <summary>
        /// The OAuth 2.0 client Secret. This field is encrypted at rest and never returned in a response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("client_secret")]
        public string? ClientSecret { get; set; }

        /// <summary>
        /// The OAuth 2.0 /authorize endpoint to use when users authorize the connector.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authorize_url")]
        public string? AuthorizeUrl { get; set; }

        /// <summary>
        /// The OAuth 2.0 /token endpoint to use when users authorize the connector.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token_url")]
        public string? TokenUrl { get; set; }

        /// <summary>
        /// The OAuth scopes to request when users authorize the connector.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scope")]
        public string? Scope { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateConnectorOAuth" /> class.
        /// </summary>
        /// <param name="clientId">
        /// The OAuth 2.0 client ID. This fields is encrypted at rest.
        /// </param>
        /// <param name="clientSecret">
        /// The OAuth 2.0 client Secret. This field is encrypted at rest and never returned in a response.
        /// </param>
        /// <param name="authorizeUrl">
        /// The OAuth 2.0 /authorize endpoint to use when users authorize the connector.
        /// </param>
        /// <param name="tokenUrl">
        /// The OAuth 2.0 /token endpoint to use when users authorize the connector.
        /// </param>
        /// <param name="scope">
        /// The OAuth scopes to request when users authorize the connector.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public CreateConnectorOAuth(
            string? clientId,
            string? clientSecret,
            string? authorizeUrl,
            string? tokenUrl,
            string? scope)
        {
            this.ClientId = clientId;
            this.ClientSecret = clientSecret;
            this.AuthorizeUrl = authorizeUrl;
            this.TokenUrl = tokenUrl;
            this.Scope = scope;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateConnectorOAuth" /> class.
        /// </summary>
        public CreateConnectorOAuth()
        {
        }
    }
}