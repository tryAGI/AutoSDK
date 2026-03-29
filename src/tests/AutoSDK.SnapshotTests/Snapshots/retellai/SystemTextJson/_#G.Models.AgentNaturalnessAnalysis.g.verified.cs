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
        [global::System.Text.Json.Serialization.JsonPropertyName("details")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.UtteranceNaturalnessIssues> Details { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("natural_utterance_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double NaturalUtteranceCount { get; set; }

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
        /// Initializes a new instance of the <see cref="AgentNaturalnessAnalysis" /> class.
        /// </summary>
        /// <param name="details"></param>
        /// <param name="naturalUtteranceCount"></param>
        /// <param name="totalUtteranceCount"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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