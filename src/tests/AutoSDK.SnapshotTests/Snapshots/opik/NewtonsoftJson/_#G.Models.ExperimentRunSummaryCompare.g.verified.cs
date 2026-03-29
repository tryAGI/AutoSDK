//HintName: G.Models.ExperimentRunSummaryCompare.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Included only in responses
    /// </summary>
    public sealed partial class ExperimentRunSummaryCompare
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("passed_runs")]
        public int? PassedRuns { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_runs")]
        public int? TotalRuns { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status")]
        public global::G.ExperimentRunSummaryCompareStatus? Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExperimentRunSummaryCompare" /> class.
        /// </summary>
        /// <param name="passedRuns"></param>
        /// <param name="totalRuns"></param>
        /// <param name="status"></param>
        public ExperimentRunSummaryCompare(
            int? passedRuns,
            int? totalRuns,
            global::G.ExperimentRunSummaryCompareStatus? status)
        {
            this.PassedRuns = passedRuns;
            this.TotalRuns = totalRuns;
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExperimentRunSummaryCompare" /> class.
        /// </summary>
        public ExperimentRunSummaryCompare()
        {
        }
    }
}