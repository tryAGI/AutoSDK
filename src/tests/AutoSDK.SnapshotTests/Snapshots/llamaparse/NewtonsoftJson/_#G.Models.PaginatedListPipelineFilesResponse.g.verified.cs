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
        [global::Newtonsoft.Json.JsonProperty("files", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.PipelineFile> Files { get; set; } = default!;

        /// <summary>
        /// The limit of the files
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("limit", Required = global::Newtonsoft.Json.Required.Always)]
        public int Limit { get; set; } = default!;

        /// <summary>
        /// The offset of the files
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("offset", Required = global::Newtonsoft.Json.Required.Always)]
        public int Offset { get; set; } = default!;

        /// <summary>
        /// The total number of files
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_count", Required = global::Newtonsoft.Json.Required.Always)]
        public int TotalCount { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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