//HintName: G.Models.CreateChatCompletionRequestVariant2WebSearchOptions.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This tool searches the web for relevant results to use in a response.<br/>
    /// Learn more about the [web search tool](/docs/guides/tools-web-search?api-mode=chat).
    /// </summary>
    public sealed partial class CreateChatCompletionRequestVariant2WebSearchOptions
    {
        /// <summary>
        /// High level guidance for the amount of context window space to use for the <br/>
        /// search. One of `low`, `medium`, or `high`. `medium` is the default.<br/>
        /// Default Value: medium
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("search_context_size")]
        public global::G.WebSearchContextSize? SearchContextSize { get; set; }

        /// <summary>
        /// Approximate location parameters for the search.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user_location")]
        public global::G.CreateChatCompletionRequestVariant2WebSearchOptionsUserLocation? UserLocation { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateChatCompletionRequestVariant2WebSearchOptions" /> class.
        /// </summary>
        /// <param name="searchContextSize">
        /// High level guidance for the amount of context window space to use for the <br/>
        /// search. One of `low`, `medium`, or `high`. `medium` is the default.<br/>
        /// Default Value: medium
        /// </param>
        /// <param name="userLocation">
        /// Approximate location parameters for the search.
        /// </param>
        public CreateChatCompletionRequestVariant2WebSearchOptions(
            global::G.WebSearchContextSize? searchContextSize,
            global::G.CreateChatCompletionRequestVariant2WebSearchOptionsUserLocation? userLocation)
        {
            this.SearchContextSize = searchContextSize;
            this.UserLocation = userLocation;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateChatCompletionRequestVariant2WebSearchOptions" /> class.
        /// </summary>
        public CreateChatCompletionRequestVariant2WebSearchOptions()
        {
        }
    }
}