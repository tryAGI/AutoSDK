//HintName: G.Models.GeminiThinkingConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GeminiThinkingConfig
    {
        /// <summary>
        /// Whether to include thoughts in the model's response.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include_thoughts")]
        public bool? IncludeThoughts { get; set; }

        /// <summary>
        /// The thinking budget for the model.<br/>
        /// Default Value: 1024
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("thinking_budget")]
        public int? ThinkingBudget { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GeminiThinkingConfig" /> class.
        /// </summary>
        /// <param name="includeThoughts">
        /// Whether to include thoughts in the model's response.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="thinkingBudget">
        /// The thinking budget for the model.<br/>
        /// Default Value: 1024
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GeminiThinkingConfig(
            bool? includeThoughts,
            int? thinkingBudget)
        {
            this.IncludeThoughts = includeThoughts;
            this.ThinkingBudget = thinkingBudget;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GeminiThinkingConfig" /> class.
        /// </summary>
        public GeminiThinkingConfig()
        {
        }
    }
}