//HintName: G.Models.SearchCommunityVoiceResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SearchCommunityVoiceResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voices")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.SearchCommunityVoiceResponseVoice> Voices { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchCommunityVoiceResponse" /> class.
        /// </summary>
        /// <param name="voices"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchCommunityVoiceResponse(
            global::System.Collections.Generic.IList<global::G.SearchCommunityVoiceResponseVoice> voices)
        {
            this.Voices = voices ?? throw new global::System.ArgumentNullException(nameof(voices));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchCommunityVoiceResponse" /> class.
        /// </summary>
        public SearchCommunityVoiceResponse()
        {
        }
    }
}