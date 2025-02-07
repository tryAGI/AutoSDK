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
        [global::System.Text.Json.Serialization.JsonPropertyName("projectId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid ProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("series")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.GridChartExportVO Series { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extension")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Extension { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StartExportBubbleChartJobRequest" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="series"></param>
        /// <param name="extension"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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