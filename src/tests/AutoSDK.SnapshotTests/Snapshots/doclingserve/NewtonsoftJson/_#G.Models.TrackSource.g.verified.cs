//HintName: G.Models.TrackSource.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Source metadata for a cue extracted from a media track.<br/>
    /// A `TrackSource` instance identifies a cue in a media track (audio, video, subtitles, screen-recording captions,<br/>
    /// etc.). A *cue* here refers to any discrete segment that was pulled out of the original asset, e.g., a subtitle<br/>
    /// block, an audio clip, or a timed marker in a screen-recording.
    /// </summary>
    public sealed partial class TrackSource
    {
        /// <summary>
        /// Identifies this type of source.<br/>
        /// Default Value: track
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("kind")]
        public string? Kind { get; set; }

        /// <summary>
        /// Start time offset of the track cue in seconds
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("start_time", Required = global::Newtonsoft.Json.Required.Always)]
        public double StartTime { get; set; } = default!;

        /// <summary>
        /// End time offset of the track cue in seconds
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("end_time", Required = global::Newtonsoft.Json.Required.Always)]
        public double EndTime { get; set; } = default!;

        /// <summary>
        /// An identifier of the cue
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("identifier")]
        public string? Identifier { get; set; }

        /// <summary>
        /// The name of the voice in this track (the speaker)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("voice")]
        public string? Voice { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TrackSource" /> class.
        /// </summary>
        /// <param name="startTime">
        /// Start time offset of the track cue in seconds
        /// </param>
        /// <param name="endTime">
        /// End time offset of the track cue in seconds
        /// </param>
        /// <param name="kind">
        /// Identifies this type of source.<br/>
        /// Default Value: track
        /// </param>
        /// <param name="identifier">
        /// An identifier of the cue
        /// </param>
        /// <param name="voice">
        /// The name of the voice in this track (the speaker)
        /// </param>
        public TrackSource(
            double startTime,
            double endTime,
            string? kind,
            string? identifier,
            string? voice)
        {
            this.Kind = kind;
            this.StartTime = startTime;
            this.EndTime = endTime;
            this.Identifier = identifier;
            this.Voice = voice;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TrackSource" /> class.
        /// </summary>
        public TrackSource()
        {
        }
    }
}