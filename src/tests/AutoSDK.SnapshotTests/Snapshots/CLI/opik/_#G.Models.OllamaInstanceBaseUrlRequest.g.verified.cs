//HintName: G.Models.OllamaInstanceBaseUrlRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Request with Ollama instance base URL for connection testing or model discovery.
    /// </summary>
    public sealed partial class OllamaInstanceBaseUrlRequest
    {
        /// <summary>
        /// Base URL of the Ollama instance. May include /v1 suffix which will be automatically removed for connection testing. For inference, use the URL with /v1 suffix for OpenAI-compatible endpoints.<br/>
        /// Example: http://localhost:11434/v1
        /// </summary>
        /// <example>http://localhost:11434/v1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("base_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BaseUrl { get; set; }

        /// <summary>
        /// Optional API key for authenticated Ollama instances. If provided, will be sent as Bearer token in Authorization header.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_key")]
        public string? ApiKey { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OllamaInstanceBaseUrlRequest" /> class.
        /// </summary>
        /// <param name="baseUrl">
        /// Base URL of the Ollama instance. May include /v1 suffix which will be automatically removed for connection testing. For inference, use the URL with /v1 suffix for OpenAI-compatible endpoints.<br/>
        /// Example: http://localhost:11434/v1
        /// </param>
        /// <param name="apiKey">
        /// Optional API key for authenticated Ollama instances. If provided, will be sent as Bearer token in Authorization header.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OllamaInstanceBaseUrlRequest(
            string baseUrl,
            string? apiKey)
        {
            this.BaseUrl = baseUrl ?? throw new global::System.ArgumentNullException(nameof(baseUrl));
            this.ApiKey = apiKey;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OllamaInstanceBaseUrlRequest" /> class.
        /// </summary>
        public OllamaInstanceBaseUrlRequest()
        {
        }
    }
}