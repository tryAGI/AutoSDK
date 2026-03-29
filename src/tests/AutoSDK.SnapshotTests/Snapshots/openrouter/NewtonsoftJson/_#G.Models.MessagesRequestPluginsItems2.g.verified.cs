//HintName: G.Models.MessagesRequestPluginsItems2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MessagesRequestPluginsItems2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public global::G.MessagesRequestPluginsItemsOneOf2Id Id { get; set; }

        /// <summary>
        /// Set to false to disable the web-search plugin for this request. Defaults to true.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_results")]
        public double? MaxResults { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("search_prompt")]
        public string? SearchPrompt { get; set; }

        /// <summary>
        /// The search engine to use for web search.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("engine")]
        public global::G.WebSearchEngine? Engine { get; set; }

        /// <summary>
        /// A list of domains to restrict web search results to. Supports wildcards (e.g. "*.substack.com") and path filtering (e.g. "openai.com/blog").
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("include_domains")]
        public global::System.Collections.Generic.IList<string>? IncludeDomains { get; set; }

        /// <summary>
        /// A list of domains to exclude from web search results. Supports wildcards (e.g. "*.substack.com") and path filtering (e.g. "openai.com/blog").
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("exclude_domains")]
        public global::System.Collections.Generic.IList<string>? ExcludeDomains { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesRequestPluginsItems2" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="enabled">
        /// Set to false to disable the web-search plugin for this request. Defaults to true.
        /// </param>
        /// <param name="maxResults"></param>
        /// <param name="searchPrompt"></param>
        /// <param name="engine">
        /// The search engine to use for web search.
        /// </param>
        /// <param name="includeDomains">
        /// A list of domains to restrict web search results to. Supports wildcards (e.g. "*.substack.com") and path filtering (e.g. "openai.com/blog").
        /// </param>
        /// <param name="excludeDomains">
        /// A list of domains to exclude from web search results. Supports wildcards (e.g. "*.substack.com") and path filtering (e.g. "openai.com/blog").
        /// </param>
        public MessagesRequestPluginsItems2(
            global::G.MessagesRequestPluginsItemsOneOf2Id id,
            bool? enabled,
            double? maxResults,
            string? searchPrompt,
            global::G.WebSearchEngine? engine,
            global::System.Collections.Generic.IList<string>? includeDomains,
            global::System.Collections.Generic.IList<string>? excludeDomains)
        {
            this.Id = id;
            this.Enabled = enabled;
            this.MaxResults = maxResults;
            this.SearchPrompt = searchPrompt;
            this.Engine = engine;
            this.IncludeDomains = includeDomains;
            this.ExcludeDomains = excludeDomains;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesRequestPluginsItems2" /> class.
        /// </summary>
        public MessagesRequestPluginsItems2()
        {
        }
    }
}