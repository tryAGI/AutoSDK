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
        [global::Newtonsoft.Json.JsonProperty("members")]
        public global::System.Collections.Generic.IList<global::G.GetOrganizationMembersResponseMember>? Members { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetOrganizationMembersResponse" /> class.
        /// </summary>
        /// <param name="members">
        /// List of members belonging to the organization.
        /// </param>
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