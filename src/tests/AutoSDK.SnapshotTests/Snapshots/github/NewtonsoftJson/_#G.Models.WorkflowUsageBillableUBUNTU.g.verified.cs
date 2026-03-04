//HintName: G.Models.WorkflowUsageBillableUbuntu.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WorkflowUsageBillableUbuntu
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
        /// Initializes a new instance of the <see cref="WorkflowUsageBillableUbuntu" /> class.
        /// </summary>
        /// <param name="totalMs"></param>
        public WorkflowUsageBillableUbuntu(
            int? totalMs)
        {
            this.TotalMs = totalMs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowUsageBillableUbuntu" /> class.
        /// </summary>
        public WorkflowUsageBillableUbuntu()
        {
        }
    }
}