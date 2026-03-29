//HintName: G.Models.EvaluationRunStats.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Run statistics
    /// </summary>
    public sealed partial class EvaluationRunStats
    {
        /// <summary>
        /// Count of cells by status
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status_counts")]
        public object? StatusCounts { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluationRunStats" /> class.
        /// </summary>
        /// <param name="statusCounts">
        /// Count of cells by status
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EvaluationRunStats(
            object? statusCounts)
        {
            this.StatusCounts = statusCounts;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluationRunStats" /> class.
        /// </summary>
        public EvaluationRunStats()
        {
        }
    }
}