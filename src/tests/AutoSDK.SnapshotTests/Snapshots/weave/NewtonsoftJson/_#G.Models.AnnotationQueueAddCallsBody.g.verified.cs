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
        [global::Newtonsoft.Json.JsonProperty("project_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ProjectId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("call_ids", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> CallIds { get; set; } = default!;

        /// <summary>
        /// JSON paths to display to annotators
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("display_fields", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> DisplayFields { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnnotationQueueAddCallsBody" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="callIds"></param>
        /// <param name="displayFields">
        /// JSON paths to display to annotators
        /// </param>
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