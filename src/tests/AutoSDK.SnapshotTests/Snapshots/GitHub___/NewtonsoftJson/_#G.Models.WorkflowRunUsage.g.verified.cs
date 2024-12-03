//HintName: G.Models.WorkflowRunUsage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Workflow Run Usage
    /// </summary>
    public sealed partial class WorkflowRunUsage
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("billable", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.WorkflowRunUsageBillable Billable { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("run_duration_ms")]
        public int? RunDurationMs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowRunUsage" /> class.
        /// </summary>
        /// <param name="billable"></param>
        /// <param name="runDurationMs"></param>
        public WorkflowRunUsage(
            global::G.WorkflowRunUsageBillable billable,
            int? runDurationMs)
        {
            this.Billable = billable ?? throw new global::System.ArgumentNullException(nameof(billable));
            this.RunDurationMs = runDurationMs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowRunUsage" /> class.
        /// </summary>
        public WorkflowRunUsage()
        {
        }
    }
}