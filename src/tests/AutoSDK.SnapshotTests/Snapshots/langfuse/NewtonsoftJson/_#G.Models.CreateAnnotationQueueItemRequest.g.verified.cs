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
        [global::Newtonsoft.Json.JsonProperty("objectId", Required = global::Newtonsoft.Json.Required.Always)]
        public string ObjectId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("objectType", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.AnnotationQueueObjectTypeJsonConverter))]
        public global::G.AnnotationQueueObjectType ObjectType { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.AnnotationQueueStatusJsonConverter))]
        public global::G.AnnotationQueueStatus? Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAnnotationQueueItemRequest" /> class.
        /// </summary>
        /// <param name="objectId"></param>
        /// <param name="objectType"></param>
        /// <param name="status"></param>
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