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
        [global::Newtonsoft.Json.JsonProperty("COMPLETED", Required = global::Newtonsoft.Json.Required.Always)]
        public int Completed { get; set; } = default!;

        /// <summary>
        /// Number of failed cells
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("FAILED", Required = global::Newtonsoft.Json.Required.Always)]
        public int Failed { get; set; } = default!;

        /// <summary>
        /// Number of queued cells
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("QUEUED", Required = global::Newtonsoft.Json.Required.Always)]
        public int Queued { get; set; } = default!;

        /// <summary>
        /// Number of running cells
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("RUNNING", Required = global::Newtonsoft.Json.Required.Always)]
        public int Running { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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