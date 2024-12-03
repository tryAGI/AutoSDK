//HintName: G.Models.StartExportBubbleChartJobRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StartExportBubbleChartJobRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("projectId", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid ProjectId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("series", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.GridChartExportVO Series { get; set; } = default!;

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
        /// Initializes a new instance of the <see cref="StartExportBubbleChartJobRequest" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="series"></param>
        /// <param name="extension"></param>
        public StartExportBubbleChartJobRequest(
            global::System.Guid projectId,
            global::G.GridChartExportVO series,
            string extension)
        {
            this.ProjectId = projectId;
            this.Series = series ?? throw new global::System.ArgumentNullException(nameof(series));
            this.Extension = extension ?? throw new global::System.ArgumentNullException(nameof(extension));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StartExportBubbleChartJobRequest" /> class.
        /// </summary>
        public StartExportBubbleChartJobRequest()
        {
        }
    }
}