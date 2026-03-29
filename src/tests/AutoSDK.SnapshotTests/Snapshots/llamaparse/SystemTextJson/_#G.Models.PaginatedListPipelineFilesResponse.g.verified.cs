//HintName: G.Models.PaginatedListPipelineFilesResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Paginated list of pipeline files.
    /// </summary>
    public sealed partial class PaginatedListPipelineFilesResponse
    {
        /// <summary>
        /// The files to list
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("files")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.PipelineFile> Files { get; set; }

        /// <summary>
        /// The limit of the files
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Limit { get; set; }

        /// <summary>
        /// The offset of the files
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("offset")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Offset { get; set; }

        /// <summary>
        /// The total number of files
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PaginatedListPipelineFilesResponse" /> class.
        /// </summary>
        /// <param name="files">
        /// The files to list
        /// </param>
        /// <param name="limit">
        /// The limit of the files
        /// </param>
        /// <param name="offset">
        /// The offset of the files
        /// </param>
        /// <param name="totalCount">
        /// The total number of files
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PaginatedListPipelineFilesResponse(
            global::System.Collections.Generic.IList<global::G.PipelineFile> files,
            int limit,
            int offset,
            int totalCount)
        {
            this.Files = files ?? throw new global::System.ArgumentNullException(nameof(files));
            this.Limit = limit;
            this.Offset = offset;
            this.TotalCount = totalCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PaginatedListPipelineFilesResponse" /> class.
        /// </summary>
        public PaginatedListPipelineFilesResponse()
        {
        }
    }
}