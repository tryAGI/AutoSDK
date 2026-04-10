//HintName: G.Models.PipelinesListPipelineSyncHistoryResponseRun.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PipelinesListPipelineSyncHistoryResponseRun
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("workflow_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string WorkflowId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.PipelinesListPipelineSyncHistoryResponseRunStatusJsonConverter))]
        public global::G.PipelinesListPipelineSyncHistoryResponseRunStatus Status { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("started_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime StartedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("completed_at")]
        public global::System.DateTime? CompletedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("error")]
        public global::G.PipelinesListPipelineSyncHistoryResponseRunError? Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PipelinesListPipelineSyncHistoryResponseRun" /> class.
        /// </summary>
        /// <param name="workflowId"></param>
        /// <param name="status"></param>
        /// <param name="startedAt"></param>
        /// <param name="completedAt"></param>
        /// <param name="error"></param>
        public PipelinesListPipelineSyncHistoryResponseRun(
            string workflowId,
            global::G.PipelinesListPipelineSyncHistoryResponseRunStatus status,
            global::System.DateTime startedAt,
            global::System.DateTime? completedAt,
            global::G.PipelinesListPipelineSyncHistoryResponseRunError? error)
        {
            this.WorkflowId = workflowId ?? throw new global::System.ArgumentNullException(nameof(workflowId));
            this.Status = status;
            this.StartedAt = startedAt;
            this.CompletedAt = completedAt;
            this.Error = error;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PipelinesListPipelineSyncHistoryResponseRun" /> class.
        /// </summary>
        public PipelinesListPipelineSyncHistoryResponseRun()
        {
        }
    }
}