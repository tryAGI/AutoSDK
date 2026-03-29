//HintName: G.Models.Voice.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Voice
    {
        /// <summary>
        /// 音色语种code
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("language_code")]
        public string? LanguageCode { get; set; }

        /// <summary>
        /// 唯一id
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("voice_id")]
        public string? VoiceId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Voice" /> class.
        /// </summary>
        /// <param name="languageCode">
        /// 音色语种code
        /// </param>
        /// <param name="voiceId">
        /// 唯一id
        /// </param>
        public Voice(
            string? languageCode,
            string? voiceId)
        {
            this.LanguageCode = languageCode;
            this.VoiceId = voiceId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Voice" /> class.
        /// </summary>
        public Voice()
        {
        }
    }
}