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
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Duration of the audio in seconds.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("duration_ms", Required = global::Newtonsoft.Json.Required.Always)]
        public int DurationMs { get; set; } = default!;

        /// <summary>
        /// URL of the audio.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// Inputs for generating the audio.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("generated_audio_inputs", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.GeneratedAudioInputs GeneratedAudioInputs { get; set; } = default!;

        /// <summary>
        /// Transcriptions of the audio.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("transcriptions")]
        public global::System.Collections.Generic.IList<object>? Transcriptions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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