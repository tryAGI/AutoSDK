//HintName: G.Models.SubmitTranscriptionJobRequest2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SubmitTranscriptionJobRequest2
    {
        /// <summary>
        /// Audio/video file to transcribe (max 2GB)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("media")]
        public byte[]? Media { get; set; }

        /// <summary>
        /// Audio/video file to transcribe (max 2GB)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("medianame")]
        public string? Medianame { get; set; }

        /// <summary>
        /// Options for transcription job submission
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("options")]
        public global::G.TranscriptionJobOptions? Options { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SubmitTranscriptionJobRequest2" /> class.
        /// </summary>
        /// <param name="media">
        /// Audio/video file to transcribe (max 2GB)
        /// </param>
        /// <param name="medianame">
        /// Audio/video file to transcribe (max 2GB)
        /// </param>
        /// <param name="options">
        /// Options for transcription job submission
        /// </param>
        public SubmitTranscriptionJobRequest2(
            byte[]? media,
            string? medianame,
            global::G.TranscriptionJobOptions? options)
        {
            this.Media = media;
            this.Medianame = medianame;
            this.Options = options;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubmitTranscriptionJobRequest2" /> class.
        /// </summary>
        public SubmitTranscriptionJobRequest2()
        {
        }
    }
}