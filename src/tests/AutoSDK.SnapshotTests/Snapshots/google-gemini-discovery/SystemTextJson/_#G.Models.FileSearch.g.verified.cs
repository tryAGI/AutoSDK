//HintName: G.Models.FileSearch.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The FileSearch tool that retrieves knowledge from Semantic Retrieval corpora. Files are imported to Semantic Retrieval corpora using the ImportFile API.
    /// </summary>
    public sealed partial class FileSearch
    {
        /// <summary>
        /// Required. The names of the file_search_stores to retrieve from. Example: `fileSearchStores/my-file-search-store-123`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fileSearchStoreNames")]
        public global::System.Collections.Generic.IList<string>? FileSearchStoreNames { get; set; }

        /// <summary>
        /// Optional. The number of semantic retrieval chunks to retrieve.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("topK")]
        public int? TopK { get; set; }

        /// <summary>
        /// Optional. Metadata filter to apply to the semantic retrieval documents and chunks.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadataFilter")]
        public string? MetadataFilter { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FileSearch" /> class.
        /// </summary>
        /// <param name="fileSearchStoreNames">
        /// Required. The names of the file_search_stores to retrieve from. Example: `fileSearchStores/my-file-search-store-123`
        /// </param>
        /// <param name="topK">
        /// Optional. The number of semantic retrieval chunks to retrieve.
        /// </param>
        /// <param name="metadataFilter">
        /// Optional. Metadata filter to apply to the semantic retrieval documents and chunks.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FileSearch(
            global::System.Collections.Generic.IList<string>? fileSearchStoreNames,
            int? topK,
            string? metadataFilter)
        {
            this.FileSearchStoreNames = fileSearchStoreNames;
            this.TopK = topK;
            this.MetadataFilter = metadataFilter;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FileSearch" /> class.
        /// </summary>
        public FileSearch()
        {
        }
    }
}