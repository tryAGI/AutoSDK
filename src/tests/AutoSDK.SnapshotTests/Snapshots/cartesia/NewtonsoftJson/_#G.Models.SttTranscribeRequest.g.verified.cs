//HintName: G.Models.SttTranscribeRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SttTranscribeRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("file")]
        public byte[]? File { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("filename")]
        public string? Filename { get; set; }

        /// <summary>
        /// ID of the model to use for transcription. Use `ink-whisper` for the latest Cartesia Whisper model.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model")]
        public string? Model { get; set; }

        /// <summary>
        /// The language of the input audio in ISO-639-1 format. Defaults to `en`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("language")]
        public global::G.SttTranscribeRequestLanguage? Language { get; set; }

        /// <summary>
        /// The timestamp granularities to populate for this transcription. Currently only `word` level timestamps are supported.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("timestamp_granularities[]")]
        public global::System.Collections.Generic.IList<global::G.TimestampGranularity>? TimestampGranularities { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SttTranscribeRequest" /> class.
        /// </summary>
        /// <param name="file"></param>
        /// <param name="filename"></param>
        /// <param name="model">
        /// ID of the model to use for transcription. Use `ink-whisper` for the latest Cartesia Whisper model.
        /// </param>
        /// <param name="language">
        /// The language of the input audio in ISO-639-1 format. Defaults to `en`.
        /// </param>
        /// <param name="timestampGranularities">
        /// The timestamp granularities to populate for this transcription. Currently only `word` level timestamps are supported.
        /// </param>
        public SttTranscribeRequest(
            byte[]? file,
            string? filename,
            string? model,
            global::G.SttTranscribeRequestLanguage? language,
            global::System.Collections.Generic.IList<global::G.TimestampGranularity>? timestampGranularities)
        {
            this.File = file;
            this.Filename = filename;
            this.Model = model;
            this.Language = language;
            this.TimestampGranularities = timestampGranularities;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SttTranscribeRequest" /> class.
        /// </summary>
        public SttTranscribeRequest()
        {
        }
    }
}