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
        [global::Newtonsoft.Json.JsonProperty("transcript_format", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.DubbingTranscriptsResponseModelTranscriptFormatJsonConverter))]
        public global::G.DubbingTranscriptsResponseModelTranscriptFormat TranscriptFormat { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("srt")]
        public string? Srt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("webvtt")]
        public string? Webvtt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("json")]
        public global::G.DubbingTranscript? Json { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DubbingTranscriptsResponseModel" /> class.
        /// </summary>
        /// <param name="transcriptFormat"></param>
        /// <param name="srt"></param>
        /// <param name="webvtt"></param>
        /// <param name="json"></param>
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