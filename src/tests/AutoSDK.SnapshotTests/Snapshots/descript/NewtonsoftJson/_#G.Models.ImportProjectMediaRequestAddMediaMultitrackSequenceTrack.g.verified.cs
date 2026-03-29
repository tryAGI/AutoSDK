//HintName: G.Models.ImportProjectMediaRequestAddMediaMultitrackSequenceTrack.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ImportProjectMediaRequestAddMediaMultitrackSequenceTrack
    {
        /// <summary>
        /// Media reference ID (display name) of the media to include in this track<br/>
        /// Example: Recordings/camera1.mp4
        /// </summary>
        /// <example>Recordings/camera1.mp4</example>
        [global::Newtonsoft.Json.JsonProperty("media", Required = global::Newtonsoft.Json.Required.Always)]
        public string Media { get; set; } = default!;

        /// <summary>
        /// Optional time offset in seconds for syncing this track<br/>
        /// Default Value: 0<br/>
        /// Example: 50
        /// </summary>
        /// <example>50</example>
        [global::Newtonsoft.Json.JsonProperty("offset")]
        public float? Offset { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImportProjectMediaRequestAddMediaMultitrackSequenceTrack" /> class.
        /// </summary>
        /// <param name="media">
        /// Media reference ID (display name) of the media to include in this track<br/>
        /// Example: Recordings/camera1.mp4
        /// </param>
        /// <param name="offset">
        /// Optional time offset in seconds for syncing this track<br/>
        /// Default Value: 0<br/>
        /// Example: 50
        /// </param>
        public ImportProjectMediaRequestAddMediaMultitrackSequenceTrack(
            string media,
            float? offset)
        {
            this.Media = media ?? throw new global::System.ArgumentNullException(nameof(media));
            this.Offset = offset;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImportProjectMediaRequestAddMediaMultitrackSequenceTrack" /> class.
        /// </summary>
        public ImportProjectMediaRequestAddMediaMultitrackSequenceTrack()
        {
        }
    }
}