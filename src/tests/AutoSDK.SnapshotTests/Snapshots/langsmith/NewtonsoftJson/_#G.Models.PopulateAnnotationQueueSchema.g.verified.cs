//HintName: G.Models.PopulateAnnotationQueueSchema.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PopulateAnnotationQueueSchema
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("queue_id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid QueueId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("session_ids", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::System.Guid> SessionIds { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PopulateAnnotationQueueSchema" /> class.
        /// </summary>
        /// <param name="queueId"></param>
        /// <param name="sessionIds"></param>
        public PopulateAnnotationQueueSchema(
            global::System.Guid queueId,
            global::System.Collections.Generic.IList<global::System.Guid> sessionIds)
        {
            this.QueueId = queueId;
            this.SessionIds = sessionIds ?? throw new global::System.ArgumentNullException(nameof(sessionIds));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PopulateAnnotationQueueSchema" /> class.
        /// </summary>
        public PopulateAnnotationQueueSchema()
        {
        }
    }
}