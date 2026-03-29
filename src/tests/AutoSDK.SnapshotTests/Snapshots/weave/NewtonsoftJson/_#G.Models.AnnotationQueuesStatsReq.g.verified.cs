//HintName: G.Models.AnnotationQueuesStatsReq.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Request to get stats for multiple annotation queues.
    /// </summary>
    public sealed partial class AnnotationQueuesStatsReq
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ProjectId { get; set; } = default!;

        /// <summary>
        /// List of queue IDs to get stats for
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("queue_ids", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> QueueIds { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnnotationQueuesStatsReq" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="queueIds">
        /// List of queue IDs to get stats for
        /// </param>
        public AnnotationQueuesStatsReq(
            string projectId,
            global::System.Collections.Generic.IList<string> queueIds)
        {
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.QueueIds = queueIds ?? throw new global::System.ArgumentNullException(nameof(queueIds));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnnotationQueuesStatsReq" /> class.
        /// </summary>
        public AnnotationQueuesStatsReq()
        {
        }
    }
}