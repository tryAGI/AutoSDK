//HintName: G.Models.GetReportResponseStats.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetReportResponseStats
    {
        /// <summary>
        /// Count of cells in each status
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status_counts", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.GetReportResponseStatsStatusCounts StatusCounts { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetReportResponseStats" /> class.
        /// </summary>
        /// <param name="statusCounts">
        /// Count of cells in each status
        /// </param>
        public GetReportResponseStats(
            global::G.GetReportResponseStatsStatusCounts statusCounts)
        {
            this.StatusCounts = statusCounts ?? throw new global::System.ArgumentNullException(nameof(statusCounts));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetReportResponseStats" /> class.
        /// </summary>
        public GetReportResponseStats()
        {
        }
    }
}