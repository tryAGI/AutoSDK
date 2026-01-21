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
        [global::System.Text.Json.Serialization.JsonPropertyName("search_query")]
        public global::G.ChatSearchQuery? SearchQuery { get; set; }

        /// <summary>
        /// The connector from which this result comes from.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("connector")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ChatSearchResultConnector Connector { get; set; }

        /// <summary>
        /// Identifiers of documents found by this search query.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("document_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> DocumentIds { get; set; }

        /// <summary>
        /// An error message if the search failed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_message")]
        public string? ErrorMessage { get; set; }

        /// <summary>
        /// Whether a chat request should continue or not if the request to this connector fails.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("continue_on_failure")]
        public bool? ContinueOnFailure { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatSearchResult" /> class.
        /// </summary>
        /// <param name="searchQuery">
        /// The generated search query. Contains the text of the query and a unique identifier for the query.
        /// </param>
        /// <param name="connector">
        /// The connector from which this result comes from.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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