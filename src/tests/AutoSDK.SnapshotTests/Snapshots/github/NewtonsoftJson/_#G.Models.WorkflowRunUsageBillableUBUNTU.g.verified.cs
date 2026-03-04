//HintName: G.Models.WorkflowRunUsageBillableUbuntu.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WorkflowRunUsageBillableUbuntu
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_ms", Required = global::Newtonsoft.Json.Required.Always)]
        public int TotalMs { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("jobs", Required = global::Newtonsoft.Json.Required.Always)]
        public int Jobs { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("job_runs")]
        public global::System.Collections.Generic.IList<global::G.WorkflowRunUsageBillableUbuntuJobRun>? JobRuns { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowRunUsageBillableUbuntu" /> class.
        /// </summary>
        /// <param name="totalMs"></param>
        /// <param name="jobs"></param>
        /// <param name="jobRuns"></param>
        public WorkflowRunUsageBillableUbuntu(
            int totalMs,
            int jobs,
            global::System.Collections.Generic.IList<global::G.WorkflowRunUsageBillableUbuntuJobRun>? jobRuns)
        {
            this.TotalMs = totalMs;
            this.Jobs = jobs;
            this.JobRuns = jobRuns;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowRunUsageBillableUbuntu" /> class.
        /// </summary>
        public WorkflowRunUsageBillableUbuntu()
        {
        }
    }
}