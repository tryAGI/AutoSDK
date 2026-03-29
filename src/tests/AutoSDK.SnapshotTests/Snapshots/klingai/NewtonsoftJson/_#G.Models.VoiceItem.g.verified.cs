//HintName: G.Models.VoiceItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VoiceItem
    {
        /// <summary>
        /// Voice ID for audio generation.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("voice_id")]
        public string? VoiceId { get; set; }

        /// <summary>
        /// Text to generate speech from.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text")]
        public string? Text { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceItem" /> class.
        /// </summary>
        /// <param name="voiceId">
        /// Voice ID for audio generation.
        /// </param>
        /// <param name="text">
        /// Text to generate speech from.
        /// </param>
        public VoiceItem(
            string? voiceId,
            string? text)
        {
            this.VoiceId = voiceId;
            this.Text = text;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceItem" /> class.
        /// </summary>
        public VoiceItem()
        {
        }
    }
}