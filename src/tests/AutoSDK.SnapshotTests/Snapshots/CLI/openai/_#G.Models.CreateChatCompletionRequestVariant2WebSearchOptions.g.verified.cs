﻿//HintName: G.Models.CreateChatCompletionRequestVariant2WebSearchOptions.g.cs

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
        /// Approximate location parameters for the search.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_location")]
        public global::G.CreateChatCompletionRequestVariant2WebSearchOptionsUserLocation? UserLocation { get; set; }

        /// <summary>
        /// High level guidance for the amount of context window space to use for the <br/>
        /// search. One of `low`, `medium`, or `high`. `medium` is the default.<br/>
        /// Default Value: medium
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("search_context_size")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebSearchContextSizeJsonConverter))]
        public global::G.WebSearchContextSize? SearchContextSize { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateChatCompletionRequestVariant2WebSearchOptions" /> class.
        /// </summary>
        /// <param name="userLocation">
        /// Approximate location parameters for the search.
        /// </param>
        /// <param name="searchContextSize">
        /// High level guidance for the amount of context window space to use for the <br/>
        /// search. One of `low`, `medium`, or `high`. `medium` is the default.<br/>
        /// Default Value: medium
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateChatCompletionRequestVariant2WebSearchOptions(
            global::G.CreateChatCompletionRequestVariant2WebSearchOptionsUserLocation? userLocation,
            global::G.WebSearchContextSize? searchContextSize)
        {
            this.UserLocation = userLocation;
            this.SearchContextSize = searchContextSize;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateChatCompletionRequestVariant2WebSearchOptions" /> class.
        /// </summary>
        public CreateChatCompletionRequestVariant2WebSearchOptions()
        {
        }
    }
}