//HintName: G.Models.StartGridChartExportJobRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StartGridChartExportJobRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("projectId", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid ProjectId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("export", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.GridChartExportVO Export { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("extension", Required = global::Newtonsoft.Json.Required.Always)]
        public string Extension { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StartGridChartExportJobRequest" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="export"></param>
        /// <param name="extension"></param>
        public StartGridChartExportJobRequest(
            global::System.Guid projectId,
            global::G.GridChartExportVO export,
            string extension)
        {
            this.ProjectId = projectId;
            this.Export = export ?? throw new global::System.ArgumentNullException(nameof(export));
            this.Extension = extension ?? throw new global::System.ArgumentNullException(nameof(extension));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StartGridChartExportJobRequest" /> class.
        /// </summary>
        public StartGridChartExportJobRequest()
        {
        }
    }
}