//HintName: G.Models.SearchResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SearchResponse
    {
        /// <summary>
        /// Unique identifier for the request<br/>
        /// Example: b5947044c4b78efa9552a7c89b306d95
        /// </summary>
        /// <example>b5947044c4b78efa9552a7c89b306d95</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("requestId")]
        public string? RequestId { get; set; }

        /// <summary>
        /// A list of search results containing title, URL, published date, author, and score.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("results")]
        public global::System.Collections.Generic.IList<global::G.ResultWithContent>? Results { get; set; }

        /// <summary>
        /// For auto searches, indicates which search type was selected.<br/>
        /// Example: auto
        /// </summary>
        /// <example>auto</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("searchType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.SearchResponseSearchTypeJsonConverter))]
        public global::G.SearchResponseSearchType? SearchType { get; set; }

        /// <summary>
        /// A formatted string of the search results ready for LLMs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("context")]
        public string? Context { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("costDollars")]
        public global::G.CostDollars? CostDollars { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchResponse" /> class.
        /// </summary>
        /// <param name="requestId">
        /// Unique identifier for the request<br/>
        /// Example: b5947044c4b78efa9552a7c89b306d95
        /// </param>
        /// <param name="results">
        /// A list of search results containing title, URL, published date, author, and score.
        /// </param>
        /// <param name="searchType">
        /// For auto searches, indicates which search type was selected.<br/>
        /// Example: auto
        /// </param>
        /// <param name="context">
        /// A formatted string of the search results ready for LLMs.
        /// </param>
        /// <param name="costDollars"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchResponse(
            string? requestId,
            global::System.Collections.Generic.IList<global::G.ResultWithContent>? results,
            global::G.SearchResponseSearchType? searchType,
            string? context,
            global::G.CostDollars? costDollars)
        {
            this.RequestId = requestId;
            this.Results = results;
            this.SearchType = searchType;
            this.Context = context;
            this.CostDollars = costDollars;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchResponse" /> class.
        /// </summary>
        public SearchResponse()
        {
        }
    }
}