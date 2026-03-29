//HintName: G.Models.GeneratedAudio.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GeneratedAudio
    {
        /// <summary>
        /// Default Value: generated_audio
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Duration of the audio in seconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration_ms")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int DurationMs { get; set; }

        /// <summary>
        /// URL of the audio.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Inputs for generating the audio.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generated_audio_inputs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.GeneratedAudioInputs GeneratedAudioInputs { get; set; }

        /// <summary>
        /// Transcriptions of the audio.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transcriptions")]
        public global::System.Collections.Generic.IList<object>? Transcriptions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GeneratedAudio" /> class.
        /// </summary>
        /// <param name="durationMs">
        /// Duration of the audio in seconds.
        /// </param>
        /// <param name="url">
        /// URL of the audio.
        /// </param>
        /// <param name="generatedAudioInputs">
        /// Inputs for generating the audio.
        /// </param>
        /// <param name="type">
        /// Default Value: generated_audio
        /// </param>
        /// <param name="transcriptions">
        /// Transcriptions of the audio.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GeneratedAudio(
            int durationMs,
            string url,
            global::G.GeneratedAudioInputs generatedAudioInputs,
            string? type,
            global::System.Collections.Generic.IList<object>? transcriptions)
        {
            this.Type = type;
            this.DurationMs = durationMs;
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.GeneratedAudioInputs = generatedAudioInputs ?? throw new global::System.ArgumentNullException(nameof(generatedAudioInputs));
            this.Transcriptions = transcriptions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GeneratedAudio" /> class.
        /// </summary>
        public GeneratedAudio()
        {
        }
    }
}