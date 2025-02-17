﻿//HintName: G.Models.AnnotationQueueRunSchema.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AnnotationQueueRunSchema
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("run_id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid RunId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("queue_id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid QueueId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("last_reviewed_time")]
        public global::System.DateTime? LastReviewedTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("added_at")]
        public global::System.DateTime? AddedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid Id { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnnotationQueueRunSchema" /> class.
        /// </summary>
        /// <param name="runId"></param>
        /// <param name="queueId"></param>
        /// <param name="lastReviewedTime"></param>
        /// <param name="addedAt"></param>
        /// <param name="id"></param>
        public AnnotationQueueRunSchema(
            global::System.Guid runId,
            global::System.Guid queueId,
            global::System.Guid id,
            global::System.DateTime? lastReviewedTime,
            global::System.DateTime? addedAt)
        {
            this.RunId = runId;
            this.QueueId = queueId;
            this.Id = id;
            this.LastReviewedTime = lastReviewedTime;
            this.AddedAt = addedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnnotationQueueRunSchema" /> class.
        /// </summary>
        public AnnotationQueueRunSchema()
        {
        }
    }
}