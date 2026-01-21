//HintName: G.Models.ConnectorOAuth.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ConnectorOAuth
    {
        /// <summary>
        /// The OAuth 2.0 client ID. This field is encrypted at rest.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("client_id")]
        public string? ClientId { get; set; }

        /// <summary>
        /// The OAuth 2.0 client Secret. This field is encrypted at rest and never returned in a response.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("client_secret")]
        public string? ClientSecret { get; set; }

        /// <summary>
        /// The OAuth 2.0 /authorize endpoint to use when users authorize the connector.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("authorize_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string AuthorizeUrl { get; set; } = default!;

        /// <summary>
        /// The OAuth 2.0 /token endpoint to use when users authorize the connector.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("token_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string TokenUrl { get; set; } = default!;

        /// <summary>
        /// The OAuth scopes to request when users authorize the connector.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("scope")]
        public string? Scope { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectorOAuth" /> class.
        /// </summary>
        /// <param name="clientId">
        /// The OAuth 2.0 client ID. This field is encrypted at rest.
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
        public ConnectorOAuth(
            string authorizeUrl,
            string tokenUrl,
            string? clientId,
            string? clientSecret,
            string? scope)
        {
            this.AuthorizeUrl = authorizeUrl ?? throw new global::System.ArgumentNullException(nameof(authorizeUrl));
            this.TokenUrl = tokenUrl ?? throw new global::System.ArgumentNullException(nameof(tokenUrl));
            this.ClientId = clientId;
            this.ClientSecret = clientSecret;
            this.Scope = scope;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectorOAuth" /> class.
        /// </summary>
        public ConnectorOAuth()
        {
        }
    }
}