﻿//HintName: G.Models.RealtimeTranscriptionSessionCreateRequestInputAudioTranscription.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Configuration for input audio transcription. The client can optionally set the language and prompt for transcription, these offer additional guidance to the transcription service.
    /// </summary>
    public sealed partial class RealtimeTranscriptionSessionCreateRequestInputAudioTranscription
    {
        /// <summary>
        /// The model to use for transcription, current options are `gpt-4o-transcribe`, `gpt-4o-mini-transcribe`, and `whisper-1`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.RealtimeTranscriptionSessionCreateRequestInputAudioTranscriptionModelJsonConverter))]
        public global::G.RealtimeTranscriptionSessionCreateRequestInputAudioTranscriptionModel? Model { get; set; }

        /// <summary>
        /// The language of the input audio. Supplying the input language in<br/>
        /// [ISO-639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) (e.g. `en`) format<br/>
        /// will improve accuracy and latency.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        public string? Language { get; set; }

        /// <summary>
        /// An optional text to guide the model's style or continue a previous audio<br/>
        /// segment.<br/>
        /// For `whisper-1`, the [prompt is a list of keywords](/docs/guides/speech-to-text#prompting).<br/>
        /// For `gpt-4o-transcribe` models, the prompt is a free text string, for example "expect words related to technology".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeTranscriptionSessionCreateRequestInputAudioTranscription" /> class.
        /// </summary>
        /// <param name="model">
        /// The model to use for transcription, current options are `gpt-4o-transcribe`, `gpt-4o-mini-transcribe`, and `whisper-1`.
        /// </param>
        /// <param name="language">
        /// The language of the input audio. Supplying the input language in<br/>
        /// [ISO-639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) (e.g. `en`) format<br/>
        /// will improve accuracy and latency.
        /// </param>
        /// <param name="prompt">
        /// An optional text to guide the model's style or continue a previous audio<br/>
        /// segment.<br/>
        /// For `whisper-1`, the [prompt is a list of keywords](/docs/guides/speech-to-text#prompting).<br/>
        /// For `gpt-4o-transcribe` models, the prompt is a free text string, for example "expect words related to technology".
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeTranscriptionSessionCreateRequestInputAudioTranscription(
            global::G.RealtimeTranscriptionSessionCreateRequestInputAudioTranscriptionModel? model,
            string? language,
            string? prompt)
        {
            this.Model = model;
            this.Language = language;
            this.Prompt = prompt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeTranscriptionSessionCreateRequestInputAudioTranscription" /> class.
        /// </summary>
        public RealtimeTranscriptionSessionCreateRequestInputAudioTranscription()
        {
        }
    }
}