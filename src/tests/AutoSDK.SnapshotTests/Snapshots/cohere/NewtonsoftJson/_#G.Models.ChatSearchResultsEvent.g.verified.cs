//HintName: G.Models.ChatSearchResultsEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatSearchResultsEvent : ChatStreamEvent
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
        /// Initializes a new instance of the <see cref="ChatSearchResultsEvent" /> class.
        /// </summary>
        /// <param name="searchResults">
        /// Conducted searches and the ids of documents retrieved from each of them.
        /// </param>
        /// <param name="documents">
        /// Documents fetched from searches or provided by the user.
        /// </param>
        public ChatSearchResultsEvent(
            global::System.Collections.Generic.IList<global::G.ChatSearchResult>? searchResults,
            global::System.Collections.Generic.IList<global::G.ChatDocument>? documents)
        {
            this.SearchResults = searchResults;
            this.Documents = documents;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatSearchResultsEvent" /> class.
        /// </summary>
        public ChatSearchResultsEvent()
        {
        }
    }
}