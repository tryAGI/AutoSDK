//HintName: G.Models.WebSearchRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebSearchRequest
    {
        /// <summary>
        /// The search query.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("query")]
        public string? Query { get; set; }

        /// <summary>
        /// The search topic category. Use `news` for current events and news articles, or `general` for broader web search.<br/>
        /// Default Value: general
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("topic")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebSearchRequestTopicJsonConverter))]
        public global::G.WebSearchRequestTopic? Topic { get; set; }

        /// <summary>
        /// Controls search comprehensiveness:<br/>
        /// - `basic`: Returns fewer but highly relevant results<br/>
        /// - `advanced`: Performs a deeper search with more results<br/>
        /// Default Value: basic
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("search_depth")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebSearchRequestSearchDepthJsonConverter))]
        public global::G.WebSearchRequestSearchDepth? SearchDepth { get; set; }

        /// <summary>
        /// Only applies when `search_depth` is `advanced`. Specifies how many text segments to extract from each source. Limited to 3 chunks maximum.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chunks_per_source")]
        public int? ChunksPerSource { get; set; }

        /// <summary>
        /// Limits the number of search results returned. Cannot exceed 20 sources.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_results")]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Filters results to content published within the specified time range back from the current date. For example, `week` or `w` returns results from the past 7 days.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("time_range")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebSearchRequestTimeRangeJsonConverter))]
        public global::G.WebSearchRequestTimeRange? TimeRange { get; set; }

        /// <summary>
        /// For news topic searches, specifies how many days of news coverage to include.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("days")]
        public int? Days { get; set; }

        /// <summary>
        /// Controls how raw content is included in search results:<br/>
        /// - `text`: Returns plain text without formatting markup<br/>
        /// - `markdown`: Returns structured content with markdown formatting (headers, links, bold text)<br/>
        /// - `true`: Same as `markdown`<br/>
        /// - `false`: Raw content is not included (default if unset)<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include_raw_content")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverter<global::G.WebSearchRequestIncludeRawContent?, bool?>))]
        public global::G.OneOf<global::G.WebSearchRequestIncludeRawContent?, bool?>? IncludeRawContent { get; set; }

        /// <summary>
        /// Whether to include a generated answer to the query in the response. If `false`, only search results are returned.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include_answer")]
        public bool? IncludeAnswer { get; set; }

        /// <summary>
        /// Domains to include in the search. If unset, the search includes all domains.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include_domains")]
        public global::System.Collections.Generic.IList<string>? IncludeDomains { get; set; }

        /// <summary>
        /// Domains to exclude from the search. If unset, the search includes all domains.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exclude_domains")]
        public global::System.Collections.Generic.IList<string>? ExcludeDomains { get; set; }

        /// <summary>
        /// Localizes search results to a specific country. Only applies to general topic searches.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("country")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebSearchRequestCountryJsonConverter))]
        public global::G.WebSearchRequestCountry? Country { get; set; }

        /// <summary>
        /// Enables streaming of search results as they become available.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stream")]
        public bool? Stream { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebSearchRequest" /> class.
        /// </summary>
        /// <param name="query">
        /// The search query.
        /// </param>
        /// <param name="topic">
        /// The search topic category. Use `news` for current events and news articles, or `general` for broader web search.<br/>
        /// Default Value: general
        /// </param>
        /// <param name="searchDepth">
        /// Controls search comprehensiveness:<br/>
        /// - `basic`: Returns fewer but highly relevant results<br/>
        /// - `advanced`: Performs a deeper search with more results<br/>
        /// Default Value: basic
        /// </param>
        /// <param name="chunksPerSource">
        /// Only applies when `search_depth` is `advanced`. Specifies how many text segments to extract from each source. Limited to 3 chunks maximum.
        /// </param>
        /// <param name="maxResults">
        /// Limits the number of search results returned. Cannot exceed 20 sources.
        /// </param>
        /// <param name="timeRange">
        /// Filters results to content published within the specified time range back from the current date. For example, `week` or `w` returns results from the past 7 days.
        /// </param>
        /// <param name="days">
        /// For news topic searches, specifies how many days of news coverage to include.
        /// </param>
        /// <param name="includeRawContent">
        /// Controls how raw content is included in search results:<br/>
        /// - `text`: Returns plain text without formatting markup<br/>
        /// - `markdown`: Returns structured content with markdown formatting (headers, links, bold text)<br/>
        /// - `true`: Same as `markdown`<br/>
        /// - `false`: Raw content is not included (default if unset)<br/>
        /// Default Value: false
        /// </param>
        /// <param name="includeAnswer">
        /// Whether to include a generated answer to the query in the response. If `false`, only search results are returned.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="includeDomains">
        /// Domains to include in the search. If unset, the search includes all domains.
        /// </param>
        /// <param name="excludeDomains">
        /// Domains to exclude from the search. If unset, the search includes all domains.
        /// </param>
        /// <param name="country">
        /// Localizes search results to a specific country. Only applies to general topic searches.
        /// </param>
        /// <param name="stream">
        /// Enables streaming of search results as they become available.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebSearchRequest(
            string? query,
            global::G.WebSearchRequestTopic? topic,
            global::G.WebSearchRequestSearchDepth? searchDepth,
            int? chunksPerSource,
            int? maxResults,
            global::G.WebSearchRequestTimeRange? timeRange,
            int? days,
            global::G.OneOf<global::G.WebSearchRequestIncludeRawContent?, bool?>? includeRawContent,
            bool? includeAnswer,
            global::System.Collections.Generic.IList<string>? includeDomains,
            global::System.Collections.Generic.IList<string>? excludeDomains,
            global::G.WebSearchRequestCountry? country,
            bool? stream)
        {
            this.Query = query;
            this.Topic = topic;
            this.SearchDepth = searchDepth;
            this.ChunksPerSource = chunksPerSource;
            this.MaxResults = maxResults;
            this.TimeRange = timeRange;
            this.Days = days;
            this.IncludeRawContent = includeRawContent;
            this.IncludeAnswer = includeAnswer;
            this.IncludeDomains = includeDomains;
            this.ExcludeDomains = excludeDomains;
            this.Country = country;
            this.Stream = stream;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebSearchRequest" /> class.
        /// </summary>
        public WebSearchRequest()
        {
        }
    }
}