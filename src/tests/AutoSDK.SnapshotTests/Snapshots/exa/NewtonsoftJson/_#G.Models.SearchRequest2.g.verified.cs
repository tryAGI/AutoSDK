//HintName: G.Models.SearchRequest2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SearchRequest2
    {
        /// <summary>
        /// The query string for the search.<br/>
        /// Example: Latest developments in LLM capabilities
        /// </summary>
        /// <example>Latest developments in LLM capabilities</example>
        [global::Newtonsoft.Json.JsonProperty("query", Required = global::Newtonsoft.Json.Required.Always)]
        public string Query { get; set; } = default!;

        /// <summary>
        /// Additional query variations for deep search. Only works with type="deep". When provided, these queries are used alongside the main query for comprehensive results.<br/>
        /// Example: [LLM advancements, large language model progress]
        /// </summary>
        /// <example>[LLM advancements, large language model progress]</example>
        [global::Newtonsoft.Json.JsonProperty("additionalQueries")]
        public global::System.Collections.Generic.IList<string>? AdditionalQueries { get; set; }

        /// <summary>
        /// The type of search. Neural uses an embeddings-based model, auto (default) intelligently combines available search methods, fast uses streamlined versions of the neural model, and deep provides comprehensive search with query expansion and detailed context.<br/>
        /// Default Value: auto<br/>
        /// Example: auto
        /// </summary>
        /// <example>auto</example>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.SearchRequestTypeJsonConverter))]
        public global::G.SearchRequestType? Type { get; set; }

        /// <summary>
        /// A data category to focus on.<br/>
        /// Example: research paper
        /// </summary>
        /// <example>research paper</example>
        [global::Newtonsoft.Json.JsonProperty("category")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.SearchRequestCategoryJsonConverter))]
        public global::G.SearchRequestCategory? Category { get; set; }

        /// <summary>
        /// The two-letter ISO country code of the user, e.g. US.<br/>
        /// Example: US
        /// </summary>
        /// <example>US</example>
        [global::Newtonsoft.Json.JsonProperty("userLocation")]
        public string? UserLocation { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchRequest2" /> class.
        /// </summary>
        /// <param name="query">
        /// The query string for the search.<br/>
        /// Example: Latest developments in LLM capabilities
        /// </param>
        /// <param name="additionalQueries">
        /// Additional query variations for deep search. Only works with type="deep". When provided, these queries are used alongside the main query for comprehensive results.<br/>
        /// Example: [LLM advancements, large language model progress]
        /// </param>
        /// <param name="type">
        /// The type of search. Neural uses an embeddings-based model, auto (default) intelligently combines available search methods, fast uses streamlined versions of the neural model, and deep provides comprehensive search with query expansion and detailed context.<br/>
        /// Default Value: auto<br/>
        /// Example: auto
        /// </param>
        /// <param name="category">
        /// A data category to focus on.<br/>
        /// Example: research paper
        /// </param>
        /// <param name="userLocation">
        /// The two-letter ISO country code of the user, e.g. US.<br/>
        /// Example: US
        /// </param>
        public SearchRequest2(
            string query,
            global::System.Collections.Generic.IList<string>? additionalQueries,
            global::G.SearchRequestType? type,
            global::G.SearchRequestCategory? category,
            string? userLocation)
        {
            this.Query = query ?? throw new global::System.ArgumentNullException(nameof(query));
            this.AdditionalQueries = additionalQueries;
            this.Type = type;
            this.Category = category;
            this.UserLocation = userLocation;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchRequest2" /> class.
        /// </summary>
        public SearchRequest2()
        {
        }
    }
}