//HintName: G.Models.RealtimeSessionCreateRequestInputAudioTranscription.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Configuration for input audio transcription, defaults to off and can be  set to `null` to turn off once on. Input audio transcription is not native to the model, since the model consumes audio directly. Transcription runs  asynchronously through [OpenAI Whisper transcription](https://platform.openai.com/docs/api-reference/audio/createTranscription) and should be treated as rough guidance rather than the representation understood by the model. The client can optionally set the language and prompt for transcription, these fields will be passed to the Whisper API.
    /// </summary>
    public sealed partial class RealtimeSessionCreateRequestInputAudioTranscription
    {
        /// <summary>
        /// The language of the input audio. Supplying the input language in<br/>
        /// [ISO-639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) (e.g. `en`) format<br/>
        /// will improve accuracy and latency.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        public string? Language { get; set; }

        /// <summary>
        /// The model to use for transcription, `whisper-1` is the only currently <br/>
        /// supported model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

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
        /// Initializes a new instance of the <see cref="RealtimeSessionCreateRequestInputAudioTranscription" /> class.
        /// </summary>
        /// <param name="language">
        /// The language of the input audio. Supplying the input language in<br/>
        /// [ISO-639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) (e.g. `en`) format<br/>
        /// will improve accuracy and latency.
        /// </param>
        /// <param name="model">
        /// The model to use for transcription, `whisper-1` is the only currently <br/>
        /// supported model.
        /// </param>
        /// <param name="prompt">
        /// An optional text to guide the model's style or continue a previous audio<br/>
        /// segment. The [prompt](/docs/guides/speech-to-text#prompting) should match<br/>
        /// the audio language.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeSessionCreateRequestInputAudioTranscription(
            string? language,
            string? model,
            string? prompt)
        {
            this.Language = language;
            this.Model = model;
            this.Prompt = prompt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeSessionCreateRequestInputAudioTranscription" /> class.
        /// </summary>
        public RealtimeSessionCreateRequestInputAudioTranscription()
        {
        }
    }
}