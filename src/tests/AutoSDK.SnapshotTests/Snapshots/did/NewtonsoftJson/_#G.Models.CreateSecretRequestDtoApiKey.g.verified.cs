//HintName: G.Models.CreateSecretRequestDtoApiKey.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateSecretRequestDtoApiKey
    {
        /// <summary>
        /// The authentication type for the secret.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.CreateSecretRequestDtoApiKeyType Type { get; set; }

        /// <summary>
        /// The provider/credential name chosen by the user<br/>
        /// Example: My Production API Key
        /// </summary>
        /// <example>My Production API Key</example>
        [global::Newtonsoft.Json.JsonProperty("provider", Required = global::Newtonsoft.Json.Required.Always)]
        public string Provider { get; set; } = default!;

        /// <summary>
        /// The API key for authentication.<br/>
        /// Example: sk-1234567890abcdef
        /// </summary>
        /// <example>sk-1234567890abcdef</example>
        [global::Newtonsoft.Json.JsonProperty("api_key")]
        public string? ApiKey { get; set; }

        /// <summary>
        /// Custom header name for the API key (e.g., "Authorization", "X-API-Key").<br/>
        /// Example: X-API-Key
        /// </summary>
        /// <example>X-API-Key</example>
        [global::Newtonsoft.Json.JsonProperty("header_name")]
        public string? HeaderName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSecretRequestDtoApiKey" /> class.
        /// </summary>
        /// <param name="provider">
        /// The provider/credential name chosen by the user<br/>
        /// Example: My Production API Key
        /// </param>
        /// <param name="type">
        /// The authentication type for the secret.
        /// </param>
        /// <param name="apiKey">
        /// The API key for authentication.<br/>
        /// Example: sk-1234567890abcdef
        /// </param>
        /// <param name="headerName">
        /// Custom header name for the API key (e.g., "Authorization", "X-API-Key").<br/>
        /// Example: X-API-Key
        /// </param>
        public CreateSecretRequestDtoApiKey(
            string provider,
            global::G.CreateSecretRequestDtoApiKeyType type,
            string? apiKey,
            string? headerName)
        {
            this.Type = type;
            this.Provider = provider ?? throw new global::System.ArgumentNullException(nameof(provider));
            this.ApiKey = apiKey;
            this.HeaderName = headerName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSecretRequestDtoApiKey" /> class.
        /// </summary>
        public CreateSecretRequestDtoApiKey()
        {
        }
    }
}