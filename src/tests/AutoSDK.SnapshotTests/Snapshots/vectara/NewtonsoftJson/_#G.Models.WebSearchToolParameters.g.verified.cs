//HintName: G.Models.WebSearchToolParameters.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Configurable parameters for the web search tool. If not provided, will be filled in by the agent.
    /// </summary>
    public sealed partial class WebSearchToolParameters
    {
        /// <summary>
        /// The search query to execute.<br/>
        /// Example: latest AI developments 2024
        /// </summary>
        /// <example>latest AI developments 2024</example>
        [global::Newtonsoft.Json.JsonProperty("query")]
        public string? Query { get; set; }

        /// <summary>
        /// Maximum number of results to return.<br/>
        /// Example: 10
        /// </summary>
        /// <example>10</example>
        [global::Newtonsoft.Json.JsonProperty("limit")]
        public int? Limit { get; set; }

        /// <summary>
        /// Search provider to use.<br/>
        /// Example: tavily
        /// </summary>
        /// <example>tavily</example>
        [global::Newtonsoft.Json.JsonProperty("provider")]
        public global::G.WebSearchToolParametersProvider? Provider { get; set; }

        /// <summary>
        /// List of domains to specifically include in search results. When specified, results will ONLY come from these domains. Supports exact domains (e.g., "github.com"), subdomains (e.g., "docs.github.com"), and wildcard patterns (e.g., "*.github.com"). Subpaths are not supported.<br/>
        /// Example: [github.com, docs.github.com, *.stackoverflow.com]
        /// </summary>
        /// <example>[github.com, docs.github.com, *.stackoverflow.com]</example>
        [global::Newtonsoft.Json.JsonProperty("include_domains")]
        public global::System.Collections.Generic.IList<string>? IncludeDomains { get; set; }

        /// <summary>
        /// List of domains to specifically exclude from search results. Supports exact domains (e.g., "spam.com"), subdomains (e.g., "bad.spam.com"), and wildcard patterns (e.g., "*.spam.com"). Subpaths are not supported.<br/>
        /// Example: [spam.com, unreliable-source.com]
        /// </summary>
        /// <example>[spam.com, unreliable-source.com]</example>
        [global::Newtonsoft.Json.JsonProperty("exclude_domains")]
        public global::System.Collections.Generic.IList<string>? ExcludeDomains { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebSearchToolParameters" /> class.
        /// </summary>
        /// <param name="query">
        /// The search query to execute.<br/>
        /// Example: latest AI developments 2024
        /// </param>
        /// <param name="limit">
        /// Maximum number of results to return.<br/>
        /// Example: 10
        /// </param>
        /// <param name="provider">
        /// Search provider to use.<br/>
        /// Example: tavily
        /// </param>
        /// <param name="includeDomains">
        /// List of domains to specifically include in search results. When specified, results will ONLY come from these domains. Supports exact domains (e.g., "github.com"), subdomains (e.g., "docs.github.com"), and wildcard patterns (e.g., "*.github.com"). Subpaths are not supported.<br/>
        /// Example: [github.com, docs.github.com, *.stackoverflow.com]
        /// </param>
        /// <param name="excludeDomains">
        /// List of domains to specifically exclude from search results. Supports exact domains (e.g., "spam.com"), subdomains (e.g., "bad.spam.com"), and wildcard patterns (e.g., "*.spam.com"). Subpaths are not supported.<br/>
        /// Example: [spam.com, unreliable-source.com]
        /// </param>
        public WebSearchToolParameters(
            string? query,
            int? limit,
            global::G.WebSearchToolParametersProvider? provider,
            global::System.Collections.Generic.IList<string>? includeDomains,
            global::System.Collections.Generic.IList<string>? excludeDomains)
        {
            this.Query = query;
            this.Limit = limit;
            this.Provider = provider;
            this.IncludeDomains = includeDomains;
            this.ExcludeDomains = excludeDomains;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebSearchToolParameters" /> class.
        /// </summary>
        public WebSearchToolParameters()
        {
        }
    }
}