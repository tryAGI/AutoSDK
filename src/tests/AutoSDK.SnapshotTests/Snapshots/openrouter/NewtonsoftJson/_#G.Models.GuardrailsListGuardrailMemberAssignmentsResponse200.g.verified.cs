//HintName: G.Models.GuardrailsListGuardrailMemberAssignmentsResponse200.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GuardrailsListGuardrailMemberAssignmentsResponse200
    {
        /// <summary>
        /// List of member assignments
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.GuardrailsIdAssignmentsMembersGetResponsesContentApplicationJsonSchemaDataItems> Data { get; set; } = default!;

        /// <summary>
        /// Total number of member assignments
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_count", Required = global::Newtonsoft.Json.Required.Always)]
        public double TotalCount { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GuardrailsListGuardrailMemberAssignmentsResponse200" /> class.
        /// </summary>
        /// <param name="data">
        /// List of member assignments
        /// </param>
        /// <param name="totalCount">
        /// Total number of member assignments
        /// </param>
        public GuardrailsListGuardrailMemberAssignmentsResponse200(
            global::System.Collections.Generic.IList<global::G.GuardrailsIdAssignmentsMembersGetResponsesContentApplicationJsonSchemaDataItems> data,
            double totalCount)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.TotalCount = totalCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GuardrailsListGuardrailMemberAssignmentsResponse200" /> class.
        /// </summary>
        public GuardrailsListGuardrailMemberAssignmentsResponse200()
        {
        }
    }
}