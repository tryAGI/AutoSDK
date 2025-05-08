//HintName: G.Models.CreateTranscriptionRequest.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateTranscriptionRequest
    {
        /// <summary>
        /// The audio file object (not file name) to transcribe, in one of these formats: flac, mp3, mp4, mpeg, mpga, m4a, ogg, wav, or webm.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required byte[] File { get; set; }

        /// <summary>
        /// The audio file object (not file name) to transcribe, in one of these formats: flac, mp3, mp4, mpeg, mpga, m4a, ogg, wav, or webm.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Filename { get; set; }

        /// <summary>
        /// ID of the model to use. The options are `gpt-4o-transcribe`, `gpt-4o-mini-transcribe`, and `whisper-1` (which is powered by our open source Whisper V2 model).<br/>
        /// Example: gpt-4o-transcribe
        /// </summary>
        /// <example>gpt-4o-transcribe</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<string, global::G.CreateTranscriptionRequestModel?>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.AnyOf<string, global::G.CreateTranscriptionRequestModel?> Model { get; set; }

        /// <summary>
        /// The language of the input audio. Supplying the input language in [ISO-639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) (e.g. `en`) format will improve accuracy and latency.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        public string? Language { get; set; }

        /// <summary>
        /// An optional text to guide the model's style or continue a previous audio segment. The [prompt](/docs/guides/speech-to-text#prompting) should match the audio language.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// The format of the output, in one of these options: `json`, `text`, `srt`, `verbose_json`, or `vtt`. For `gpt-4o-transcribe` and `gpt-4o-mini-transcribe`, the only supported format is `json`.<br/>
        /// Default Value: json
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AudioResponseFormatJsonConverter))]
        public global::G.AudioResponseFormat? ResponseFormat { get; set; }

        /// <summary>
        /// The sampling temperature, between 0 and 1. Higher values like 0.8 will make the output more random, while lower values like 0.2 will make it more focused and deterministic. If set to 0, the model will use [log probability](https://en.wikipedia.org/wiki/Log_probability) to automatically increase the temperature until certain thresholds are hit.<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        public double? Temperature { get; set; }

        /// <summary>
        /// Additional information to include in the transcription response. <br/>
        /// `logprobs` will return the log probabilities of the tokens in the <br/>
        /// response to understand the model's confidence in the transcription. <br/>
        /// `logprobs` only works with response_format set to `json` and only with <br/>
        /// the models `gpt-4o-transcribe` and `gpt-4o-mini-transcribe`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include[]")]
        public global::System.Collections.Generic.IList<global::G.TranscriptionInclude>? Include { get; set; }

        /// <summary>
        /// The timestamp granularities to populate for this transcription. `response_format` must be set `verbose_json` to use timestamp granularities. Either or both of these options are supported: `word`, or `segment`. Note: There is no additional latency for segment timestamps, but generating word timestamps incurs additional latency.<br/>
        /// Default Value: [segment]
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp_granularities[]")]
        public global::System.Collections.Generic.IList<global::G.CreateTranscriptionRequestTimestampGranularitie>? TimestampGranularities { get; set; }

        /// <summary>
        /// If set to true, the model response data will be streamed to the client<br/>
        /// as it is generated using [server-sent events](https://developer.mozilla.org/en-US/docs/Web/API/Server-sent_events/Using_server-sent_events#Event_stream_format). <br/>
        /// See the [Streaming section of the Speech-to-Text guide](/docs/guides/speech-to-text?lang=curl#streaming-transcriptions)<br/>
        /// for more information.<br/>
        /// Note: Streaming is not supported for the `whisper-1` model and will be ignored.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stream")]
        public bool? Stream { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTranscriptionRequest" /> class.
        /// </summary>
        /// <param name="file">
        /// The audio file object (not file name) to transcribe, in one of these formats: flac, mp3, mp4, mpeg, mpga, m4a, ogg, wav, or webm.
        /// </param>
        /// <param name="filename">
        /// The audio file object (not file name) to transcribe, in one of these formats: flac, mp3, mp4, mpeg, mpga, m4a, ogg, wav, or webm.
        /// </param>
        /// <param name="model">
        /// ID of the model to use. The options are `gpt-4o-transcribe`, `gpt-4o-mini-transcribe`, and `whisper-1` (which is powered by our open source Whisper V2 model).<br/>
        /// Example: gpt-4o-transcribe
        /// </param>
        /// <param name="language">
        /// The language of the input audio. Supplying the input language in [ISO-639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) (e.g. `en`) format will improve accuracy and latency.
        /// </param>
        /// <param name="prompt">
        /// An optional text to guide the model's style or continue a previous audio segment. The [prompt](/docs/guides/speech-to-text#prompting) should match the audio language.
        /// </param>
        /// <param name="responseFormat">
        /// The format of the output, in one of these options: `json`, `text`, `srt`, `verbose_json`, or `vtt`. For `gpt-4o-transcribe` and `gpt-4o-mini-transcribe`, the only supported format is `json`.<br/>
        /// Default Value: json
        /// </param>
        /// <param name="temperature">
        /// The sampling temperature, between 0 and 1. Higher values like 0.8 will make the output more random, while lower values like 0.2 will make it more focused and deterministic. If set to 0, the model will use [log probability](https://en.wikipedia.org/wiki/Log_probability) to automatically increase the temperature until certain thresholds are hit.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="include">
        /// Additional information to include in the transcription response. <br/>
        /// `logprobs` will return the log probabilities of the tokens in the <br/>
        /// response to understand the model's confidence in the transcription. <br/>
        /// `logprobs` only works with response_format set to `json` and only with <br/>
        /// the models `gpt-4o-transcribe` and `gpt-4o-mini-transcribe`.
        /// </param>
        /// <param name="timestampGranularities">
        /// The timestamp granularities to populate for this transcription. `response_format` must be set `verbose_json` to use timestamp granularities. Either or both of these options are supported: `word`, or `segment`. Note: There is no additional latency for segment timestamps, but generating word timestamps incurs additional latency.<br/>
        /// Default Value: [segment]
        /// </param>
        /// <param name="stream">
        /// If set to true, the model response data will be streamed to the client<br/>
        /// as it is generated using [server-sent events](https://developer.mozilla.org/en-US/docs/Web/API/Server-sent_events/Using_server-sent_events#Event_stream_format). <br/>
        /// See the [Streaming section of the Speech-to-Text guide](/docs/guides/speech-to-text?lang=curl#streaming-transcriptions)<br/>
        /// for more information.<br/>
        /// Note: Streaming is not supported for the `whisper-1` model and will be ignored.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateTranscriptionRequest(
            byte[] file,
            string filename,
            global::G.AnyOf<string, global::G.CreateTranscriptionRequestModel?> model,
            string? language,
            string? prompt,
            global::G.AudioResponseFormat? responseFormat,
            double? temperature,
            global::System.Collections.Generic.IList<global::G.TranscriptionInclude>? include,
            global::System.Collections.Generic.IList<global::G.CreateTranscriptionRequestTimestampGranularitie>? timestampGranularities,
            bool? stream)
        {
            this.File = file ?? throw new global::System.ArgumentNullException(nameof(file));
            this.Filename = filename ?? throw new global::System.ArgumentNullException(nameof(filename));
            this.Model = model;
            this.Language = language;
            this.Prompt = prompt;
            this.ResponseFormat = responseFormat;
            this.Temperature = temperature;
            this.Include = include;
            this.TimestampGranularities = timestampGranularities;
            this.Stream = stream;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTranscriptionRequest" /> class.
        /// </summary>
        public CreateTranscriptionRequest()
        {
        }
    }
}