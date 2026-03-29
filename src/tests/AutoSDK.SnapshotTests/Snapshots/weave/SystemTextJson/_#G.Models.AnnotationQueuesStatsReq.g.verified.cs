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
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectId { get; set; }

        /// <summary>
        /// List of queue IDs to get stats for
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("queue_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> QueueIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnnotationQueuesStatsReq" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="queueIds">
        /// List of queue IDs to get stats for
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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