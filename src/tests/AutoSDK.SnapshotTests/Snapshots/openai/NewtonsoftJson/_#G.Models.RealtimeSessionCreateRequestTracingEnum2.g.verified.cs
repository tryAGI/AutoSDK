//HintName: G.Models.RealtimeSessionCreateRequestTracingEnum2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Granular configuration for tracing.
    /// </summary>
    public sealed partial class RealtimeSessionCreateRequestTracingEnum2
    {
        /// <summary>
        /// The name of the workflow to attach to this trace. This is used to <br/>
        /// name the trace in the traces dashboard.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("workflow_name")]
        public string? WorkflowName { get; set; }

        /// <summary>
        /// The group id to attach to this trace to enable filtering and <br/>
        /// grouping in the traces dashboard.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("group_id")]
        public string? GroupId { get; set; }

        /// <summary>
        /// The arbitrary metadata to attach to this trace to enable <br/>
        /// filtering in the traces dashboard.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeSessionCreateRequestTracingEnum2" /> class.
        /// </summary>
        /// <param name="workflowName">
        /// The name of the workflow to attach to this trace. This is used to <br/>
        /// name the trace in the traces dashboard.
        /// </param>
        /// <param name="groupId">
        /// The group id to attach to this trace to enable filtering and <br/>
        /// grouping in the traces dashboard.
        /// </param>
        /// <param name="metadata">
        /// The arbitrary metadata to attach to this trace to enable <br/>
        /// filtering in the traces dashboard.
        /// </param>
        public RealtimeSessionCreateRequestTracingEnum2(
            string? workflowName,
            string? groupId,
            object? metadata)
        {
            this.WorkflowName = workflowName;
            this.GroupId = groupId;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeSessionCreateRequestTracingEnum2" /> class.
        /// </summary>
        public RealtimeSessionCreateRequestTracingEnum2()
        {
        }
    }
}