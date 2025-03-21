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
        /// The list of search result items.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.VectorStoreSearchResultItem> Data { get; set; }

        /// <summary>
        /// Indicates if there are more results to fetch.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_more")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HasMore { get; set; }

        /// <summary>
        /// The token for the next page, if any.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_page")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? NextPage { get; set; }

        /// <summary>
        /// The object type, which is always `vector_store.search_results.page`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.VectorStoreSearchResultsPageObjectJsonConverter))]
        public global::G.VectorStoreSearchResultsPageObject Object { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("search_query")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> SearchQuery { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VectorStoreSearchResultsPage" /> class.
        /// </summary>
        /// <param name="data">
        /// The list of search result items.
        /// </param>
        /// <param name="hasMore">
        /// Indicates if there are more results to fetch.
        /// </param>
        /// <param name="nextPage">
        /// The token for the next page, if any.
        /// </param>
        /// <param name="object">
        /// The object type, which is always `vector_store.search_results.page`
        /// </param>
        /// <param name="searchQuery"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VectorStoreSearchResultsPage(
            global::System.Collections.Generic.IList<global::G.VectorStoreSearchResultItem> data,
            bool hasMore,
            string? nextPage,
            global::System.Collections.Generic.IList<string> searchQuery,
            global::G.VectorStoreSearchResultsPageObject @object)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.HasMore = hasMore;
            this.NextPage = nextPage ?? throw new global::System.ArgumentNullException(nameof(nextPage));
            this.SearchQuery = searchQuery ?? throw new global::System.ArgumentNullException(nameof(searchQuery));
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