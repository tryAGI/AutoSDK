//HintName: G.Models.GetReportResponseStatsStatusCounts.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Count of cells in each status
    /// </summary>
    public sealed partial class GetReportResponseStatsStatusCounts
    {
        /// <summary>
        /// Number of completed cells
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("COMPLETED")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Completed { get; set; }

        /// <summary>
        /// Number of failed cells
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("FAILED")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Failed { get; set; }

        /// <summary>
        /// Number of queued cells
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("QUEUED")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Queued { get; set; }

        /// <summary>
        /// Number of running cells
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("RUNNING")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Running { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetReportResponseStatsStatusCounts" /> class.
        /// </summary>
        /// <param name="completed">
        /// Number of completed cells
        /// </param>
        /// <param name="failed">
        /// Number of failed cells
        /// </param>
        /// <param name="queued">
        /// Number of queued cells
        /// </param>
        /// <param name="running">
        /// Number of running cells
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetReportResponseStatsStatusCounts(
            int completed,
            int failed,
            int queued,
            int running)
        {
            this.Completed = completed;
            this.Failed = failed;
            this.Queued = queued;
            this.Running = running;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetReportResponseStatsStatusCounts" /> class.
        /// </summary>
        public GetReportResponseStatsStatusCounts()
        {
        }
    }
}