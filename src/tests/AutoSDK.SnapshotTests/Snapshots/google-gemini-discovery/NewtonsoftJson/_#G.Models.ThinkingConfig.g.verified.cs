//HintName: G.Models.ThinkingConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Config for thinking features.
    /// </summary>
    public sealed partial class ThinkingConfig
    {
        /// <summary>
        /// Indicates whether to include thoughts in the response. If true, thoughts are returned only when available.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("includeThoughts")]
        public bool? IncludeThoughts { get; set; }

        /// <summary>
        /// The number of thoughts tokens that the model should generate.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("thinkingBudget")]
        public int? ThinkingBudget { get; set; }

        /// <summary>
        /// Optional. Controls the maximum depth of the model's internal reasoning process before it produces a response. If not specified, the default is HIGH. Recommended for Gemini 3 or later models. Use with earlier models results in an error.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("thinkingLevel")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ThinkingConfigThinkingLevelJsonConverter))]
        public global::G.ThinkingConfigThinkingLevel? ThinkingLevel { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ThinkingConfig" /> class.
        /// </summary>
        /// <param name="includeThoughts">
        /// Indicates whether to include thoughts in the response. If true, thoughts are returned only when available.
        /// </param>
        /// <param name="thinkingBudget">
        /// The number of thoughts tokens that the model should generate.
        /// </param>
        /// <param name="thinkingLevel">
        /// Optional. Controls the maximum depth of the model's internal reasoning process before it produces a response. If not specified, the default is HIGH. Recommended for Gemini 3 or later models. Use with earlier models results in an error.
        /// </param>
        public ThinkingConfig(
            bool? includeThoughts,
            int? thinkingBudget,
            global::G.ThinkingConfigThinkingLevel? thinkingLevel)
        {
            this.IncludeThoughts = includeThoughts;
            this.ThinkingBudget = thinkingBudget;
            this.ThinkingLevel = thinkingLevel;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ThinkingConfig" /> class.
        /// </summary>
        public ThinkingConfig()
        {
        }
    }
}