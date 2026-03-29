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
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_id")]
        public string? VoiceId { get; set; }

        /// <summary>
        /// Text to generate speech from.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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