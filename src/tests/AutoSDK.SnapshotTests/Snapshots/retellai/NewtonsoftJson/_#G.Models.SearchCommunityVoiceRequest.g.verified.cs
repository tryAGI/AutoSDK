//HintName: G.Models.SearchCommunityVoiceRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SearchCommunityVoiceRequest
    {
        /// <summary>
        /// Voice provider to search.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("voice_provider")]
        public global::G.SearchCommunityVoiceRequestVoiceProvider? VoiceProvider { get; set; }

        /// <summary>
        /// Search query to find voices by name, description, or ID.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("search_query", Required = global::Newtonsoft.Json.Required.Always)]
        public string SearchQuery { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchCommunityVoiceRequest" /> class.
        /// </summary>
        /// <param name="searchQuery">
        /// Search query to find voices by name, description, or ID.
        /// </param>
        /// <param name="voiceProvider">
        /// Voice provider to search.
        /// </param>
        public SearchCommunityVoiceRequest(
            string searchQuery,
            global::G.SearchCommunityVoiceRequestVoiceProvider? voiceProvider)
        {
            this.VoiceProvider = voiceProvider;
            this.SearchQuery = searchQuery ?? throw new global::System.ArgumentNullException(nameof(searchQuery));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchCommunityVoiceRequest" /> class.
        /// </summary>
        public SearchCommunityVoiceRequest()
        {
        }
    }
}