//HintName: G.Models.PreviewWebSearchServerTool.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Web search preview tool configuration
    /// </summary>
    public sealed partial class PreviewWebSearchServerTool
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.PreviewWebSearchServerToolType Type { get; set; }

        /// <summary>
        /// Size of the search context for web search tools
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("search_context_size")]
        public global::G.SearchContextSizeEnum? SearchContextSize { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user_location")]
        public global::G.PreviewWebSearchUserLocation? UserLocation { get; set; }

        /// <summary>
        /// Which search engine to use. "auto" (default) uses native if the provider supports it, otherwise Exa. "native" forces the provider's built-in search. "exa" forces the Exa search API. "firecrawl" uses Firecrawl (requires BYOK). "parallel" uses the Parallel search API.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("engine")]
        public global::G.PreviewWebSearchServerToolEngine? Engine { get; set; }

        /// <summary>
        /// Maximum number of search results to return per search call. Defaults to 5. Applies to Exa, Firecrawl, and Parallel engines; ignored with native provider search.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_results")]
        public double? MaxResults { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("filters")]
        public global::G.OneOf<global::G.PreviewWebSearchServerToolFilters, object>? Filters { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PreviewWebSearchServerTool" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="searchContextSize">
        /// Size of the search context for web search tools
        /// </param>
        /// <param name="userLocation"></param>
        /// <param name="engine">
        /// Which search engine to use. "auto" (default) uses native if the provider supports it, otherwise Exa. "native" forces the provider's built-in search. "exa" forces the Exa search API. "firecrawl" uses Firecrawl (requires BYOK). "parallel" uses the Parallel search API.
        /// </param>
        /// <param name="maxResults">
        /// Maximum number of search results to return per search call. Defaults to 5. Applies to Exa, Firecrawl, and Parallel engines; ignored with native provider search.
        /// </param>
        /// <param name="filters"></param>
        public PreviewWebSearchServerTool(
            global::G.PreviewWebSearchServerToolType type,
            global::G.SearchContextSizeEnum? searchContextSize,
            global::G.PreviewWebSearchUserLocation? userLocation,
            global::G.PreviewWebSearchServerToolEngine? engine,
            double? maxResults,
            global::G.OneOf<global::G.PreviewWebSearchServerToolFilters, object>? filters)
        {
            this.Type = type;
            this.SearchContextSize = searchContextSize;
            this.UserLocation = userLocation;
            this.Engine = engine;
            this.MaxResults = maxResults;
            this.Filters = filters;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PreviewWebSearchServerTool" /> class.
        /// </summary>
        public PreviewWebSearchServerTool()
        {
        }
    }
}