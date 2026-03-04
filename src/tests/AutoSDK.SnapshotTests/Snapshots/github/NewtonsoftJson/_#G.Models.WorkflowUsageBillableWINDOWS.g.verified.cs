//HintName: G.Models.WorkflowUsageBillableWindows.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WorkflowUsageBillableWindows
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_ms")]
        public int? TotalMs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowUsageBillableWindows" /> class.
        /// </summary>
        /// <param name="totalMs"></param>
        public WorkflowUsageBillableWindows(
            int? totalMs)
        {
            this.TotalMs = totalMs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowUsageBillableWindows" /> class.
        /// </summary>
        public WorkflowUsageBillableWindows()
        {
        }
    }
}