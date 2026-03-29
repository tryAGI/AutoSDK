//HintName: G.Models.AnnotationQueueItemProgressUpdateBody.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Request body for updating annotation progress (queue_id and item_id come from path).<br/>
    /// Note: wb_user_id is not included in the body - it's set server-side from the authenticated session.
    /// </summary>
    public sealed partial class AnnotationQueueItemProgressUpdateBody
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ProjectId { get; set; } = default!;

        /// <summary>
        /// New state: 'in_progress', 'completed', or 'skipped'
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("annotation_state", Required = global::Newtonsoft.Json.Required.Always)]
        public string AnnotationState { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnnotationQueueItemProgressUpdateBody" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="annotationState">
        /// New state: 'in_progress', 'completed', or 'skipped'
        /// </param>
        public AnnotationQueueItemProgressUpdateBody(
            string projectId,
            string annotationState)
        {
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.AnnotationState = annotationState ?? throw new global::System.ArgumentNullException(nameof(annotationState));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnnotationQueueItemProgressUpdateBody" /> class.
        /// </summary>
        public AnnotationQueueItemProgressUpdateBody()
        {
        }
    }
}