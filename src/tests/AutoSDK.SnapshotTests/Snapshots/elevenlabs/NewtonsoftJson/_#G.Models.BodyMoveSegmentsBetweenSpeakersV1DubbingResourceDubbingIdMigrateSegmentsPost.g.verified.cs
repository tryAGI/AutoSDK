//HintName: G.Models.BodyMoveSegmentsBetweenSpeakersV1DubbingResourceDubbingIdMigrateSegmentsPost.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyMoveSegmentsBetweenSpeakersV1DubbingResourceDubbingIdMigrateSegmentsPost
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("segment_ids", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> SegmentIds { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("speaker_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string SpeakerId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyMoveSegmentsBetweenSpeakersV1DubbingResourceDubbingIdMigrateSegmentsPost" /> class.
        /// </summary>
        /// <param name="segmentIds"></param>
        /// <param name="speakerId"></param>
        public BodyMoveSegmentsBetweenSpeakersV1DubbingResourceDubbingIdMigrateSegmentsPost(
            global::System.Collections.Generic.IList<string> segmentIds,
            string speakerId)
        {
            this.SegmentIds = segmentIds ?? throw new global::System.ArgumentNullException(nameof(segmentIds));
            this.SpeakerId = speakerId ?? throw new global::System.ArgumentNullException(nameof(speakerId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyMoveSegmentsBetweenSpeakersV1DubbingResourceDubbingIdMigrateSegmentsPost" /> class.
        /// </summary>
        public BodyMoveSegmentsBetweenSpeakersV1DubbingResourceDubbingIdMigrateSegmentsPost()
        {
        }
    }
}