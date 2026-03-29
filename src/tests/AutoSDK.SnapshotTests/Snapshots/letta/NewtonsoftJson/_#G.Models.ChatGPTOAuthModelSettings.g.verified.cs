//HintName: G.Models.ChatGPTOAuthModelSettings.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// ChatGPT OAuth model configuration (uses ChatGPT backend API).
    /// </summary>
    public sealed partial class ChatGPTOAuthModelSettings
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
        /// Default Value: chatgpt_oauth
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
        /// The reasoning configuration for the model.<br/>
        /// Default Value: {"reasoning_effort":"medium"}
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("reasoning")]
        public global::G.ChatGPTOAuthReasoning? Reasoning { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatGPTOAuthModelSettings" /> class.
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
        /// Default Value: chatgpt_oauth
        /// </param>
        /// <param name="temperature">
        /// The temperature of the model.<br/>
        /// Default Value: 0.7F
        /// </param>
        /// <param name="reasoning">
        /// The reasoning configuration for the model.<br/>
        /// Default Value: {"reasoning_effort":"medium"}
        /// </param>
        public ChatGPTOAuthModelSettings(
            int? maxOutputTokens,
            bool? parallelToolCalls,
            string? providerType,
            double? temperature,
            global::G.ChatGPTOAuthReasoning? reasoning)
        {
            this.MaxOutputTokens = maxOutputTokens;
            this.ParallelToolCalls = parallelToolCalls;
            this.ProviderType = providerType;
            this.Temperature = temperature;
            this.Reasoning = reasoning;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatGPTOAuthModelSettings" /> class.
        /// </summary>
        public ChatGPTOAuthModelSettings()
        {
        }
    }
}