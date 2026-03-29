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
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.SearchCommunityVoiceRequestVoiceProviderJsonConverter))]
        public global::G.SearchCommunityVoiceRequestVoiceProvider? VoiceProvider { get; set; }

        /// <summary>
        /// Search query to find voices by name, description, or ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("search_query")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SearchQuery { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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