//HintName: G.Models.TimestampSegment.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TimestampSegment
    {
        /// <summary>
        /// Start time of the segment in seconds from the beginning of the audio.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Start { get; set; }

        /// <summary>
        /// End time of the segment in seconds from the beginning of the audio.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double End { get; set; }

        /// <summary>
        /// The transcribed word or phrase for this time segment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transcript")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Transcript { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TimestampSegment" /> class.
        /// </summary>
        /// <param name="start">
        /// Start time of the segment in seconds from the beginning of the audio.
        /// </param>
        /// <param name="end">
        /// End time of the segment in seconds from the beginning of the audio.
        /// </param>
        /// <param name="transcript">
        /// The transcribed word or phrase for this time segment.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TimestampSegment(
            double start,
            double end,
            string transcript)
        {
            this.Start = start;
            this.End = end;
            this.Transcript = transcript ?? throw new global::System.ArgumentNullException(nameof(transcript));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TimestampSegment" /> class.
        /// </summary>
        public TimestampSegment()
        {
        }
    }
}