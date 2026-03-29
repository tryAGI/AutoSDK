//HintName: G.Models.ToolCallAccuracyAnalysis.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ToolCallAccuracyAnalysis
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("details")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.UtteranceToolCallAccuracy> Details { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_call_accurate_utterance_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double ToolCallAccurateUtteranceCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_utterance_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double TotalUtteranceCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolCallAccuracyAnalysis" /> class.
        /// </summary>
        /// <param name="details"></param>
        /// <param name="toolCallAccurateUtteranceCount"></param>
        /// <param name="totalUtteranceCount"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolCallAccuracyAnalysis(
            global::System.Collections.Generic.IList<global::G.UtteranceToolCallAccuracy> details,
            double toolCallAccurateUtteranceCount,
            double totalUtteranceCount)
        {
            this.Details = details ?? throw new global::System.ArgumentNullException(nameof(details));
            this.ToolCallAccurateUtteranceCount = toolCallAccurateUtteranceCount;
            this.TotalUtteranceCount = totalUtteranceCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolCallAccuracyAnalysis" /> class.
        /// </summary>
        public ToolCallAccuracyAnalysis()
        {
        }
    }
}