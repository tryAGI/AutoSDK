//HintName: G.Models.GoogleAIModelSettings.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GoogleAIModelSettings
    {
        /// <summary>
        /// The maximum number of tokens the model can generate.<br/>
        /// Default Value: 65536
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
        /// Default Value: google_ai
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("provider_type")]
        public string? ProviderType { get; set; }

        /// <summary>
        /// The temperature of the model.<br/>
        /// Default Value: 0.7F
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("temperature")]
        public double? Temperature { get; set; }

        /// <summary>
        /// The thinking configuration for the model.<br/>
        /// Default Value: {"include_thoughts":true,"thinking_budget":1024}
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("thinking_config")]
        public global::G.GeminiThinkingConfig? ThinkingConfig { get; set; }

        /// <summary>
        /// The response schema for the model.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("response_schema")]
        public global::G.ResponseSchemaVariant1? ResponseSchema { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GoogleAIModelSettings" /> class.
        /// </summary>
        /// <param name="maxOutputTokens">
        /// The maximum number of tokens the model can generate.<br/>
        /// Default Value: 65536
        /// </param>
        /// <param name="parallelToolCalls">
        /// Whether to enable parallel tool calling.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="providerType">
        /// The type of the provider.<br/>
        /// Default Value: google_ai
        /// </param>
        /// <param name="temperature">
        /// The temperature of the model.<br/>
        /// Default Value: 0.7F
        /// </param>
        /// <param name="thinkingConfig">
        /// The thinking configuration for the model.<br/>
        /// Default Value: {"include_thoughts":true,"thinking_budget":1024}
        /// </param>
        /// <param name="responseSchema">
        /// The response schema for the model.
        /// </param>
        public GoogleAIModelSettings(
            int? maxOutputTokens,
            bool? parallelToolCalls,
            string? providerType,
            double? temperature,
            global::G.GeminiThinkingConfig? thinkingConfig,
            global::G.ResponseSchemaVariant1? responseSchema)
        {
            this.MaxOutputTokens = maxOutputTokens;
            this.ParallelToolCalls = parallelToolCalls;
            this.ProviderType = providerType;
            this.Temperature = temperature;
            this.ThinkingConfig = thinkingConfig;
            this.ResponseSchema = responseSchema;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GoogleAIModelSettings" /> class.
        /// </summary>
        public GoogleAIModelSettings()
        {
        }
    }
}