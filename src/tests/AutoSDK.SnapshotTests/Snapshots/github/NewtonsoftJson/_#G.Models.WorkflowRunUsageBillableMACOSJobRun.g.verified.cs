//HintName: G.Models.WorkflowRunUsageBillableMacosJobRun.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WorkflowRunUsageBillableMacosJobRun
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("job_id", Required = global::Newtonsoft.Json.Required.Always)]
        public int JobId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("duration_ms", Required = global::Newtonsoft.Json.Required.Always)]
        public int DurationMs { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowRunUsageBillableMacosJobRun" /> class.
        /// </summary>
        /// <param name="jobId"></param>
        /// <param name="durationMs"></param>
        public WorkflowRunUsageBillableMacosJobRun(
            int jobId,
            int durationMs)
        {
            this.JobId = jobId;
            this.DurationMs = durationMs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowRunUsageBillableMacosJobRun" /> class.
        /// </summary>
        public WorkflowRunUsageBillableMacosJobRun()
        {
        }
    }
}