//HintName: G.Models.ChatSearchResultsEvent44axt5.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatSearchResultsEvent44axt5
    {
        /// <summary>
        /// Conducted searches and the ids of documents retrieved from each of them.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("search_results")]
        public global::System.Collections.Generic.IList<global::G.ChatSearchResult>? SearchResults { get; set; }

        /// <summary>
        /// Documents fetched from searches or provided by the user.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("documents")]
        public global::System.Collections.Generic.IList<global::G.ChatDocument>? Documents { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatSearchResultsEvent44axt5" /> class.
        /// </summary>
        /// <param name="searchResults">
        /// Conducted searches and the ids of documents retrieved from each of them.
        /// </param>
        /// <param name="documents">
        /// Documents fetched from searches or provided by the user.
        /// </param>
        public ChatSearchResultsEvent44axt5(
            global::System.Collections.Generic.IList<global::G.ChatSearchResult>? searchResults,
            global::System.Collections.Generic.IList<global::G.ChatDocument>? documents)
        {
            this.SearchResults = searchResults;
            this.Documents = documents;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatSearchResultsEvent44axt5" /> class.
        /// </summary>
        public ChatSearchResultsEvent44axt5()
        {
        }
    }
}