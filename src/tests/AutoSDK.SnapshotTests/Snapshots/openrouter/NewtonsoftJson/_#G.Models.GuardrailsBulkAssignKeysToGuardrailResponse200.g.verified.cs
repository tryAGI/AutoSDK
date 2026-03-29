//HintName: G.Models.GuardrailsBulkAssignKeysToGuardrailResponse200.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GuardrailsBulkAssignKeysToGuardrailResponse200
    {
        /// <summary>
        /// Number of keys successfully assigned
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("assigned_count", Required = global::Newtonsoft.Json.Required.Always)]
        public double AssignedCount { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GuardrailsBulkAssignKeysToGuardrailResponse200" /> class.
        /// </summary>
        /// <param name="assignedCount">
        /// Number of keys successfully assigned
        /// </param>
        public GuardrailsBulkAssignKeysToGuardrailResponse200(
            double assignedCount)
        {
            this.AssignedCount = assignedCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GuardrailsBulkAssignKeysToGuardrailResponse200" /> class.
        /// </summary>
        public GuardrailsBulkAssignKeysToGuardrailResponse200()
        {
        }
    }
}