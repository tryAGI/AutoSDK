//HintName: G.Models.ListFileSearchStoresResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Response from `ListFileSearchStores` containing a paginated list of `FileSearchStores`. The results are sorted by ascending `file_search_store.create_time`.
    /// </summary>
    public sealed partial class ListFileSearchStoresResponse
    {
        /// <summary>
        /// The returned rag_stores.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("fileSearchStores")]
        public global::System.Collections.Generic.IList<global::G.FileSearchStore>? FileSearchStores { get; set; }

        /// <summary>
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no more pages.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("nextPageToken")]
        public string? NextPageToken { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListFileSearchStoresResponse" /> class.
        /// </summary>
        /// <param name="fileSearchStores">
        /// The returned rag_stores.
        /// </param>
        /// <param name="nextPageToken">
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no more pages.
        /// </param>
        public ListFileSearchStoresResponse(
            global::System.Collections.Generic.IList<global::G.FileSearchStore>? fileSearchStores,
            string? nextPageToken)
        {
            this.FileSearchStores = fileSearchStores;
            this.NextPageToken = nextPageToken;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListFileSearchStoresResponse" /> class.
        /// </summary>
        public ListFileSearchStoresResponse()
        {
        }
    }
}