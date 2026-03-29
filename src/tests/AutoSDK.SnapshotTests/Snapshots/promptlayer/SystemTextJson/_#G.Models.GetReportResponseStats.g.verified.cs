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
        [global::System.Text.Json.Serialization.JsonPropertyName("status_counts")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.GetReportResponseStatsStatusCounts StatusCounts { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetReportResponseStats" /> class.
        /// </summary>
        /// <param name="statusCounts">
        /// Count of cells in each status
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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