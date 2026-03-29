//HintName: G.Models.AnthropicModelSettings.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AnthropicModelSettings
    {
        /// <summary>
        /// The maximum number of tokens the model can generate.<br/>
        /// Default Value: 4096
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_output_tokens")]
        public int? MaxOutputTokens { get; set; }

        /// <summary>
        /// Whether to enable parallel tool calling.<br/>
        /// Default Value: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("parallel_tool_calls")]
        public bool? ParallelToolCalls { get; set; }

        /// <summary>
        /// The type of the provider.<br/>
        /// Default Value: anthropic
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("provider_type")]
        public string? ProviderType { get; set; }

        /// <summary>
        /// The temperature of the model.<br/>
        /// Default Value: 1
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("temperature")]
        public double? Temperature { get; set; }

        /// <summary>
        /// The thinking configuration for the model.<br/>
        /// Default Value: {"type":"enabled","budget_tokens":1024}
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("thinking")]
        public global::G.AnthropicThinking? Thinking { get; set; }

        /// <summary>
        /// The response format for the model.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("response_format")]
        public global::G.ResponseFormatVariant12? ResponseFormat { get; set; }

        /// <summary>
        /// Soft control for how verbose model output should be, used for GPT-5 models.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("verbosity")]
        public global::G.AnthropicModelSettingsVerbosity2? Verbosity { get; set; }

        /// <summary>
        /// Effort level for supported Anthropic models (controls token spending). 'max' is only available on Opus 4.6. Not setting this gives similar performance to 'high'.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("effort")]
        public global::G.AnthropicModelSettingsEffort2? Effort { get; set; }

        /// <summary>
        /// Enable strict mode for tool calling. When true, tool outputs are guaranteed to match JSON schemas.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("strict")]
        public bool? Strict { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnthropicModelSettings" /> class.
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
        /// Default Value: anthropic
        /// </param>
        /// <param name="temperature">
        /// The temperature of the model.<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="thinking">
        /// The thinking configuration for the model.<br/>
        /// Default Value: {"type":"enabled","budget_tokens":1024}
        /// </param>
        /// <param name="responseFormat">
        /// The response format for the model.
        /// </param>
        /// <param name="verbosity">
        /// Soft control for how verbose model output should be, used for GPT-5 models.
        /// </param>
        /// <param name="effort">
        /// Effort level for supported Anthropic models (controls token spending). 'max' is only available on Opus 4.6. Not setting this gives similar performance to 'high'.
        /// </param>
        /// <param name="strict">
        /// Enable strict mode for tool calling. When true, tool outputs are guaranteed to match JSON schemas.<br/>
        /// Default Value: false
        /// </param>
        public AnthropicModelSettings(
            int? maxOutputTokens,
            bool? parallelToolCalls,
            string? providerType,
            double? temperature,
            global::G.AnthropicThinking? thinking,
            global::G.ResponseFormatVariant12? responseFormat,
            global::G.AnthropicModelSettingsVerbosity2? verbosity,
            global::G.AnthropicModelSettingsEffort2? effort,
            bool? strict)
        {
            this.MaxOutputTokens = maxOutputTokens;
            this.ParallelToolCalls = parallelToolCalls;
            this.ProviderType = providerType;
            this.Temperature = temperature;
            this.Thinking = thinking;
            this.ResponseFormat = responseFormat;
            this.Verbosity = verbosity;
            this.Effort = effort;
            this.Strict = strict;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnthropicModelSettings" /> class.
        /// </summary>
        public AnthropicModelSettings()
        {
        }
    }
}