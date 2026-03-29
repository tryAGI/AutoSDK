//HintName: G.Models.ReferenceAudio.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A voice sample with its transcript, used for zero-shot voice cloning. The model will attempt to match the voice characteristics from the audio sample.
    /// </summary>
    public sealed partial class ReferenceAudio
    {
        /// <summary>
        /// Raw audio bytes of the voice sample. Supported formats: WAV, MP3, FLAC. For best results, use 10-30 seconds of clear speech with minimal background noise.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required byte[] Audio { get; set; }

        /// <summary>
        /// Raw audio bytes of the voice sample. Supported formats: WAV, MP3, FLAC. For best results, use 10-30 seconds of clear speech with minimal background noise.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audioname")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Audioname { get; set; }

        /// <summary>
        /// The exact transcript of what is spoken in the audio sample. Accuracy is important for voice cloning quality.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReferenceAudio" /> class.
        /// </summary>
        /// <param name="audio">
        /// Raw audio bytes of the voice sample. Supported formats: WAV, MP3, FLAC. For best results, use 10-30 seconds of clear speech with minimal background noise.
        /// </param>
        /// <param name="audioname">
        /// Raw audio bytes of the voice sample. Supported formats: WAV, MP3, FLAC. For best results, use 10-30 seconds of clear speech with minimal background noise.
        /// </param>
        /// <param name="text">
        /// The exact transcript of what is spoken in the audio sample. Accuracy is important for voice cloning quality.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReferenceAudio(
            byte[] audio,
            string audioname,
            string text)
        {
            this.Audio = audio ?? throw new global::System.ArgumentNullException(nameof(audio));
            this.Audioname = audioname ?? throw new global::System.ArgumentNullException(nameof(audioname));
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReferenceAudio" /> class.
        /// </summary>
        public ReferenceAudio()
        {
        }
    }
}