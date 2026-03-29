//HintName: G.Models.BaseReasoningConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BaseReasoningConfig
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("effort")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ReasoningEffortEnumJsonConverter))]
        public global::G.ReasoningEffortEnum? Effort { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ReasoningSummaryVerbosityEnumJsonConverter))]
        public global::G.ReasoningSummaryVerbosityEnum? Summary { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseReasoningConfig" /> class.
        /// </summary>
        /// <param name="effort"></param>
        /// <param name="summary"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BaseReasoningConfig(
            global::G.ReasoningEffortEnum? effort,
            global::G.ReasoningSummaryVerbosityEnum? summary)
        {
            this.Effort = effort;
            this.Summary = summary;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseReasoningConfig" /> class.
        /// </summary>
        public BaseReasoningConfig()
        {
        }
    }
}