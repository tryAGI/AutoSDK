//HintName: G.Models.CreateAnnotationQueueAssignmentResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateAnnotationQueueAssignmentResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("userId", Required = global::Newtonsoft.Json.Required.Always)]
        public string UserId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("queueId", Required = global::Newtonsoft.Json.Required.Always)]
        public string QueueId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("projectId", Required = global::Newtonsoft.Json.Required.Always)]
        public string ProjectId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAnnotationQueueAssignmentResponse" /> class.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="queueId"></param>
        /// <param name="projectId"></param>
        public CreateAnnotationQueueAssignmentResponse(
            string userId,
            string queueId,
            string projectId)
        {
            this.UserId = userId ?? throw new global::System.ArgumentNullException(nameof(userId));
            this.QueueId = queueId ?? throw new global::System.ArgumentNullException(nameof(queueId));
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAnnotationQueueAssignmentResponse" /> class.
        /// </summary>
        public CreateAnnotationQueueAssignmentResponse()
        {
        }
    }
}