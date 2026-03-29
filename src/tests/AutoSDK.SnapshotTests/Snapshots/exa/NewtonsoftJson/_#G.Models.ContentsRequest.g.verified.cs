//HintName: G.Models.ContentsRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ContentsRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text")]
        public global::G.OneOf<bool?, global::G.ContentsRequestText>? Text { get; set; }

        /// <summary>
        /// Text snippets the LLM identifies as most relevant from each page. We recommend you using context instead of highlights for LLMs.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("highlights")]
        public global::G.ContentsRequestHighlights? Highlights { get; set; }

        /// <summary>
        /// Summary of the webpage
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("summary")]
        public global::G.ContentsRequestSummary? Summary { get; set; }

        /// <summary>
        /// Options for livecrawling pages.<br/>
        /// 'never': Disable livecrawling (default for neural search).<br/>
        /// 'fallback': Livecrawl when cache is empty.<br/>
        /// 'always': Always livecrawl.<br/>
        /// 'preferred': Always try to livecrawl, but fall back to cache if crawling fails.<br/>
        /// Example: always
        /// </summary>
        /// <example>always</example>
        [global::Newtonsoft.Json.JsonProperty("livecrawl")]
        public global::G.ContentsRequestLivecrawl? Livecrawl { get; set; }

        /// <summary>
        /// The timeout for livecrawling in milliseconds.<br/>
        /// Default Value: 10000<br/>
        /// Example: 1000
        /// </summary>
        /// <example>1000</example>
        [global::Newtonsoft.Json.JsonProperty("livecrawlTimeout")]
        public int? LivecrawlTimeout { get; set; }

        /// <summary>
        /// Maximum age of cached content in hours. Controls when livecrawling is triggered based on content freshness.<br/>
        /// - Positive value (e.g. 24): Use cached content if it's less than this many hours old, otherwise livecrawl.<br/>
        /// - 0: Always livecrawl, never use cache.<br/>
        /// - -1: Never livecrawl, always use cache.<br/>
        /// - Omit (default): Livecrawl as fallback only when no cached content exists.<br/>
        /// Example: 24
        /// </summary>
        /// <example>24</example>
        [global::Newtonsoft.Json.JsonProperty("maxAgeHours")]
        public int? MaxAgeHours { get; set; }

        /// <summary>
        /// The number of subpages to crawl. The actual number crawled may be limited by system constraints.<br/>
        /// Default Value: 0<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::Newtonsoft.Json.JsonProperty("subpages")]
        public int? Subpages { get; set; }

        /// <summary>
        /// Keyword to find specific subpages of search results. Can be a single string or an array of strings, comma delimited.<br/>
        /// Example: sources
        /// </summary>
        /// <example>sources</example>
        [global::Newtonsoft.Json.JsonProperty("subpageTarget")]
        public global::G.OneOf<string, global::System.Collections.Generic.IList<string>>? SubpageTarget { get; set; }

        /// <summary>
        /// Extra parameters to pass.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("extras")]
        public global::G.ContentsRequestExtras? Extras { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("context")]
        public global::G.OneOf<bool?, global::G.ContentsRequestContext>? Context { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ContentsRequest" /> class.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="highlights">
        /// Text snippets the LLM identifies as most relevant from each page. We recommend you using context instead of highlights for LLMs.
        /// </param>
        /// <param name="summary">
        /// Summary of the webpage
        /// </param>
        /// <param name="livecrawl">
        /// Options for livecrawling pages.<br/>
        /// 'never': Disable livecrawling (default for neural search).<br/>
        /// 'fallback': Livecrawl when cache is empty.<br/>
        /// 'always': Always livecrawl.<br/>
        /// 'preferred': Always try to livecrawl, but fall back to cache if crawling fails.<br/>
        /// Example: always
        /// </param>
        /// <param name="livecrawlTimeout">
        /// The timeout for livecrawling in milliseconds.<br/>
        /// Default Value: 10000<br/>
        /// Example: 1000
        /// </param>
        /// <param name="maxAgeHours">
        /// Maximum age of cached content in hours. Controls when livecrawling is triggered based on content freshness.<br/>
        /// - Positive value (e.g. 24): Use cached content if it's less than this many hours old, otherwise livecrawl.<br/>
        /// - 0: Always livecrawl, never use cache.<br/>
        /// - -1: Never livecrawl, always use cache.<br/>
        /// - Omit (default): Livecrawl as fallback only when no cached content exists.<br/>
        /// Example: 24
        /// </param>
        /// <param name="subpages">
        /// The number of subpages to crawl. The actual number crawled may be limited by system constraints.<br/>
        /// Default Value: 0<br/>
        /// Example: 1
        /// </param>
        /// <param name="subpageTarget">
        /// Keyword to find specific subpages of search results. Can be a single string or an array of strings, comma delimited.<br/>
        /// Example: sources
        /// </param>
        /// <param name="extras">
        /// Extra parameters to pass.
        /// </param>
        /// <param name="context"></param>
        public ContentsRequest(
            global::G.OneOf<bool?, global::G.ContentsRequestText>? text,
            global::G.ContentsRequestHighlights? highlights,
            global::G.ContentsRequestSummary? summary,
            global::G.ContentsRequestLivecrawl? livecrawl,
            int? livecrawlTimeout,
            int? maxAgeHours,
            int? subpages,
            global::G.OneOf<string, global::System.Collections.Generic.IList<string>>? subpageTarget,
            global::G.ContentsRequestExtras? extras,
            global::G.OneOf<bool?, global::G.ContentsRequestContext>? context)
        {
            this.Text = text;
            this.Highlights = highlights;
            this.Summary = summary;
            this.Livecrawl = livecrawl;
            this.LivecrawlTimeout = livecrawlTimeout;
            this.MaxAgeHours = maxAgeHours;
            this.Subpages = subpages;
            this.SubpageTarget = subpageTarget;
            this.Extras = extras;
            this.Context = context;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContentsRequest" /> class.
        /// </summary>
        public ContentsRequest()
        {
        }
    }
}