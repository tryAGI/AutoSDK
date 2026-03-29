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
        [global::Newtonsoft.Json.JsonProperty("voices", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.SearchCommunityVoiceResponseVoice> Voices { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchCommunityVoiceResponse" /> class.
        /// </summary>
        /// <param name="voices"></param>
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