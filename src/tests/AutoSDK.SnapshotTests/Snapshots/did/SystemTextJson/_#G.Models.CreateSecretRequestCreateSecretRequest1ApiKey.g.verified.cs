//HintName: G.Models.CreateSecretRequestCreateSecretRequest1ApiKey.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateSecretRequestCreateSecretRequest1ApiKey
    {
        /// <summary>
        /// The authentication type for the secret.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CreateSecretRequestCreateSecretRequest1ApiKeyTypeJsonConverter))]
        public global::G.CreateSecretRequestCreateSecretRequest1ApiKeyType Type { get; set; }

        /// <summary>
        /// The provider/credential name chosen by the user<br/>
        /// Example: My Production API Key
        /// </summary>
        /// <example>My Production API Key</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Provider { get; set; }

        /// <summary>
        /// The API key for authentication.<br/>
        /// Example: sk-1234567890abcdef
        /// </summary>
        /// <example>sk-1234567890abcdef</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_key")]
        public string? ApiKey { get; set; }

        /// <summary>
        /// Custom header name for the API key (e.g., "Authorization", "X-API-Key").<br/>
        /// Example: X-API-Key
        /// </summary>
        /// <example>X-API-Key</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("header_name")]
        public string? HeaderName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSecretRequestCreateSecretRequest1ApiKey" /> class.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateSecretRequestCreateSecretRequest1ApiKey(
            string provider,
            global::G.CreateSecretRequestCreateSecretRequest1ApiKeyType type,
            string? apiKey,
            string? headerName)
        {
            this.Type = type;
            this.Provider = provider ?? throw new global::System.ArgumentNullException(nameof(provider));
            this.ApiKey = apiKey;
            this.HeaderName = headerName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSecretRequestCreateSecretRequest1ApiKey" /> class.
        /// </summary>
        public CreateSecretRequestCreateSecretRequest1ApiKey()
        {
        }
    }
}