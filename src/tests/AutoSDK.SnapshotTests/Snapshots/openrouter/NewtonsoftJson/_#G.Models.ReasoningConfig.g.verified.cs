//HintName: G.Models.ReasoningConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Configuration for reasoning mode in the response
    /// </summary>
    public sealed partial class ReasoningConfig
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("effort")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ReasoningEffortEnumJsonConverter))]
        public global::G.ReasoningEffortEnum? Effort { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("summary")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ReasoningSummaryVerbosityEnumJsonConverter))]
        public global::G.ReasoningSummaryVerbosityEnum? Summary { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_tokens")]
        public double? MaxTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReasoningConfig" /> class.
        /// </summary>
        /// <param name="effort"></param>
        /// <param name="summary"></param>
        /// <param name="maxTokens"></param>
        /// <param name="enabled"></param>
        public ReasoningConfig(
            global::G.ReasoningEffortEnum? effort,
            global::G.ReasoningSummaryVerbosityEnum? summary,
            double? maxTokens,
            bool? enabled)
        {
            this.Effort = effort;
            this.Summary = summary;
            this.MaxTokens = maxTokens;
            this.Enabled = enabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReasoningConfig" /> class.
        /// </summary>
        public ReasoningConfig()
        {
        }
    }
}