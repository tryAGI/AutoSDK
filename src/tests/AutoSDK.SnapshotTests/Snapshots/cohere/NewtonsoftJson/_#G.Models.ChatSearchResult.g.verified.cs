//HintName: G.Models.ChatSearchResult.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatSearchResult
    {
        /// <summary>
        /// The generated search query. Contains the text of the query and a unique identifier for the query.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("search_query")]
        public global::G.ChatSearchQuery? SearchQuery { get; set; }

        /// <summary>
        /// The connector used for fetching documents.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("connector", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ChatSearchResultConnector Connector { get; set; } = default!;

        /// <summary>
        /// Identifiers of documents found by this search query.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("document_ids", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> DocumentIds { get; set; } = default!;

        /// <summary>
        /// An error message if the search failed.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("error_message")]
        public string? ErrorMessage { get; set; }

        /// <summary>
        /// Whether a chat request should continue or not if the request to this connector fails.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("continue_on_failure")]
        public bool? ContinueOnFailure { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatSearchResult" /> class.
        /// </summary>
        /// <param name="searchQuery">
        /// The generated search query. Contains the text of the query and a unique identifier for the query.
        /// </param>
        /// <param name="connector">
        /// The connector used for fetching documents.
        /// </param>
        /// <param name="documentIds">
        /// Identifiers of documents found by this search query.
        /// </param>
        /// <param name="errorMessage">
        /// An error message if the search failed.
        /// </param>
        /// <param name="continueOnFailure">
        /// Whether a chat request should continue or not if the request to this connector fails.
        /// </param>
        public ChatSearchResult(
            global::G.ChatSearchResultConnector connector,
            global::System.Collections.Generic.IList<string> documentIds,
            global::G.ChatSearchQuery? searchQuery,
            string? errorMessage,
            bool? continueOnFailure)
        {
            this.Connector = connector ?? throw new global::System.ArgumentNullException(nameof(connector));
            this.DocumentIds = documentIds ?? throw new global::System.ArgumentNullException(nameof(documentIds));
            this.SearchQuery = searchQuery;
            this.ErrorMessage = errorMessage;
            this.ContinueOnFailure = continueOnFailure;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatSearchResult" /> class.
        /// </summary>
        public ChatSearchResult()
        {
        }
    }
}