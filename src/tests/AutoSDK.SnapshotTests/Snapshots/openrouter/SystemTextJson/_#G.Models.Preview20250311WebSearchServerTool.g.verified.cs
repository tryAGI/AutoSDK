//HintName: G.Models.Preview20250311WebSearchServerTool.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Web search preview tool configuration (2025-03-11 version)
    /// </summary>
    public sealed partial class Preview20250311WebSearchServerTool
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.Preview20250311WebSearchServerToolTypeJsonConverter))]
        public global::G.Preview20250311WebSearchServerToolType Type { get; set; }

        /// <summary>
        /// Size of the search context for web search tools
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("search_context_size")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.SearchContextSizeEnumJsonConverter))]
        public global::G.SearchContextSizeEnum? SearchContextSize { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_location")]
        public global::G.PreviewWebSearchUserLocation? UserLocation { get; set; }

        /// <summary>
        /// Which search engine to use. "auto" (default) uses native if the provider supports it, otherwise Exa. "native" forces the provider's built-in search. "exa" forces the Exa search API. "firecrawl" uses Firecrawl (requires BYOK). "parallel" uses the Parallel search API.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("engine")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.Preview20250311WebSearchServerToolEngineJsonConverter))]
        public global::G.Preview20250311WebSearchServerToolEngine? Engine { get; set; }

        /// <summary>
        /// Maximum number of search results to return per search call. Defaults to 5. Applies to Exa, Firecrawl, and Parallel engines; ignored with native provider search.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_results")]
        public double? MaxResults { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filters")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverter<global::G.Preview20250311WebSearchServerToolFilters, object>))]
        public global::G.OneOf<global::G.Preview20250311WebSearchServerToolFilters, object>? Filters { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Preview20250311WebSearchServerTool" /> class.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Preview20250311WebSearchServerTool(
            global::G.Preview20250311WebSearchServerToolType type,
            global::G.SearchContextSizeEnum? searchContextSize,
            global::G.PreviewWebSearchUserLocation? userLocation,
            global::G.Preview20250311WebSearchServerToolEngine? engine,
            double? maxResults,
            global::G.OneOf<global::G.Preview20250311WebSearchServerToolFilters, object>? filters)
        {
            this.Type = type;
            this.SearchContextSize = searchContextSize;
            this.UserLocation = userLocation;
            this.Engine = engine;
            this.MaxResults = maxResults;
            this.Filters = filters;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Preview20250311WebSearchServerTool" /> class.
        /// </summary>
        public Preview20250311WebSearchServerTool()
        {
        }
    }
}