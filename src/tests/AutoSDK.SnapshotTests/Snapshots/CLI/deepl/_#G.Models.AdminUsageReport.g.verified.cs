//HintName: G.Models.AdminUsageReport.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The response for admin usage statistics.
    /// </summary>
    public sealed partial class AdminUsageReport
    {
        /// <summary>
        /// Contains the detailed usage statistics for the specified date range.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage_report")]
        public global::G.AdminUsageReportData? UsageReport { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminUsageReport" /> class.
        /// </summary>
        /// <param name="usageReport">
        /// Contains the detailed usage statistics for the specified date range.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AdminUsageReport(
            global::G.AdminUsageReportData? usageReport)
        {
            this.UsageReport = usageReport;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminUsageReport" /> class.
        /// </summary>
        public AdminUsageReport()
        {
        }
    }
}