//HintName: G.Models.WebSearchServerTool.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Web search tool configuration (2025-08-26 version)
    /// </summary>
    public sealed partial class WebSearchServerTool
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.WebSearchServerToolType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("filters")]
        public global::G.OneOf<global::G.WebSearchServerToolFilters, object>? Filters { get; set; }

        /// <summary>
        /// Size of the search context for web search tools
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("search_context_size")]
        public global::G.SearchContextSizeEnum? SearchContextSize { get; set; }

        /// <summary>
        /// User location information for web search
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user_location")]
        public global::G.WebSearchUserLocation? UserLocation { get; set; }

        /// <summary>
        /// Which search engine to use. "auto" (default) uses native if the provider supports it, otherwise Exa. "native" forces the provider's built-in search. "exa" forces the Exa search API. "firecrawl" uses Firecrawl (requires BYOK). "parallel" uses the Parallel search API.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("engine")]
        public global::G.WebSearchServerToolEngine? Engine { get; set; }

        /// <summary>
        /// Maximum number of search results to return per search call. Defaults to 5. Applies to Exa, Firecrawl, and Parallel engines; ignored with native provider search.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_results")]
        public double? MaxResults { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebSearchServerTool" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="filters"></param>
        /// <param name="searchContextSize">
        /// Size of the search context for web search tools
        /// </param>
        /// <param name="userLocation">
        /// User location information for web search
        /// </param>
        /// <param name="engine">
        /// Which search engine to use. "auto" (default) uses native if the provider supports it, otherwise Exa. "native" forces the provider's built-in search. "exa" forces the Exa search API. "firecrawl" uses Firecrawl (requires BYOK). "parallel" uses the Parallel search API.
        /// </param>
        /// <param name="maxResults">
        /// Maximum number of search results to return per search call. Defaults to 5. Applies to Exa, Firecrawl, and Parallel engines; ignored with native provider search.
        /// </param>
        public WebSearchServerTool(
            global::G.WebSearchServerToolType type,
            global::G.OneOf<global::G.WebSearchServerToolFilters, object>? filters,
            global::G.SearchContextSizeEnum? searchContextSize,
            global::G.WebSearchUserLocation? userLocation,
            global::G.WebSearchServerToolEngine? engine,
            double? maxResults)
        {
            this.Type = type;
            this.Filters = filters;
            this.SearchContextSize = searchContextSize;
            this.UserLocation = userLocation;
            this.Engine = engine;
            this.MaxResults = maxResults;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebSearchServerTool" /> class.
        /// </summary>
        public WebSearchServerTool()
        {
        }
    }
}