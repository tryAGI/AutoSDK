//HintName: G.Models.RunReportResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RunReportResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("success")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Success { get; set; }

        /// <summary>
        /// The ID of the created final report.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("report_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ReportId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RunReportResponse" /> class.
        /// </summary>
        /// <param name="success"></param>
        /// <param name="reportId">
        /// The ID of the created final report.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RunReportResponse(
            bool success,
            int reportId)
        {
            this.Success = success;
            this.ReportId = reportId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RunReportResponse" /> class.
        /// </summary>
        public RunReportResponse()
        {
        }
    }
}