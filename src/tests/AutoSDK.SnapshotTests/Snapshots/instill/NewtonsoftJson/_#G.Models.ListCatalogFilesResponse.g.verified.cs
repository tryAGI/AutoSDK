//HintName: G.Models.ListCatalogFilesResponse.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

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
        [global::Newtonsoft.Json.JsonProperty("files")]
        public global::System.Collections.Generic.IList<global::G.File>? Files { get; set; }

        /// <summary>
        /// The total number of files.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("totalSize")]
        public int TotalSize { get; set; }

        /// <summary>
        /// The requested page size.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pageSize")]
        public int PageSize { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("nextPageToken")]
        public string? NextPageToken { get; set; }

        /// <summary>
        /// The filter.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("filter")]
        public global::G.AllOf<global::G.ListCatalogFilesFilter>? Filter { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}