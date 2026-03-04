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
        [global::System.Text.Json.Serialization.JsonPropertyName("UBUNTU")]
        public global::G.WorkflowUsageBillableUbuntu? Ubuntu { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("MACOS")]
        public global::G.WorkflowUsageBillableMacos? Macos { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("WINDOWS")]
        public global::G.WorkflowUsageBillableWindows? Windows { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowUsageBillable" /> class.
        /// </summary>
        /// <param name="ubuntu"></param>
        /// <param name="macos"></param>
        /// <param name="windows"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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