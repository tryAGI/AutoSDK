//HintName: G.Models.WorkflowRunUsageBillable.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WorkflowRunUsageBillable
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("UBUNTU")]
        public global::G.WorkflowRunUsageBillableUBUNTU? UBUNTU { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("MACOS")]
        public global::G.WorkflowRunUsageBillableMACOS? MACOS { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("WINDOWS")]
        public global::G.WorkflowRunUsageBillableWINDOWS? WINDOWS { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowRunUsageBillable" /> class.
        /// </summary>
        /// <param name="uBUNTU"></param>
        /// <param name="mACOS"></param>
        /// <param name="wINDOWS"></param>
        public WorkflowRunUsageBillable(
            global::G.WorkflowRunUsageBillableUBUNTU? uBUNTU,
            global::G.WorkflowRunUsageBillableMACOS? mACOS,
            global::G.WorkflowRunUsageBillableWINDOWS? wINDOWS)
        {
            this.UBUNTU = uBUNTU;
            this.MACOS = mACOS;
            this.WINDOWS = wINDOWS;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowRunUsageBillable" /> class.
        /// </summary>
        public WorkflowRunUsageBillable()
        {
        }
    }
}