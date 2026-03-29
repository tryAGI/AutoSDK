//HintName: G.Models.SearchResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Response from a Google web search query.
    /// </summary>
    public sealed partial class SearchResponse
    {
        /// <summary>
        /// Echo of the search parameters used for the request.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("searchParameters")]
        public global::G.SearchParameters? SearchParameters { get; set; }

        /// <summary>
        /// List of organic search results.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("organic")]
        public global::System.Collections.Generic.IList<global::G.OrganicResult>? Organic { get; set; }

        /// <summary>
        /// Knowledge graph panel data, if available.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("knowledgeGraph")]
        public global::G.KnowledgeGraph? KnowledgeGraph { get; set; }

        /// <summary>
        /// Featured answer box data, if available.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("answerBox")]
        public global::G.AnswerBox? AnswerBox { get; set; }

        /// <summary>
        /// List of People Also Ask questions.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("peopleAlsoAsk")]
        public global::System.Collections.Generic.IList<global::G.PeopleAlsoAskItem>? PeopleAlsoAsk { get; set; }

        /// <summary>
        /// List of related search suggestions.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("relatedSearches")]
        public global::System.Collections.Generic.IList<global::G.RelatedSearch>? RelatedSearches { get; set; }

        /// <summary>
        /// Top stories related to the search, if available.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("topStories")]
        public global::System.Collections.Generic.IList<global::G.NewsResult>? TopStories { get; set; }

        /// <summary>
        /// Number of API credits consumed by this request.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("credits")]
        public int? Credits { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchResponse" /> class.
        /// </summary>
        /// <param name="searchParameters">
        /// Echo of the search parameters used for the request.
        /// </param>
        /// <param name="organic">
        /// List of organic search results.
        /// </param>
        /// <param name="knowledgeGraph">
        /// Knowledge graph panel data, if available.
        /// </param>
        /// <param name="answerBox">
        /// Featured answer box data, if available.
        /// </param>
        /// <param name="peopleAlsoAsk">
        /// List of People Also Ask questions.
        /// </param>
        /// <param name="relatedSearches">
        /// List of related search suggestions.
        /// </param>
        /// <param name="topStories">
        /// Top stories related to the search, if available.
        /// </param>
        /// <param name="credits">
        /// Number of API credits consumed by this request.
        /// </param>
        public SearchResponse(
            global::G.SearchParameters? searchParameters,
            global::System.Collections.Generic.IList<global::G.OrganicResult>? organic,
            global::G.KnowledgeGraph? knowledgeGraph,
            global::G.AnswerBox? answerBox,
            global::System.Collections.Generic.IList<global::G.PeopleAlsoAskItem>? peopleAlsoAsk,
            global::System.Collections.Generic.IList<global::G.RelatedSearch>? relatedSearches,
            global::System.Collections.Generic.IList<global::G.NewsResult>? topStories,
            int? credits)
        {
            this.SearchParameters = searchParameters;
            this.Organic = organic;
            this.KnowledgeGraph = knowledgeGraph;
            this.AnswerBox = answerBox;
            this.PeopleAlsoAsk = peopleAlsoAsk;
            this.RelatedSearches = relatedSearches;
            this.TopStories = topStories;
            this.Credits = credits;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchResponse" /> class.
        /// </summary>
        public SearchResponse()
        {
        }
    }
}