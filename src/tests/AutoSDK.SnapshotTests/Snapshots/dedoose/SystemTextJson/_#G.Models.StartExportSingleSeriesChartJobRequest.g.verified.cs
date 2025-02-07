//HintName: G.Models.StartExportSingleSeriesChartJobRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StartExportSingleSeriesChartJobRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid ProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exportInfo")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.ChartExportInfo> ExportInfo { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StartExportSingleSeriesChartJobRequest" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="exportInfo"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StartExportSingleSeriesChartJobRequest(
            global::System.Guid projectId,
            global::System.Collections.Generic.IList<global::G.ChartExportInfo> exportInfo)
        {
            this.ProjectId = projectId;
            this.ExportInfo = exportInfo ?? throw new global::System.ArgumentNullException(nameof(exportInfo));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StartExportSingleSeriesChartJobRequest" /> class.
        /// </summary>
        public StartExportSingleSeriesChartJobRequest()
        {
        }
    }
}