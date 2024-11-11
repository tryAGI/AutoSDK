//HintName: G.Models.WorkflowRunUsageBillableUBUNTUJobRun.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WorkflowRunUsageBillableUBUNTUJobRun
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("job_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int JobId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration_ms")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int DurationMs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowRunUsageBillableUBUNTUJobRun" /> class.
        /// </summary>
        /// <param name="jobId"></param>
        /// <param name="durationMs"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public WorkflowRunUsageBillableUBUNTUJobRun(
            int jobId,
            int durationMs)
        {
            this.JobId = jobId;
            this.DurationMs = durationMs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowRunUsageBillableUBUNTUJobRun" /> class.
        /// </summary>
        public WorkflowRunUsageBillableUBUNTUJobRun()
        {
        }
    }
}