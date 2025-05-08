//HintName: G.Models.RealtimeTranscriptionSessionCreateResponseInputAudioTranscription.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Configuration of the transcription model.
    /// </summary>
    public sealed partial class RealtimeTranscriptionSessionCreateResponseInputAudioTranscription
    {
        /// <summary>
        /// The model to use for transcription. Can be `gpt-4o-transcribe`, `gpt-4o-mini-transcribe`, or `whisper-1`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.RealtimeTranscriptionSessionCreateResponseInputAudioTranscriptionModelJsonConverter))]
        public global::G.RealtimeTranscriptionSessionCreateResponseInputAudioTranscriptionModel? Model { get; set; }

        /// <summary>
        /// The language of the input audio. Supplying the input language in<br/>
        /// [ISO-639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) (e.g. `en`) format<br/>
        /// will improve accuracy and latency.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        public string? Language { get; set; }

        /// <summary>
        /// An optional text to guide the model's style or continue a previous audio<br/>
        /// segment. The [prompt](/docs/guides/speech-to-text#prompting) should match<br/>
        /// the audio language.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeTranscriptionSessionCreateResponseInputAudioTranscription" /> class.
        /// </summary>
        /// <param name="model">
        /// The model to use for transcription. Can be `gpt-4o-transcribe`, `gpt-4o-mini-transcribe`, or `whisper-1`.
        /// </param>
        /// <param name="language">
        /// The language of the input audio. Supplying the input language in<br/>
        /// [ISO-639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) (e.g. `en`) format<br/>
        /// will improve accuracy and latency.
        /// </param>
        /// <param name="prompt">
        /// An optional text to guide the model's style or continue a previous audio<br/>
        /// segment. The [prompt](/docs/guides/speech-to-text#prompting) should match<br/>
        /// the audio language.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeTranscriptionSessionCreateResponseInputAudioTranscription(
            global::G.RealtimeTranscriptionSessionCreateResponseInputAudioTranscriptionModel? model,
            string? language,
            string? prompt)
        {
            this.Model = model;
            this.Language = language;
            this.Prompt = prompt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeTranscriptionSessionCreateResponseInputAudioTranscription" /> class.
        /// </summary>
        public RealtimeTranscriptionSessionCreateResponseInputAudioTranscription()
        {
        }
    }
}