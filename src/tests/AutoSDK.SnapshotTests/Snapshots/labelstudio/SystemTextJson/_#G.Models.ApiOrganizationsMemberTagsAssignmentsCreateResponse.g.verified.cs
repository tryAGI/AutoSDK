//HintName: G.Models.ApiOrganizationsMemberTagsAssignmentsCreateResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ApiOrganizationsMemberTagsAssignmentsCreateResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assigned")]
        public int? Assigned { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiOrganizationsMemberTagsAssignmentsCreateResponse" /> class.
        /// </summary>
        /// <param name="assigned"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApiOrganizationsMemberTagsAssignmentsCreateResponse(
            int? assigned)
        {
            this.Assigned = assigned;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiOrganizationsMemberTagsAssignmentsCreateResponse" /> class.
        /// </summary>
        public ApiOrganizationsMemberTagsAssignmentsCreateResponse()
        {
        }
    }
}