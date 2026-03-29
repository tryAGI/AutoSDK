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
        [global::Newtonsoft.Json.JsonProperty("success", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Success { get; set; } = default!;

        /// <summary>
        /// The ID of the created final report.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("report_id", Required = global::Newtonsoft.Json.Required.Always)]
        public int ReportId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RunReportResponse" /> class.
        /// </summary>
        /// <param name="success"></param>
        /// <param name="reportId">
        /// The ID of the created final report.
        /// </param>
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