//HintName: G.Models.DubbedSegment.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DubbedSegment
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("start_time", Required = global::Newtonsoft.Json.Required.Always)]
        public double StartTime { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("end_time", Required = global::Newtonsoft.Json.Required.Always)]
        public double EndTime { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text")]
        public string? Text { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("subtitles", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.SegmentSubtitleFrame> Subtitles { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("audio_stale", Required = global::Newtonsoft.Json.Required.Always)]
        public bool AudioStale { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("media_ref")]
        public global::G.DubbingMediaReference? MediaRef { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DubbedSegment" /> class.
        /// </summary>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// <param name="subtitles"></param>
        /// <param name="audioStale"></param>
        /// <param name="text"></param>
        /// <param name="mediaRef"></param>
        public DubbedSegment(
            double startTime,
            double endTime,
            global::System.Collections.Generic.IList<global::G.SegmentSubtitleFrame> subtitles,
            bool audioStale,
            string? text,
            global::G.DubbingMediaReference? mediaRef)
        {
            this.StartTime = startTime;
            this.EndTime = endTime;
            this.Text = text;
            this.Subtitles = subtitles ?? throw new global::System.ArgumentNullException(nameof(subtitles));
            this.AudioStale = audioStale;
            this.MediaRef = mediaRef;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DubbedSegment" /> class.
        /// </summary>
        public DubbedSegment()
        {
        }
    }
}