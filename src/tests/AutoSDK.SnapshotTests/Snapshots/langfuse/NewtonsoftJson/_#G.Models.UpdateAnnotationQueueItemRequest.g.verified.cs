//HintName: G.Models.UpdateAnnotationQueueItemRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateAnnotationQueueItemRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status")]
        public global::G.AnnotationQueueStatus? Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAnnotationQueueItemRequest" /> class.
        /// </summary>
        /// <param name="status"></param>
        public UpdateAnnotationQueueItemRequest(
            global::G.AnnotationQueueStatus? status)
        {
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAnnotationQueueItemRequest" /> class.
        /// </summary>
        public UpdateAnnotationQueueItemRequest()
        {
        }
    }
}