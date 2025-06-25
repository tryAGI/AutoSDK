//HintName: G.Models.VideoMutedSegment.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VideoMutedSegment
    {
        /// <summary>
        /// The duration of the muted segment, in seconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Duration { get; set; }

        /// <summary>
        /// The offset, in seconds, from the beginning of the video to where the muted segment begins.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("offset")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Offset { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoMutedSegment" /> class.
        /// </summary>
        /// <param name="duration">
        /// The duration of the muted segment, in seconds.
        /// </param>
        /// <param name="offset">
        /// The offset, in seconds, from the beginning of the video to where the muted segment begins.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VideoMutedSegment(
            int duration,
            int offset)
        {
            this.Duration = duration;
            this.Offset = offset;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoMutedSegment" /> class.
        /// </summary>
        public VideoMutedSegment()
        {
        }
    }
}