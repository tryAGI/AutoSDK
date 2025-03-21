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
        /// High level guidance for the amount of context window space to use for the <br/>
        /// search. One of `low`, `medium`, or `high`. `medium` is the default.<br/>
        /// Default Value: medium
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("search_context_size")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebSearchContextSizeJsonConverter))]
        public global::G.WebSearchContextSize? SearchContextSize { get; set; }

        /// <summary>
        /// The type of the web search tool. One of:<br/>
        /// - `web_search_preview`<br/>
        /// - `web_search_preview_2025_03_11`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebSearchToolTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.WebSearchToolType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_location")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AllOfJsonConverter<global::G.WebSearchLocation, global::G.WebSearchToolUserLocation>))]
        public global::G.AllOf<global::G.WebSearchLocation, global::G.WebSearchToolUserLocation>? UserLocation { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebSearchTool" /> class.
        /// </summary>
        /// <param name="searchContextSize">
        /// High level guidance for the amount of context window space to use for the <br/>
        /// search. One of `low`, `medium`, or `high`. `medium` is the default.<br/>
        /// Default Value: medium
        /// </param>
        /// <param name="type">
        /// The type of the web search tool. One of:<br/>
        /// - `web_search_preview`<br/>
        /// - `web_search_preview_2025_03_11`
        /// </param>
        /// <param name="userLocation"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebSearchTool(
            global::G.WebSearchToolType type,
            global::G.WebSearchContextSize? searchContextSize,
            global::G.AllOf<global::G.WebSearchLocation, global::G.WebSearchToolUserLocation>? userLocation)
        {
            this.Type = type;
            this.SearchContextSize = searchContextSize;
            this.UserLocation = userLocation;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebSearchTool" /> class.
        /// </summary>
        public WebSearchTool()
        {
        }
    }
}