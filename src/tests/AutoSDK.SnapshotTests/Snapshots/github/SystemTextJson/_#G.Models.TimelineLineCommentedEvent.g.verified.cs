//HintName: G.Models.TimelineLineCommentedEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Timeline Line Commented Event
    /// </summary>
    public sealed partial class TimelineLineCommentedEvent
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event")]
        public string? Event { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("node_id")]
        public string? NodeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("comments")]
        public global::System.Collections.Generic.IList<global::G.PullRequestReviewComment>? Comments { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TimelineLineCommentedEvent" /> class.
        /// </summary>
        /// <param name="event"></param>
        /// <param name="nodeId"></param>
        /// <param name="comments"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public TimelineLineCommentedEvent(
            string? @event,
            string? nodeId,
            global::System.Collections.Generic.IList<global::G.PullRequestReviewComment>? comments)
        {
            this.Event = @event;
            this.NodeId = nodeId;
            this.Comments = comments;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TimelineLineCommentedEvent" /> class.
        /// </summary>
        public TimelineLineCommentedEvent()
        {
        }
    }
}