//HintName: G.Models.ChatWebSearchShorthand.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Web search tool using OpenAI Responses API syntax. Automatically converted to openrouter:web_search.
    /// </summary>
    public sealed partial class ChatWebSearchShorthand
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ChatWebSearchShorthandTypeJsonConverter))]
        public global::G.ChatWebSearchShorthandType Type { get; set; } = default!;

        /// <summary>
        /// Which search engine to use. "auto" (default) uses native if the provider supports it, otherwise Exa. "native" forces the provider's built-in search. "exa" forces the Exa search API. "firecrawl" uses Firecrawl (requires BYOK). "parallel" uses the Parallel search API.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("engine")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ChatWebSearchShorthandEngineJsonConverter))]
        public global::G.ChatWebSearchShorthandEngine? Engine { get; set; }

        /// <summary>
        /// Maximum number of search results to return per search call. Defaults to 5. Applies to Exa, Firecrawl, and Parallel engines; ignored with native provider search.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_results")]
        public double? MaxResults { get; set; }

        /// <summary>
        /// Maximum total number of search results across all search calls in a single request. Once this limit is reached, the tool will stop returning new results. Useful for controlling cost and context size in agentic loops.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_total_results")]
        public double? MaxTotalResults { get; set; }

        /// <summary>
        /// How much context to retrieve per result. Defaults to medium (15000 chars). Only applies when using the Exa engine; ignored with native provider search.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("search_context_size")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ChatWebSearchShorthandSearchContextSizeJsonConverter))]
        public global::G.ChatWebSearchShorthandSearchContextSize? SearchContextSize { get; set; }

        /// <summary>
        /// Approximate user location for location-biased results.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user_location")]
        public global::G.ChatWebSearchShorthandUserLocation? UserLocation { get; set; }

        /// <summary>
        /// Limit search results to these domains. Applies to Exa and Parallel engines. Not supported with Firecrawl or native provider search.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("allowed_domains")]
        public global::System.Collections.Generic.IList<string>? AllowedDomains { get; set; }

        /// <summary>
        /// Exclude search results from these domains. Applies to Exa and Parallel engines. Not supported with Firecrawl or native provider search.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("excluded_domains")]
        public global::System.Collections.Generic.IList<string>? ExcludedDomains { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("parameters")]
        public global::G.ChatWebSearchShorthandParameters? Parameters { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatWebSearchShorthand" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="engine">
        /// Which search engine to use. "auto" (default) uses native if the provider supports it, otherwise Exa. "native" forces the provider's built-in search. "exa" forces the Exa search API. "firecrawl" uses Firecrawl (requires BYOK). "parallel" uses the Parallel search API.
        /// </param>
        /// <param name="maxResults">
        /// Maximum number of search results to return per search call. Defaults to 5. Applies to Exa, Firecrawl, and Parallel engines; ignored with native provider search.
        /// </param>
        /// <param name="maxTotalResults">
        /// Maximum total number of search results across all search calls in a single request. Once this limit is reached, the tool will stop returning new results. Useful for controlling cost and context size in agentic loops.
        /// </param>
        /// <param name="searchContextSize">
        /// How much context to retrieve per result. Defaults to medium (15000 chars). Only applies when using the Exa engine; ignored with native provider search.
        /// </param>
        /// <param name="userLocation">
        /// Approximate user location for location-biased results.
        /// </param>
        /// <param name="allowedDomains">
        /// Limit search results to these domains. Applies to Exa and Parallel engines. Not supported with Firecrawl or native provider search.
        /// </param>
        /// <param name="excludedDomains">
        /// Exclude search results from these domains. Applies to Exa and Parallel engines. Not supported with Firecrawl or native provider search.
        /// </param>
        /// <param name="parameters"></param>
        public ChatWebSearchShorthand(
            global::G.ChatWebSearchShorthandType type,
            global::G.ChatWebSearchShorthandEngine? engine,
            double? maxResults,
            double? maxTotalResults,
            global::G.ChatWebSearchShorthandSearchContextSize? searchContextSize,
            global::G.ChatWebSearchShorthandUserLocation? userLocation,
            global::System.Collections.Generic.IList<string>? allowedDomains,
            global::System.Collections.Generic.IList<string>? excludedDomains,
            global::G.ChatWebSearchShorthandParameters? parameters)
        {
            this.Type = type;
            this.Engine = engine;
            this.MaxResults = maxResults;
            this.MaxTotalResults = maxTotalResults;
            this.SearchContextSize = searchContextSize;
            this.UserLocation = userLocation;
            this.AllowedDomains = allowedDomains;
            this.ExcludedDomains = excludedDomains;
            this.Parameters = parameters;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatWebSearchShorthand" /> class.
        /// </summary>
        public ChatWebSearchShorthand()
        {
        }
    }
}