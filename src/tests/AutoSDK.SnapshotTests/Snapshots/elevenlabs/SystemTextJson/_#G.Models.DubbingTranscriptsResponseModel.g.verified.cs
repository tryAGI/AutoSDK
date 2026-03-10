//HintName: G.Models.DubbingTranscriptsResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DubbingTranscriptsResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transcript_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.DubbingTranscriptsResponseModelTranscriptFormatJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.DubbingTranscriptsResponseModelTranscriptFormat TranscriptFormat { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("srt")]
        public string? Srt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webvtt")]
        public string? Webvtt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("json")]
        public global::G.DubbingTranscript? Json { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DubbingTranscriptsResponseModel" /> class.
        /// </summary>
        /// <param name="transcriptFormat"></param>
        /// <param name="srt"></param>
        /// <param name="webvtt"></param>
        /// <param name="json"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DubbingTranscriptsResponseModel(
            global::G.DubbingTranscriptsResponseModelTranscriptFormat transcriptFormat,
            string? srt,
            string? webvtt,
            global::G.DubbingTranscript? json)
        {
            this.TranscriptFormat = transcriptFormat;
            this.Srt = srt;
            this.Webvtt = webvtt;
            this.Json = json;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DubbingTranscriptsResponseModel" /> class.
        /// </summary>
        public DubbingTranscriptsResponseModel()
        {
        }
    }
}