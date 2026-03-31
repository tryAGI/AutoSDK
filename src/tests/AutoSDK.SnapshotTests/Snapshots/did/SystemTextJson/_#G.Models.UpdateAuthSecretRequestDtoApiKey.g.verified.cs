//HintName: G.Models.UpdateAuthSecretRequestDtoApiKey.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateAuthSecretRequestDtoApiKey
    {
        /// <summary>
        /// The authentication type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.UpdateAuthSecretRequestDtoApiKeyTypeJsonConverter))]
        public global::G.UpdateAuthSecretRequestDtoApiKeyType? Type { get; set; }

        /// <summary>
        /// Custom header name for the API key.<br/>
        /// Example: X-API-Key
        /// </summary>
        /// <example>X-API-Key</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("header_name")]
        public string? HeaderName { get; set; }

        /// <summary>
        /// The provider/credential name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        public string? Provider { get; set; }

        /// <summary>
        /// The API key for authentication.<br/>
        /// Example: sk-1234567890abcdef
        /// </summary>
        /// <example>sk-1234567890abcdef</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_key")]
        public string? ApiKey { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAuthSecretRequestDtoApiKey" /> class.
        /// </summary>
        /// <param name="type">
        /// The authentication type.
        /// </param>
        /// <param name="headerName">
        /// Custom header name for the API key.<br/>
        /// Example: X-API-Key
        /// </param>
        /// <param name="provider">
        /// The provider/credential name.
        /// </param>
        /// <param name="apiKey">
        /// The API key for authentication.<br/>
        /// Example: sk-1234567890abcdef
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateAuthSecretRequestDtoApiKey(
            global::G.UpdateAuthSecretRequestDtoApiKeyType? type,
            string? headerName,
            string? provider,
            string? apiKey)
        {
            this.Type = type;
            this.HeaderName = headerName;
            this.Provider = provider;
            this.ApiKey = apiKey;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAuthSecretRequestDtoApiKey" /> class.
        /// </summary>
        public UpdateAuthSecretRequestDtoApiKey()
        {
        }
    }
}