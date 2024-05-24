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
        public WorkflowRunUsageBillable Billable { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("run_duration_ms")]
        public int RunDurationMs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}