//HintName: G.Models.AnnotationQueueRunSchema.g.cs

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
        [global::System.Text.Json.Serialization.JsonPropertyName("run_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid RunId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("queue_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid QueueId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_reviewed_time")]
        public global::System.DateTime? LastReviewedTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("added_at")]
        public global::System.DateTime? AddedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnnotationQueueRunSchema" /> class.
        /// </summary>
        /// <param name="runId"></param>
        /// <param name="queueId"></param>
        /// <param name="lastReviewedTime"></param>
        /// <param name="addedAt"></param>
        /// <param name="id"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
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