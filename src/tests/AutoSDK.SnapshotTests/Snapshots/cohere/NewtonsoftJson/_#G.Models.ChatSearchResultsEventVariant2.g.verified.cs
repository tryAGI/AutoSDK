//HintName: G.Models.ChatSearchResultsEventVariant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatSearchResultsEventVariant2
    {
        /// <summary>
        /// Documents fetched from searches or provided by the user.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("documents")]
        public global::System.Collections.Generic.IList<global::G.ChatDocument>? Documents { get; set; }

        /// <summary>
        /// Conducted searches and the ids of documents retrieved from each of them.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("search_results")]
        public global::System.Collections.Generic.IList<global::G.ChatSearchResult>? SearchResults { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatSearchResultsEventVariant2" /> class.
        /// </summary>
        /// <param name="documents">
        /// Documents fetched from searches or provided by the user.
        /// </param>
        /// <param name="searchResults">
        /// Conducted searches and the ids of documents retrieved from each of them.
        /// </param>
        public ChatSearchResultsEventVariant2(
            global::System.Collections.Generic.IList<global::G.ChatDocument>? documents,
            global::System.Collections.Generic.IList<global::G.ChatSearchResult>? searchResults)
        {
            this.Documents = documents;
            this.SearchResults = searchResults;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatSearchResultsEventVariant2" /> class.
        /// </summary>
        public ChatSearchResultsEventVariant2()
        {
        }
    }
}