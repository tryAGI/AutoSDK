//HintName: G.Models.AnnotationQueueAddCallsBody.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Request body for adding calls to an annotation queue (queue_id comes from path).
    /// </summary>
    public sealed partial class AnnotationQueueAddCallsBody
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("call_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> CallIds { get; set; }

        /// <summary>
        /// JSON paths to display to annotators
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("display_fields")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> DisplayFields { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnnotationQueueAddCallsBody" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="callIds"></param>
        /// <param name="displayFields">
        /// JSON paths to display to annotators
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnnotationQueueAddCallsBody(
            string projectId,
            global::System.Collections.Generic.IList<string> callIds,
            global::System.Collections.Generic.IList<string> displayFields)
        {
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.CallIds = callIds ?? throw new global::System.ArgumentNullException(nameof(callIds));
            this.DisplayFields = displayFields ?? throw new global::System.ArgumentNullException(nameof(displayFields));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnnotationQueueAddCallsBody" /> class.
        /// </summary>
        public AnnotationQueueAddCallsBody()
        {
        }
    }
}