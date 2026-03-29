//HintName: G.Models.ProviderApiKeyUpdate.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProviderApiKeyUpdate
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_key")]
        public string? ApiKey { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Provider name - can be set to migrate legacy custom LLM or Bedrock providers to the new multi-provider format. Once set, it cannot be changed. Should only be set for custom LLM and Bedrock providers.<br/>
        /// Example: ollama
        /// </summary>
        /// <example>ollama</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider_name")]
        public string? ProviderName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("headers")]
        public global::System.Collections.Generic.Dictionary<string, string>? Headers { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("configuration")]
        public global::System.Collections.Generic.Dictionary<string, string>? Configuration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("base_url")]
        public string? BaseUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProviderApiKeyUpdate" /> class.
        /// </summary>
        /// <param name="apiKey"></param>
        /// <param name="name"></param>
        /// <param name="providerName">
        /// Provider name - can be set to migrate legacy custom LLM or Bedrock providers to the new multi-provider format. Once set, it cannot be changed. Should only be set for custom LLM and Bedrock providers.<br/>
        /// Example: ollama
        /// </param>
        /// <param name="headers"></param>
        /// <param name="configuration"></param>
        /// <param name="baseUrl"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProviderApiKeyUpdate(
            string? apiKey,
            string? name,
            string? providerName,
            global::System.Collections.Generic.Dictionary<string, string>? headers,
            global::System.Collections.Generic.Dictionary<string, string>? configuration,
            string? baseUrl)
        {
            this.ApiKey = apiKey;
            this.Name = name;
            this.ProviderName = providerName;
            this.Headers = headers;
            this.Configuration = configuration;
            this.BaseUrl = baseUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProviderApiKeyUpdate" /> class.
        /// </summary>
        public ProviderApiKeyUpdate()
        {
        }
    }
}