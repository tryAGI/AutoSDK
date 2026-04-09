//HintName: G.Models.ProviderApiKeyPublic.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProviderApiKeyPublic
    {
        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("provider", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ProviderApiKeyPublicProviderJsonConverter))]
        public global::G.ProviderApiKeyPublicProvider Provider { get; set; } = default!;

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
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_by")]
        public string? CreatedBy { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("last_updated_at")]
        public global::System.DateTime? LastUpdatedAt { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("last_updated_by")]
        public string? LastUpdatedBy { get; set; }

        /// <summary>
        /// If true, this provider is system-managed and cannot be edited or deleted<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("read_only")]
        public bool? ReadOnly { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProviderApiKeyPublic" /> class.
        /// </summary>
        /// <param name="provider"></param>
        /// <param name="id">
        /// Included only in responses
        /// </param>
        /// <param name="apiKey"></param>
        /// <param name="name"></param>
        /// <param name="providerName">
        /// Provider name - required for custom LLM and Bedrock providers to uniquely identify them (e.g., 'ollama', 'vllm', 'Bedrock us-east-1'). Must not be blank for custom and Bedrock providers. Should not be set for standard providers (OpenAI, Anthropic, etc.). This requirement is conditional and validation is enforced programmatically.<br/>
        /// Example: ollama
        /// </param>
        /// <param name="headers"></param>
        /// <param name="configuration"></param>
        /// <param name="baseUrl"></param>
        /// <param name="createdAt">
        /// Included only in responses
        /// </param>
        /// <param name="createdBy">
        /// Included only in responses
        /// </param>
        /// <param name="lastUpdatedAt">
        /// Included only in responses
        /// </param>
        /// <param name="lastUpdatedBy">
        /// Included only in responses
        /// </param>
        /// <param name="readOnly">
        /// If true, this provider is system-managed and cannot be edited or deleted<br/>
        /// Included only in responses
        /// </param>
        public ProviderApiKeyPublic(
            global::G.ProviderApiKeyPublicProvider provider,
            global::System.Guid? id,
            string? apiKey,
            string? name,
            string? providerName,
            global::System.Collections.Generic.Dictionary<string, string>? headers,
            global::System.Collections.Generic.Dictionary<string, string>? configuration,
            string? baseUrl,
            global::System.DateTime? createdAt,
            string? createdBy,
            global::System.DateTime? lastUpdatedAt,
            string? lastUpdatedBy,
            bool? readOnly)
        {
            this.Id = id;
            this.Provider = provider;
            this.ApiKey = apiKey;
            this.Name = name;
            this.ProviderName = providerName;
            this.Headers = headers;
            this.Configuration = configuration;
            this.BaseUrl = baseUrl;
            this.CreatedAt = createdAt;
            this.CreatedBy = createdBy;
            this.LastUpdatedAt = lastUpdatedAt;
            this.LastUpdatedBy = lastUpdatedBy;
            this.ReadOnly = readOnly;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProviderApiKeyPublic" /> class.
        /// </summary>
        public ProviderApiKeyPublic()
        {
        }
    }
}