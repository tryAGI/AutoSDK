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
        [global::System.Text.Json.Serialization.JsonPropertyName("total")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Total { get; set; }

        /// <summary>
        /// Number of output items that resulted in an error.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("errored")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Errored { get; set; }

        /// <summary>
        /// Number of output items that failed to pass the evaluation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Failed { get; set; }

        /// <summary>
        /// Number of output items that passed the evaluation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("passed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Passed { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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