//HintName: G.Models.AgentNaturalnessAnalysis.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentNaturalnessAnalysis
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("details", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.UtteranceNaturalnessIssues> Details { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("natural_utterance_count", Required = global::Newtonsoft.Json.Required.Always)]
        public double NaturalUtteranceCount { get; set; } = default!;

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
        /// Initializes a new instance of the <see cref="AgentNaturalnessAnalysis" /> class.
        /// </summary>
        /// <param name="details"></param>
        /// <param name="naturalUtteranceCount"></param>
        /// <param name="totalUtteranceCount"></param>
        public AgentNaturalnessAnalysis(
            global::System.Collections.Generic.IList<global::G.UtteranceNaturalnessIssues> details,
            double naturalUtteranceCount,
            double totalUtteranceCount)
        {
            this.Details = details ?? throw new global::System.ArgumentNullException(nameof(details));
            this.NaturalUtteranceCount = naturalUtteranceCount;
            this.TotalUtteranceCount = totalUtteranceCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentNaturalnessAnalysis" /> class.
        /// </summary>
        public AgentNaturalnessAnalysis()
        {
        }
    }
}