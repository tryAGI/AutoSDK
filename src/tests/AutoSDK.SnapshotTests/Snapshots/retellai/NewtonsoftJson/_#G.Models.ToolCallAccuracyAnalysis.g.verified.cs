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
        [global::Newtonsoft.Json.JsonProperty("details", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.UtteranceToolCallAccuracy> Details { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tool_call_accurate_utterance_count", Required = global::Newtonsoft.Json.Required.Always)]
        public double ToolCallAccurateUtteranceCount { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_utterance_count", Required = global::Newtonsoft.Json.Required.Always)]
        public double TotalUtteranceCount { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolCallAccuracyAnalysis" /> class.
        /// </summary>
        /// <param name="details"></param>
        /// <param name="toolCallAccurateUtteranceCount"></param>
        /// <param name="totalUtteranceCount"></param>
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