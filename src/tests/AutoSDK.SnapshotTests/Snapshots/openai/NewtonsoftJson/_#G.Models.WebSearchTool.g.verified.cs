//HintName: G.Models.WebSearchTool.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// This tool searches the web for relevant results to use in a response.<br/>
    /// Learn more about the [web search tool](/docs/guides/tools-web-search).
    /// </summary>
    public sealed partial class WebSearchTool
    {
        /// <summary>
        /// The type of the web search tool. One of:<br/>
        /// - `web_search_preview`<br/>
        /// - `web_search_preview_2025_03_11`
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.WebSearchToolType Type { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user_location")]
        public global::G.AllOf<global::G.WebSearchLocation, global::G.WebSearchToolUserLocation>? UserLocation { get; set; }

        /// <summary>
        /// High level guidance for the amount of context window space to use for the <br/>
        /// search. One of `low`, `medium`, or `high`. `medium` is the default.<br/>
        /// Default Value: medium
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("search_context_size")]
        public global::G.WebSearchContextSize? SearchContextSize { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebSearchTool" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of the web search tool. One of:<br/>
        /// - `web_search_preview`<br/>
        /// - `web_search_preview_2025_03_11`
        /// </param>
        /// <param name="userLocation"></param>
        /// <param name="searchContextSize">
        /// High level guidance for the amount of context window space to use for the <br/>
        /// search. One of `low`, `medium`, or `high`. `medium` is the default.<br/>
        /// Default Value: medium
        /// </param>
        public WebSearchTool(
            global::G.WebSearchToolType type,
            global::G.AllOf<global::G.WebSearchLocation, global::G.WebSearchToolUserLocation>? userLocation,
            global::G.WebSearchContextSize? searchContextSize)
        {
            this.Type = type;
            this.UserLocation = userLocation;
            this.SearchContextSize = searchContextSize;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebSearchTool" /> class.
        /// </summary>
        public WebSearchTool()
        {
        }
    }
}