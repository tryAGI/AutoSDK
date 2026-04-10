//HintName: G.Models.UpdateAuthSecretRequestDtoBearerToken.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateAuthSecretRequestDtoBearerToken
    {
        /// <summary>
        /// The authentication type.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.UpdateAuthSecretRequestDtoBearerTokenTypeJsonConverter))]
        public global::G.UpdateAuthSecretRequestDtoBearerTokenType? Type { get; set; }

        /// <summary>
        /// Custom header name for authentication.<br/>
        /// Example: X-Custom-Auth
        /// </summary>
        /// <example>X-Custom-Auth</example>
        [global::Newtonsoft.Json.JsonProperty("header_name")]
        public string? HeaderName { get; set; }

        /// <summary>
        /// The provider/credential name. If changed, the secret will be replaced.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("provider")]
        public string? Provider { get; set; }

        /// <summary>
        /// The bearer token for authentication.<br/>
        /// Example: eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9...
        /// </summary>
        /// <example>eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9...</example>
        [global::Newtonsoft.Json.JsonProperty("token")]
        public string? Token { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAuthSecretRequestDtoBearerToken" /> class.
        /// </summary>
        /// <param name="type">
        /// The authentication type.
        /// </param>
        /// <param name="headerName">
        /// Custom header name for authentication.<br/>
        /// Example: X-Custom-Auth
        /// </param>
        /// <param name="provider">
        /// The provider/credential name. If changed, the secret will be replaced.
        /// </param>
        /// <param name="token">
        /// The bearer token for authentication.<br/>
        /// Example: eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9...
        /// </param>
        public UpdateAuthSecretRequestDtoBearerToken(
            global::G.UpdateAuthSecretRequestDtoBearerTokenType? type,
            string? headerName,
            string? provider,
            string? token)
        {
            this.Type = type;
            this.HeaderName = headerName;
            this.Provider = provider;
            this.Token = token;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAuthSecretRequestDtoBearerToken" /> class.
        /// </summary>
        public UpdateAuthSecretRequestDtoBearerToken()
        {
        }
    }
}