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
        [global::System.Text.Json.Serialization.JsonPropertyName("billable")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.WorkflowUsageBillable Billable { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowUsage" /> class.
        /// </summary>
        /// <param name="billable"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WorkflowUsage(
            global::G.WorkflowUsageBillable billable)
        {
            this.Billable = billable ?? throw new global::System.ArgumentNullException(nameof(billable));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowUsage" /> class.
        /// </summary>
        public WorkflowUsage()
        {
        }
    }
}