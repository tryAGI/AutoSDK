//HintName: G.Models.EvalRunResultCounts.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Counters summarizing the outcomes of the evaluation run.
    /// </summary>
    public sealed partial class EvalRunResultCounts
    {
        /// <summary>
        /// Total number of executed output items.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total", Required = global::Newtonsoft.Json.Required.Always)]
        public int Total { get; set; } = default!;

        /// <summary>
        /// Number of output items that resulted in an error.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("errored", Required = global::Newtonsoft.Json.Required.Always)]
        public int Errored { get; set; } = default!;

        /// <summary>
        /// Number of output items that failed to pass the evaluation.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("failed", Required = global::Newtonsoft.Json.Required.Always)]
        public int Failed { get; set; } = default!;

        /// <summary>
        /// Number of output items that passed the evaluation.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("passed", Required = global::Newtonsoft.Json.Required.Always)]
        public int Passed { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EvalRunResultCounts" /> class.
        /// </summary>
        /// <param name="total">
        /// Total number of executed output items.
        /// </param>
        /// <param name="errored">
        /// Number of output items that resulted in an error.
        /// </param>
        /// <param name="failed">
        /// Number of output items that failed to pass the evaluation.
        /// </param>
        /// <param name="passed">
        /// Number of output items that passed the evaluation.
        /// </param>
        public EvalRunResultCounts(
            int total,
            int errored,
            int failed,
            int passed)
        {
            this.Total = total;
            this.Errored = errored;
            this.Failed = failed;
            this.Passed = passed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EvalRunResultCounts" /> class.
        /// </summary>
        public EvalRunResultCounts()
        {
        }
    }
}