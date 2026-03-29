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
        [global::System.Text.Json.Serialization.JsonPropertyName("media")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Media { get; set; }

        /// <summary>
        /// Optional time offset in seconds for syncing this track<br/>
        /// Default Value: 0<br/>
        /// Example: 50
        /// </summary>
        /// <example>50</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("offset")]
        public float? Offset { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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