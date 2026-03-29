//HintName: G.Models.GuardrailsBulkAssignMembersToGuardrailResponse200.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GuardrailsBulkAssignMembersToGuardrailResponse200
    {
        /// <summary>
        /// Number of members successfully assigned
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("assigned_count", Required = global::Newtonsoft.Json.Required.Always)]
        public double AssignedCount { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GuardrailsBulkAssignMembersToGuardrailResponse200" /> class.
        /// </summary>
        /// <param name="assignedCount">
        /// Number of members successfully assigned
        /// </param>
        public GuardrailsBulkAssignMembersToGuardrailResponse200(
            double assignedCount)
        {
            this.AssignedCount = assignedCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GuardrailsBulkAssignMembersToGuardrailResponse200" /> class.
        /// </summary>
        public GuardrailsBulkAssignMembersToGuardrailResponse200()
        {
        }
    }
}