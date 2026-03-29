//HintName: G.Models.CreateAnnotationQueueItemRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateAnnotationQueueItemRequest
    {
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
        public global::G.AnnotationQueueStatus? Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAnnotationQueueItemRequest" /> class.
        /// </summary>
        /// <param name="objectId"></param>
        /// <param name="objectType"></param>
        /// <param name="status"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateAnnotationQueueItemRequest(
            string objectId,
            global::G.AnnotationQueueObjectType objectType,
            global::G.AnnotationQueueStatus? status)
        {
            this.ObjectId = objectId ?? throw new global::System.ArgumentNullException(nameof(objectId));
            this.ObjectType = objectType;
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAnnotationQueueItemRequest" /> class.
        /// </summary>
        public CreateAnnotationQueueItemRequest()
        {
        }
    }
}