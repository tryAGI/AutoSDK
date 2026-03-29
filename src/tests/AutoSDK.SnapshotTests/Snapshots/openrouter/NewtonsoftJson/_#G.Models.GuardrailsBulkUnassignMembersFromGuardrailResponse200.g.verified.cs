//HintName: G.Models.GuardrailsBulkUnassignMembersFromGuardrailResponse200.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GuardrailsBulkUnassignMembersFromGuardrailResponse200
    {
        /// <summary>
        /// Number of members successfully unassigned
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("unassigned_count", Required = global::Newtonsoft.Json.Required.Always)]
        public double UnassignedCount { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GuardrailsBulkUnassignMembersFromGuardrailResponse200" /> class.
        /// </summary>
        /// <param name="unassignedCount">
        /// Number of members successfully unassigned
        /// </param>
        public GuardrailsBulkUnassignMembersFromGuardrailResponse200(
            double unassignedCount)
        {
            this.UnassignedCount = unassignedCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GuardrailsBulkUnassignMembersFromGuardrailResponse200" /> class.
        /// </summary>
        public GuardrailsBulkUnassignMembersFromGuardrailResponse200()
        {
        }
    }
}