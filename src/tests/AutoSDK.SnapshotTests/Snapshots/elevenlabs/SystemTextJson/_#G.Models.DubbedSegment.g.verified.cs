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
        [global::System.Text.Json.Serialization.JsonPropertyName("start_time")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double StartTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_time")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double EndTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? Text { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_stale")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool AudioStale { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("media_ref")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.DubbingMediaReference MediaRef { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DubbedSegment" /> class.
        /// </summary>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// <param name="text"></param>
        /// <param name="audioStale"></param>
        /// <param name="mediaRef"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DubbedSegment(
            double startTime,
            double endTime,
            string? text,
            bool audioStale,
            global::G.DubbingMediaReference mediaRef)
        {
            this.StartTime = startTime;
            this.EndTime = endTime;
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.AudioStale = audioStale;
            this.MediaRef = mediaRef ?? throw new global::System.ArgumentNullException(nameof(mediaRef));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DubbedSegment" /> class.
        /// </summary>
        public DubbedSegment()
        {
        }
    }
}