//HintName: G.Models.CreateTranscriptionRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateTranscriptionRequest
    {
        /// <summary>
        /// The audio file object (not file name) to transcribe, in one of these formats: flac, mp3, mp4, mpeg, mpga, m4a, ogg, wav, or webm.<br/>
        /// Either a file or a URL must be provided. Note that the file field is not supported in Batch API requests.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("file")]
        public byte[]? File { get; set; }

        /// <summary>
        /// The audio file object (not file name) to transcribe, in one of these formats: flac, mp3, mp4, mpeg, mpga, m4a, ogg, wav, or webm.<br/>
        /// Either a file or a URL must be provided. Note that the file field is not supported in Batch API requests.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("filename")]
        public string? Filename { get; set; }

        /// <summary>
        /// The audio URL to translate/transcribe (supports Base64URL).<br/>
        /// Either a file or a URL must be provided. For Batch API requests, the URL field is required since the file field is not supported.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url")]
        public string? Url { get; set; }

        /// <summary>
        /// ID of the model to use. `whisper-large-v3` and `whisper-large-v3-turbo` are currently available.<br/>
        /// Example: whisper-large-v3-turbo
        /// </summary>
        /// <example>whisper-large-v3-turbo</example>
        [global::Newtonsoft.Json.JsonProperty("model", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AnyOf<string, global::G.CreateTranscriptionRequestModel?> Model { get; set; } = default!;

        /// <summary>
        /// The language of the input audio. Supplying the input language in [ISO-639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) format will improve accuracy and latency.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("language")]
        public global::G.AnyOf<string, global::G.CreateTranscriptionRequestLanguage?>? Language { get; set; }

        /// <summary>
        /// An optional text to guide the model's style or continue a previous audio segment. The [prompt](/docs/speech-text) should match the audio language.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// The format of the transcript output, in one of these options: `json`, `text`, or `verbose_json`.<br/>
        /// Default Value: json
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("response_format")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.CreateTranscriptionRequestResponseFormatJsonConverter))]
        public global::G.CreateTranscriptionRequestResponseFormat? ResponseFormat { get; set; }

        /// <summary>
        /// The sampling temperature, between 0 and 1. Higher values like 0.8 will make the output more random, while lower values like 0.2 will make it more focused and deterministic. If set to 0, the model will use [log probability](https://en.wikipedia.org/wiki/Log_probability) to automatically increase the temperature until certain thresholds are hit.<br/>
        /// Default Value: 0
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("temperature")]
        public double? Temperature { get; set; }

        /// <summary>
        /// The timestamp granularities to populate for this transcription. `response_format` must be set `verbose_json` to use timestamp granularities. Either or both of these options are supported: `word`, or `segment`. Note: There is no additional latency for segment timestamps, but generating word timestamps incurs additional latency.<br/>
        /// Default Value: [segment]
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("timestamp_granularities")]
        public global::System.Collections.Generic.IList<global::G.CreateTranscriptionRequestTimestampGranularitie>? TimestampGranularities { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTranscriptionRequest" /> class.
        /// </summary>
        /// <param name="model">
        /// ID of the model to use. `whisper-large-v3` and `whisper-large-v3-turbo` are currently available.<br/>
        /// Example: whisper-large-v3-turbo
        /// </param>
        /// <param name="file">
        /// The audio file object (not file name) to transcribe, in one of these formats: flac, mp3, mp4, mpeg, mpga, m4a, ogg, wav, or webm.<br/>
        /// Either a file or a URL must be provided. Note that the file field is not supported in Batch API requests.
        /// </param>
        /// <param name="filename">
        /// The audio file object (not file name) to transcribe, in one of these formats: flac, mp3, mp4, mpeg, mpga, m4a, ogg, wav, or webm.<br/>
        /// Either a file or a URL must be provided. Note that the file field is not supported in Batch API requests.
        /// </param>
        /// <param name="url">
        /// The audio URL to translate/transcribe (supports Base64URL).<br/>
        /// Either a file or a URL must be provided. For Batch API requests, the URL field is required since the file field is not supported.
        /// </param>
        /// <param name="language">
        /// The language of the input audio. Supplying the input language in [ISO-639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) format will improve accuracy and latency.
        /// </param>
        /// <param name="prompt">
        /// An optional text to guide the model's style or continue a previous audio segment. The [prompt](/docs/speech-text) should match the audio language.
        /// </param>
        /// <param name="responseFormat">
        /// The format of the transcript output, in one of these options: `json`, `text`, or `verbose_json`.<br/>
        /// Default Value: json
        /// </param>
        /// <param name="temperature">
        /// The sampling temperature, between 0 and 1. Higher values like 0.8 will make the output more random, while lower values like 0.2 will make it more focused and deterministic. If set to 0, the model will use [log probability](https://en.wikipedia.org/wiki/Log_probability) to automatically increase the temperature until certain thresholds are hit.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="timestampGranularities">
        /// The timestamp granularities to populate for this transcription. `response_format` must be set `verbose_json` to use timestamp granularities. Either or both of these options are supported: `word`, or `segment`. Note: There is no additional latency for segment timestamps, but generating word timestamps incurs additional latency.<br/>
        /// Default Value: [segment]
        /// </param>
        public CreateTranscriptionRequest(
            global::G.AnyOf<string, global::G.CreateTranscriptionRequestModel?> model,
            byte[]? file,
            string? filename,
            string? url,
            global::G.AnyOf<string, global::G.CreateTranscriptionRequestLanguage?>? language,
            string? prompt,
            global::G.CreateTranscriptionRequestResponseFormat? responseFormat,
            double? temperature,
            global::System.Collections.Generic.IList<global::G.CreateTranscriptionRequestTimestampGranularitie>? timestampGranularities)
        {
            this.File = file;
            this.Filename = filename;
            this.Url = url;
            this.Model = model;
            this.Language = language;
            this.Prompt = prompt;
            this.ResponseFormat = responseFormat;
            this.Temperature = temperature;
            this.TimestampGranularities = timestampGranularities;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTranscriptionRequest" /> class.
        /// </summary>
        public CreateTranscriptionRequest()
        {
        }
    }
}