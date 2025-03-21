//HintName: G.Models.VectorStoreSearchResultsPage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VectorStoreSearchResultsPage
    {
        /// <summary>
        /// The object type, which is always `vector_store.search_results.page`
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("object")]
        public global::G.VectorStoreSearchResultsPageObject Object { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("search_query", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> SearchQuery { get; set; } = default!;

        /// <summary>
        /// The list of search result items.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.VectorStoreSearchResultItem> Data { get; set; } = default!;

        /// <summary>
        /// Indicates if there are more results to fetch.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("has_more", Required = global::Newtonsoft.Json.Required.Always)]
        public bool HasMore { get; set; } = default!;

        /// <summary>
        /// The token for the next page, if any.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("next_page", Required = global::Newtonsoft.Json.Required.Always)]
        public string? NextPage { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VectorStoreSearchResultsPage" /> class.
        /// </summary>
        /// <param name="object">
        /// The object type, which is always `vector_store.search_results.page`
        /// </param>
        /// <param name="searchQuery"></param>
        /// <param name="data">
        /// The list of search result items.
        /// </param>
        /// <param name="hasMore">
        /// Indicates if there are more results to fetch.
        /// </param>
        /// <param name="nextPage">
        /// The token for the next page, if any.
        /// </param>
        public VectorStoreSearchResultsPage(
            global::System.Collections.Generic.IList<string> searchQuery,
            global::System.Collections.Generic.IList<global::G.VectorStoreSearchResultItem> data,
            bool hasMore,
            string? nextPage,
            global::G.VectorStoreSearchResultsPageObject @object)
        {
            this.SearchQuery = searchQuery ?? throw new global::System.ArgumentNullException(nameof(searchQuery));
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.HasMore = hasMore;
            this.NextPage = nextPage ?? throw new global::System.ArgumentNullException(nameof(nextPage));
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VectorStoreSearchResultsPage" /> class.
        /// </summary>
        public VectorStoreSearchResultsPage()
        {
        }
    }
}