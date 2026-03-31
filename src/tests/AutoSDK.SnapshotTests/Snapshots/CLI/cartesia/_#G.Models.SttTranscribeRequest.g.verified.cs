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
        [global::System.Text.Json.Serialization.JsonPropertyName("file")]
        public byte[]? File { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        public string? Filename { get; set; }

        /// <summary>
        /// ID of the model to use for transcription. Use `ink-whisper` for the latest Cartesia Whisper model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// The language of the input audio in ISO-639-1 format. Defaults to `en`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.SttTranscribeRequestLanguageJsonConverter))]
        public global::G.SttTranscribeRequestLanguage? Language { get; set; }

        /// <summary>
        /// The timestamp granularities to populate for this transcription. Currently only `word` level timestamps are supported.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp_granularities[]")]
        public global::System.Collections.Generic.IList<global::G.TimestampGranularity>? TimestampGranularities { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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