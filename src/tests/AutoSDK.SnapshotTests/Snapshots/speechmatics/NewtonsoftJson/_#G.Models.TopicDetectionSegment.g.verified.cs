//HintName: G.Models.TopicDetectionSegment.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Represents a segment of text and its associated topic information.
    /// </summary>
    public sealed partial class TopicDetectionSegment
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text")]
        public string? Text { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("start_time")]
        public float? StartTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("end_time")]
        public float? EndTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("topics")]
        public global::System.Collections.Generic.IList<global::G.TopicDetectionSegmentTopic>? Topics { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TopicDetectionSegment" /> class.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// <param name="topics"></param>
        public TopicDetectionSegment(
            string? text,
            float? startTime,
            float? endTime,
            global::System.Collections.Generic.IList<global::G.TopicDetectionSegmentTopic>? topics)
        {
            this.Text = text;
            this.StartTime = startTime;
            this.EndTime = endTime;
            this.Topics = topics;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TopicDetectionSegment" /> class.
        /// </summary>
        public TopicDetectionSegment()
        {
        }
    }
}