//HintName: G.Models.FileCountByStatusResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FileCountByStatusResponse
    {
        /// <summary>
        /// The counts of files by status
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("counts")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, int> Counts { get; set; }

        /// <summary>
        /// The total number of files
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalCount { get; set; }

        /// <summary>
        /// The ID of the pipeline that the files belong to
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pipeline_id")]
        public global::System.Guid? PipelineId { get; set; }

        /// <summary>
        /// The ID of the data source that the files belong to
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data_source_id")]
        public global::System.Guid? DataSourceId { get; set; }

        /// <summary>
        /// Whether to only count manually uploaded files<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("only_manually_uploaded")]
        public bool? OnlyManuallyUploaded { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FileCountByStatusResponse" /> class.
        /// </summary>
        /// <param name="counts">
        /// The counts of files by status
        /// </param>
        /// <param name="totalCount">
        /// The total number of files
        /// </param>
        /// <param name="pipelineId">
        /// The ID of the pipeline that the files belong to
        /// </param>
        /// <param name="dataSourceId">
        /// The ID of the data source that the files belong to
        /// </param>
        /// <param name="onlyManuallyUploaded">
        /// Whether to only count manually uploaded files<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FileCountByStatusResponse(
            global::System.Collections.Generic.Dictionary<string, int> counts,
            int totalCount,
            global::System.Guid? pipelineId,
            global::System.Guid? dataSourceId,
            bool? onlyManuallyUploaded)
        {
            this.Counts = counts ?? throw new global::System.ArgumentNullException(nameof(counts));
            this.TotalCount = totalCount;
            this.PipelineId = pipelineId;
            this.DataSourceId = dataSourceId;
            this.OnlyManuallyUploaded = onlyManuallyUploaded;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FileCountByStatusResponse" /> class.
        /// </summary>
        public FileCountByStatusResponse()
        {
        }
    }
}