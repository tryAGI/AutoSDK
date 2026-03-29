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
        [global::System.Text.Json.Serialization.JsonPropertyName("queue_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string QueueId { get; set; }

        /// <summary>
        /// Total number of items in the queue
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_items")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalItems { get; set; }

        /// <summary>
        /// Number of items completed or skipped by at least one annotator
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completed_items")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CompletedItems { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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