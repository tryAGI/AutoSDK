//HintName: G.Models.OpenAIModelSettings.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OpenAIModelSettings
    {
        /// <summary>
        /// The maximum number of tokens the model can generate.<br/>
        /// Default Value: 4096
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_output_tokens")]
        public int? MaxOutputTokens { get; set; }

        /// <summary>
        /// Whether to enable parallel tool calling.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parallel_tool_calls")]
        public bool? ParallelToolCalls { get; set; }

        /// <summary>
        /// The type of the provider.<br/>
        /// Default Value: openai
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider_type")]
        public string? ProviderType { get; set; }

        /// <summary>
        /// The temperature of the model.<br/>
        /// Default Value: 0.7F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        public double? Temperature { get; set; }

        /// <summary>
        /// The reasoning configuration for the model.<br/>
        /// Default Value: {"reasoning_effort":"high"}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reasoning")]
        public global::G.OpenAIReasoning? Reasoning { get; set; }

        /// <summary>
        /// The response format for the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_format")]
        public global::G.ResponseFormatVariant111? ResponseFormat { get; set; }

        /// <summary>
        /// Enable strict mode for tool calling. When true, tool outputs are guaranteed to match JSON schemas.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("strict")]
        public bool? Strict { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAIModelSettings" /> class.
        /// </summary>
        /// <param name="maxOutputTokens">
        /// The maximum number of tokens the model can generate.<br/>
        /// Default Value: 4096
        /// </param>
        /// <param name="parallelToolCalls">
        /// Whether to enable parallel tool calling.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="providerType">
        /// The type of the provider.<br/>
        /// Default Value: openai
        /// </param>
        /// <param name="temperature">
        /// The temperature of the model.<br/>
        /// Default Value: 0.7F
        /// </param>
        /// <param name="reasoning">
        /// The reasoning configuration for the model.<br/>
        /// Default Value: {"reasoning_effort":"high"}
        /// </param>
        /// <param name="responseFormat">
        /// The response format for the model.
        /// </param>
        /// <param name="strict">
        /// Enable strict mode for tool calling. When true, tool outputs are guaranteed to match JSON schemas.<br/>
        /// Default Value: true
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OpenAIModelSettings(
            int? maxOutputTokens,
            bool? parallelToolCalls,
            string? providerType,
            double? temperature,
            global::G.OpenAIReasoning? reasoning,
            global::G.ResponseFormatVariant111? responseFormat,
            bool? strict)
        {
            this.MaxOutputTokens = maxOutputTokens;
            this.ParallelToolCalls = parallelToolCalls;
            this.ProviderType = providerType;
            this.Temperature = temperature;
            this.Reasoning = reasoning;
            this.ResponseFormat = responseFormat;
            this.Strict = strict;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAIModelSettings" /> class.
        /// </summary>
        public OpenAIModelSettings()
        {
        }
    }
}