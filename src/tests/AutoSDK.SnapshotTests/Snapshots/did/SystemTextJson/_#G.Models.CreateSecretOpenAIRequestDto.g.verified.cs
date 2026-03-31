//HintName: G.Models.CreateSecretOpenAIRequestDto.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateSecretOpenAIRequestDto
    {
        /// <summary>
        /// The API key for OpenAI/Azure OpenAI authentication.<br/>
        /// Example: sk-1234567890abcdef
        /// </summary>
        /// <example>sk-1234567890abcdef</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_key")]
        public string? ApiKey { get; set; }

        /// <summary>
        /// The OpenAI model to use<br/>
        /// Example: gpt-4
        /// </summary>
        /// <example>gpt-4</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// The OpenAI API endpoint URL<br/>
        /// Example: https://api.openai.com/v1
        /// </summary>
        /// <example>https://api.openai.com/v1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("endpoint")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Endpoint { get; set; }

        /// <summary>
        /// Whether to use streaming for LLM responses<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("isStreaming")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsStreaming { get; set; }

        /// <summary>
        /// Maximum number of messages to include in the conversation<br/>
        /// Example: 100
        /// </summary>
        /// <example>100</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxMessages")]
        public double? MaxMessages { get; set; }

        /// <summary>
        /// The provider type for OpenAI.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CreateSecretOpenAIRequestDtoProviderJsonConverter))]
        public global::G.CreateSecretOpenAIRequestDtoProvider Provider { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSecretOpenAIRequestDto" /> class.
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
        /// The provider type for OpenAI.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateSecretOpenAIRequestDto(
            string model,
            string endpoint,
            bool isStreaming,
            string? apiKey,
            double? maxMessages,
            global::G.CreateSecretOpenAIRequestDtoProvider provider)
        {
            this.ApiKey = apiKey;
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Endpoint = endpoint ?? throw new global::System.ArgumentNullException(nameof(endpoint));
            this.IsStreaming = isStreaming;
            this.MaxMessages = maxMessages;
            this.Provider = provider;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSecretOpenAIRequestDto" /> class.
        /// </summary>
        public CreateSecretOpenAIRequestDto()
        {
        }
    }
}