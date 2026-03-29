//HintName: G.Models.LipSyncInput.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LipSyncInput
    {
        /// <summary>
        /// URL of the video for lip-sync.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("video_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VideoUrl { get; set; }

        /// <summary>
        /// URL of the audio file. Required if tts_text is not provided.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_url")]
        public string? AudioUrl { get; set; }

        /// <summary>
        /// Text to generate speech for lip-sync. Required if audio_url is not provided.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tts_text")]
        public string? TtsText { get; set; }

        /// <summary>
        /// Voice ID for TTS generation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tts_voice")]
        public string? TtsVoice { get; set; }

        /// <summary>
        /// Speed of TTS generation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tts_speed")]
        public double? TtsSpeed { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LipSyncInput" /> class.
        /// </summary>
        /// <param name="videoUrl">
        /// URL of the video for lip-sync.
        /// </param>
        /// <param name="audioUrl">
        /// URL of the audio file. Required if tts_text is not provided.
        /// </param>
        /// <param name="ttsText">
        /// Text to generate speech for lip-sync. Required if audio_url is not provided.
        /// </param>
        /// <param name="ttsVoice">
        /// Voice ID for TTS generation.
        /// </param>
        /// <param name="ttsSpeed">
        /// Speed of TTS generation.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LipSyncInput(
            string videoUrl,
            string? audioUrl,
            string? ttsText,
            string? ttsVoice,
            double? ttsSpeed)
        {
            this.VideoUrl = videoUrl ?? throw new global::System.ArgumentNullException(nameof(videoUrl));
            this.AudioUrl = audioUrl;
            this.TtsText = ttsText;
            this.TtsVoice = ttsVoice;
            this.TtsSpeed = ttsSpeed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LipSyncInput" /> class.
        /// </summary>
        public LipSyncInput()
        {
        }
    }
}