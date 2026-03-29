//HintName: G.Models.GetOrganizationMembersResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetOrganizationMembersResponse
    {
        /// <summary>
        /// List of members belonging to the organization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("members")]
        public global::System.Collections.Generic.IList<global::G.GetOrganizationMembersResponseMember>? Members { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetOrganizationMembersResponse" /> class.
        /// </summary>
        /// <param name="members">
        /// List of members belonging to the organization.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetOrganizationMembersResponse(
            global::System.Collections.Generic.IList<global::G.GetOrganizationMembersResponseMember>? members)
        {
            this.Members = members;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetOrganizationMembersResponse" /> class.
        /// </summary>
        public GetOrganizationMembersResponse()
        {
        }
    }
}