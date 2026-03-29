//HintName: G.Models.SearchRetrieveResponse200.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SearchRetrieveResponse200
    {
        /// <summary>
        /// An array that contains your search results. For each match found, the model returns the following fields:
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public global::System.Collections.Generic.IList<global::G.SearchItem>? Data { get; set; }

        /// <summary>
        /// An object that provides information about pagination.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("page_info")]
        public global::G.SearchPageTokenGetResponsesContentApplicationJsonSchemaPageInfo? PageInfo { get; set; }

        /// <summary>
        /// An object that contains details about the index you queried.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("search_pool")]
        public global::G.SearchPool? SearchPool { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchRetrieveResponse200" /> class.
        /// </summary>
        /// <param name="data">
        /// An array that contains your search results. For each match found, the model returns the following fields:
        /// </param>
        /// <param name="pageInfo">
        /// An object that provides information about pagination.
        /// </param>
        /// <param name="searchPool">
        /// An object that contains details about the index you queried.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchRetrieveResponse200(
            global::System.Collections.Generic.IList<global::G.SearchItem>? data,
            global::G.SearchPageTokenGetResponsesContentApplicationJsonSchemaPageInfo? pageInfo,
            global::G.SearchPool? searchPool)
        {
            this.Data = data;
            this.PageInfo = pageInfo;
            this.SearchPool = searchPool;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchRetrieveResponse200" /> class.
        /// </summary>
        public SearchRetrieveResponse200()
        {
        }
    }
}