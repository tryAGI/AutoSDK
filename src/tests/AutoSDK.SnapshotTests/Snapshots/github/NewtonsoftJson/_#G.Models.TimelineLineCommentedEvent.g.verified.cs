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
        [global::Newtonsoft.Json.JsonProperty("event")]
        public string? Event { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("node_id")]
        public string? NodeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("comments")]
        public global::System.Collections.Generic.IList<global::G.PullRequestReviewComment>? Comments { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TimelineLineCommentedEvent" /> class.
        /// </summary>
        /// <param name="event"></param>
        /// <param name="nodeId"></param>
        /// <param name="comments"></param>
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