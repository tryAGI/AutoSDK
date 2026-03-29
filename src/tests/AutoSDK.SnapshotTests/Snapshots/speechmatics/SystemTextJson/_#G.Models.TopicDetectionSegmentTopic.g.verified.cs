//HintName: G.Models.TopicDetectionSegmentTopic.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Represents a topic and its associated information.
    /// </summary>
    public sealed partial class TopicDetectionSegmentTopic
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("topic")]
        public string? Topic { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TopicDetectionSegmentTopic" /> class.
        /// </summary>
        /// <param name="topic"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TopicDetectionSegmentTopic(
            string? topic)
        {
            this.Topic = topic;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TopicDetectionSegmentTopic" /> class.
        /// </summary>
        public TopicDetectionSegmentTopic()
        {
        }
    }
}