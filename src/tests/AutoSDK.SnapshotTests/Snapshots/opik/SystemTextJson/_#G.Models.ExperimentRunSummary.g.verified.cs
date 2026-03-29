//HintName: G.Models.ExperimentRunSummary.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Included only in responses
    /// </summary>
    public sealed partial class ExperimentRunSummary
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("passed_runs")]
        public int? PassedRuns { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_runs")]
        public int? TotalRuns { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ExperimentRunSummaryStatusJsonConverter))]
        public global::G.ExperimentRunSummaryStatus? Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExperimentRunSummary" /> class.
        /// </summary>
        /// <param name="passedRuns"></param>
        /// <param name="totalRuns"></param>
        /// <param name="status"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExperimentRunSummary(
            int? passedRuns,
            int? totalRuns,
            global::G.ExperimentRunSummaryStatus? status)
        {
            this.PassedRuns = passedRuns;
            this.TotalRuns = totalRuns;
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExperimentRunSummary" /> class.
        /// </summary>
        public ExperimentRunSummary()
        {
        }
    }
}