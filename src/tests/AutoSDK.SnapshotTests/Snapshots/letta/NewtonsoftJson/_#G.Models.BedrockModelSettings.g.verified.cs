//HintName: G.Models.BedrockModelSettings.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// AWS Bedrock model configuration.
    /// </summary>
    public sealed partial class BedrockModelSettings
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
        /// Default Value: bedrock
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
        /// The response format for the model.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("response_format")]
        public global::G.ResponseFormatVariant14? ResponseFormat { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BedrockModelSettings" /> class.
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
        /// Default Value: bedrock
        /// </param>
        /// <param name="temperature">
        /// The temperature of the model.<br/>
        /// Default Value: 0.7F
        /// </param>
        /// <param name="responseFormat">
        /// The response format for the model.
        /// </param>
        public BedrockModelSettings(
            int? maxOutputTokens,
            bool? parallelToolCalls,
            string? providerType,
            double? temperature,
            global::G.ResponseFormatVariant14? responseFormat)
        {
            this.MaxOutputTokens = maxOutputTokens;
            this.ParallelToolCalls = parallelToolCalls;
            this.ProviderType = providerType;
            this.Temperature = temperature;
            this.ResponseFormat = responseFormat;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BedrockModelSettings" /> class.
        /// </summary>
        public BedrockModelSettings()
        {
        }
    }
}