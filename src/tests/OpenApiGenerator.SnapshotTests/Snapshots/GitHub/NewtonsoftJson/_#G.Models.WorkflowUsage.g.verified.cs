//HintName: G.Models.WorkflowUsage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Workflow Usage
    /// </summary>
    public sealed partial class WorkflowUsage
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("billable", Required = global::Newtonsoft.Json.Required.Always)]
        public WorkflowUsageBillable Billable { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}