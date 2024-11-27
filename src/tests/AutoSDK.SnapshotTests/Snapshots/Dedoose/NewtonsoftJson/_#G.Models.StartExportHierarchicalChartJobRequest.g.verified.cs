//HintName: G.Models.StartExportHierarchicalChartJobRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StartExportHierarchicalChartJobRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("projectId", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid ProjectId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("exportInfo", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ChartHierarchicalExportInfo ExportInfo { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StartExportHierarchicalChartJobRequest" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="exportInfo"></param>
        public StartExportHierarchicalChartJobRequest(
            global::System.Guid projectId,
            global::G.ChartHierarchicalExportInfo exportInfo)
        {
            this.ProjectId = projectId;
            this.ExportInfo = exportInfo ?? throw new global::System.ArgumentNullException(nameof(exportInfo));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StartExportHierarchicalChartJobRequest" /> class.
        /// </summary>
        public StartExportHierarchicalChartJobRequest()
        {
        }
    }
}