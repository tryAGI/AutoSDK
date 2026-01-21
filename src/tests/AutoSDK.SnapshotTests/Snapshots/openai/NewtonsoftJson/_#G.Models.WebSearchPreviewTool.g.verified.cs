//HintName: G.Models.WebSearchPreviewTool.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This tool searches the web for relevant results to use in a response. Learn more about the [web search tool](https://platform.openai.com/docs/guides/tools-web-search).
    /// </summary>
    public sealed partial class WebSearchPreviewTool
    {
        /// <summary>
        /// The type of the web search tool. One of `web_search_preview` or `web_search_preview_2025_03_11`.<br/>
        /// Default Value: web_search_preview
        /// </summary>
        /// <default>global::G.WebSearchPreviewToolType.WebSearchPreview</default>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.WebSearchPreviewToolType Type { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user_location")]
        public global::G.ApproximateLocation? UserLocation { get; set; }

        /// <summary>
        /// High level guidance for the amount of context window space to use for the search. One of `low`, `medium`, or `high`. `medium` is the default.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("search_context_size")]
        public global::G.WebSearchPreviewToolSearchContextSize? SearchContextSize { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebSearchPreviewTool" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of the web search tool. One of `web_search_preview` or `web_search_preview_2025_03_11`.<br/>
        /// Default Value: web_search_preview
        /// </param>
        /// <param name="userLocation"></param>
        /// <param name="searchContextSize">
        /// High level guidance for the amount of context window space to use for the search. One of `low`, `medium`, or `high`. `medium` is the default.
        /// </param>
        public WebSearchPreviewTool(
            global::G.WebSearchPreviewToolType type,
            global::G.ApproximateLocation? userLocation,
            global::G.WebSearchPreviewToolSearchContextSize? searchContextSize)
        {
            this.Type = type;
            this.UserLocation = userLocation;
            this.SearchContextSize = searchContextSize;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebSearchPreviewTool" /> class.
        /// </summary>
        public WebSearchPreviewTool()
        {
        }
    }
}