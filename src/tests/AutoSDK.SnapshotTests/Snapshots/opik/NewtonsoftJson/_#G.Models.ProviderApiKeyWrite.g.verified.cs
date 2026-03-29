//HintName: G.Models.ProviderApiKeyWrite.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProviderApiKeyWrite
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("provider", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ProviderApiKeyWriteProvider Provider { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("api_key")]
        public string? ApiKey { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Provider name - required for custom LLM and Bedrock providers to uniquely identify them (e.g., 'ollama', 'vllm', 'Bedrock us-east-1'). Must not be blank for custom and Bedrock providers. Should not be set for standard providers (OpenAI, Anthropic, etc.). This requirement is conditional and validation is enforced programmatically.<br/>
        /// Example: ollama
        /// </summary>
        /// <example>ollama</example>
        [global::Newtonsoft.Json.JsonProperty("provider_name")]
        public string? ProviderName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("headers")]
        public global::System.Collections.Generic.Dictionary<string, string>? Headers { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("configuration")]
        public global::System.Collections.Generic.Dictionary<string, string>? Configuration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("base_url")]
        public string? BaseUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProviderApiKeyWrite" /> class.
        /// </summary>
        /// <param name="provider"></param>
        /// <param name="apiKey"></param>
        /// <param name="name"></param>
        /// <param name="providerName">
        /// Provider name - required for custom LLM and Bedrock providers to uniquely identify them (e.g., 'ollama', 'vllm', 'Bedrock us-east-1'). Must not be blank for custom and Bedrock providers. Should not be set for standard providers (OpenAI, Anthropic, etc.). This requirement is conditional and validation is enforced programmatically.<br/>
        /// Example: ollama
        /// </param>
        /// <param name="headers"></param>
        /// <param name="configuration"></param>
        /// <param name="baseUrl"></param>
        public ProviderApiKeyWrite(
            global::G.ProviderApiKeyWriteProvider provider,
            string? apiKey,
            string? name,
            string? providerName,
            global::System.Collections.Generic.Dictionary<string, string>? headers,
            global::System.Collections.Generic.Dictionary<string, string>? configuration,
            string? baseUrl)
        {
            this.Provider = provider;
            this.ApiKey = apiKey;
            this.Name = name;
            this.ProviderName = providerName;
            this.Headers = headers;
            this.Configuration = configuration;
            this.BaseUrl = baseUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProviderApiKeyWrite" /> class.
        /// </summary>
        public ProviderApiKeyWrite()
        {
        }
    }
}