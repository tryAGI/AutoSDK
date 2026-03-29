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
        [global::System.Text.Json.Serialization.JsonPropertyName("userId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("queueId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string QueueId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAnnotationQueueAssignmentResponse" /> class.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="queueId"></param>
        /// <param name="projectId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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