//HintName: G.Models.ListCatalogFilesResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListCatalogFilesResponse
    {
        /// <summary>
        /// The list of files.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("files", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.File> Files { get; set; } = default!;

        /// <summary>
        /// The total number of files.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("totalSize")]
        public int? TotalSize { get; set; }

        /// <summary>
        /// The requested page size.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pageSize")]
        public int? PageSize { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("nextPageToken")]
        public string? NextPageToken { get; set; }

        /// <summary>
        /// The filter.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("filter")]
        public global::G.ListCatalogFilesFilter? Filter { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListCatalogFilesResponse" /> class.
        /// </summary>
        /// <param name="files">
        /// The list of files.
        /// </param>
        /// <param name="totalSize">
        /// The total number of files.
        /// </param>
        /// <param name="pageSize">
        /// The requested page size.
        /// </param>
        /// <param name="nextPageToken"></param>
        /// <param name="filter">
        /// The filter.
        /// </param>
        public ListCatalogFilesResponse(
            global::System.Collections.Generic.IList<global::G.File> files,
            int? totalSize,
            int? pageSize,
            string? nextPageToken,
            global::G.ListCatalogFilesFilter? filter)
        {
            this.Files = files ?? throw new global::System.ArgumentNullException(nameof(files));
            this.TotalSize = totalSize;
            this.PageSize = pageSize;
            this.NextPageToken = nextPageToken;
            this.Filter = filter;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListCatalogFilesResponse" /> class.
        /// </summary>
        public ListCatalogFilesResponse()
        {
        }
    }
}