//HintName: G.Models.AnnotationQueueStatsSchema.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Statistics for a single annotation queue.
    /// </summary>
    public sealed partial class AnnotationQueueStatsSchema
    {
        /// <summary>
        /// The queue ID
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("queue_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string QueueId { get; set; } = default!;

        /// <summary>
        /// Total number of items in the queue
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_items", Required = global::Newtonsoft.Json.Required.Always)]
        public int TotalItems { get; set; } = default!;

        /// <summary>
        /// Number of items completed or skipped by at least one annotator
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("completed_items", Required = global::Newtonsoft.Json.Required.Always)]
        public int CompletedItems { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnnotationQueueStatsSchema" /> class.
        /// </summary>
        /// <param name="queueId">
        /// The queue ID
        /// </param>
        /// <param name="totalItems">
        /// Total number of items in the queue
        /// </param>
        /// <param name="completedItems">
        /// Number of items completed or skipped by at least one annotator
        /// </param>
        public AnnotationQueueStatsSchema(
            string queueId,
            int totalItems,
            int completedItems)
        {
            this.QueueId = queueId ?? throw new global::System.ArgumentNullException(nameof(queueId));
            this.TotalItems = totalItems;
            this.CompletedItems = completedItems;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnnotationQueueStatsSchema" /> class.
        /// </summary>
        public AnnotationQueueStatsSchema()
        {
        }
    }
}