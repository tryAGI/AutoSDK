//HintName: G.Models.TimelineCommitCommentedEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Timeline Commit Commented Event
    /// </summary>
    public sealed partial class TimelineCommitCommentedEvent
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
        [global::Newtonsoft.Json.JsonProperty("commit_id")]
        public string? CommitId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("comments")]
        public global::System.Collections.Generic.IList<global::G.CommitComment>? Comments { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TimelineCommitCommentedEvent" /> class.
        /// </summary>
        /// <param name="event"></param>
        /// <param name="nodeId"></param>
        /// <param name="commitId"></param>
        /// <param name="comments"></param>
        public TimelineCommitCommentedEvent(
            string? @event,
            string? nodeId,
            string? commitId,
            global::System.Collections.Generic.IList<global::G.CommitComment>? comments)
        {
            this.Event = @event;
            this.NodeId = nodeId;
            this.CommitId = commitId;
            this.Comments = comments;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TimelineCommitCommentedEvent" /> class.
        /// </summary>
        public TimelineCommitCommentedEvent()
        {
        }
    }
}