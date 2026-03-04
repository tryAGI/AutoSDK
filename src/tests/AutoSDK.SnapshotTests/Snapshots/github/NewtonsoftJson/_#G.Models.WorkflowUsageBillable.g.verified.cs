//HintName: G.Models.WorkflowUsageBillable.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WorkflowUsageBillable
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("UBUNTU")]
        public global::G.WorkflowUsageBillableUbuntu? Ubuntu { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("MACOS")]
        public global::G.WorkflowUsageBillableMacos? Macos { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("WINDOWS")]
        public global::G.WorkflowUsageBillableWindows? Windows { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowUsageBillable" /> class.
        /// </summary>
        /// <param name="ubuntu"></param>
        /// <param name="macos"></param>
        /// <param name="windows"></param>
        public WorkflowUsageBillable(
            global::G.WorkflowUsageBillableUbuntu? ubuntu,
            global::G.WorkflowUsageBillableMacos? macos,
            global::G.WorkflowUsageBillableWindows? windows)
        {
            this.Ubuntu = ubuntu;
            this.Macos = macos;
            this.Windows = windows;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowUsageBillable" /> class.
        /// </summary>
        public WorkflowUsageBillable()
        {
        }
    }
}