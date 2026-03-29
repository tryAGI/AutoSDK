//HintName: G.Models.AnnotationQueueItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AnnotationQueueItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("queueId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string QueueId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("objectId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ObjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("objectType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnnotationQueueObjectTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.AnnotationQueueObjectType ObjectType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnnotationQueueStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.AnnotationQueueStatus Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completedAt")]
        public global::System.DateTime? CompletedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnnotationQueueItem" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="queueId"></param>
        /// <param name="objectId"></param>
        /// <param name="objectType"></param>
        /// <param name="status"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="completedAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnnotationQueueItem(
            string id,
            string queueId,
            string objectId,
            global::G.AnnotationQueueObjectType objectType,
            global::G.AnnotationQueueStatus status,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            global::System.DateTime? completedAt)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.QueueId = queueId ?? throw new global::System.ArgumentNullException(nameof(queueId));
            this.ObjectId = objectId ?? throw new global::System.ArgumentNullException(nameof(objectId));
            this.ObjectType = objectType;
            this.Status = status;
            this.CompletedAt = completedAt;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnnotationQueueItem" /> class.
        /// </summary>
        public AnnotationQueueItem()
        {
        }
    }
}