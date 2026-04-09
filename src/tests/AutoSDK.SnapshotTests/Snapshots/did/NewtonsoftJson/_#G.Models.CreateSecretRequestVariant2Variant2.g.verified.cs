//HintName: G.Models.CreateSecretRequestVariant2Variant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateSecretRequestVariant2Variant2
    {
        /// <summary>
        /// The API key for OpenAI/Azure OpenAI authentication.<br/>
        /// Example: sk-1234567890abcdef
        /// </summary>
        /// <example>sk-1234567890abcdef</example>
        [global::Newtonsoft.Json.JsonProperty("api_key")]
        public string? ApiKey { get; set; }

        /// <summary>
        /// The OpenAI model to use<br/>
        /// Example: gpt-4
        /// </summary>
        /// <example>gpt-4</example>
        [global::Newtonsoft.Json.JsonProperty("model", Required = global::Newtonsoft.Json.Required.Always)]
        public string Model { get; set; } = default!;

        /// <summary>
        /// The OpenAI API endpoint URL<br/>
        /// Example: https://api.openai.com/v1
        /// </summary>
        /// <example>https://api.openai.com/v1</example>
        [global::Newtonsoft.Json.JsonProperty("endpoint", Required = global::Newtonsoft.Json.Required.Always)]
        public string Endpoint { get; set; } = default!;

        /// <summary>
        /// Whether to use streaming for LLM responses<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::Newtonsoft.Json.JsonProperty("isStreaming", Required = global::Newtonsoft.Json.Required.Always)]
        public bool IsStreaming { get; set; } = default!;

        /// <summary>
        /// Maximum number of messages to include in the conversation<br/>
        /// Example: 100
        /// </summary>
        /// <example>100</example>
        [global::Newtonsoft.Json.JsonProperty("maxMessages")]
        public double? MaxMessages { get; set; }

        /// <summary>
        /// The provider type for Azure OpenAI.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("provider")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.CreateSecretRequestVariant2Variant2ProviderJsonConverter))]
        public global::G.CreateSecretRequestVariant2Variant2Provider Provider { get; set; }

        /// <summary>
        /// The version of the Azure OpenAI API to use<br/>
        /// Example: 2023-05-15
        /// </summary>
        /// <example>2023-05-15</example>
        [global::Newtonsoft.Json.JsonProperty("version")]
        public string? Version { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSecretRequestVariant2Variant2" /> class.
        /// </summary>
        /// <param name="model">
        /// The OpenAI model to use<br/>
        /// Example: gpt-4
        /// </param>
        /// <param name="endpoint">
        /// The OpenAI API endpoint URL<br/>
        /// Example: https://api.openai.com/v1
        /// </param>
        /// <param name="isStreaming">
        /// Whether to use streaming for LLM responses<br/>
        /// Example: true
        /// </param>
        /// <param name="apiKey">
        /// The API key for OpenAI/Azure OpenAI authentication.<br/>
        /// Example: sk-1234567890abcdef
        /// </param>
        /// <param name="maxMessages">
        /// Maximum number of messages to include in the conversation<br/>
        /// Example: 100
        /// </param>
        /// <param name="provider">
        /// The provider type for Azure OpenAI.
        /// </param>
        /// <param name="version">
        /// The version of the Azure OpenAI API to use<br/>
        /// Example: 2023-05-15
        /// </param>
        public CreateSecretRequestVariant2Variant2(
            string model,
            string endpoint,
            bool isStreaming,
            string? apiKey,
            double? maxMessages,
            global::G.CreateSecretRequestVariant2Variant2Provider provider,
            string? version)
        {
            this.ApiKey = apiKey;
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Endpoint = endpoint ?? throw new global::System.ArgumentNullException(nameof(endpoint));
            this.IsStreaming = isStreaming;
            this.MaxMessages = maxMessages;
            this.Provider = provider;
            this.Version = version;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSecretRequestVariant2Variant2" /> class.
        /// </summary>
        public CreateSecretRequestVariant2Variant2()
        {
        }
    }
}