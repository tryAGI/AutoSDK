//HintName: G.Models.GetOrganizationMembershipResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// GetOrganizationMembershipResponse contains the organization membership.
    /// </summary>
    public sealed partial class GetOrganizationMembershipResponse
    {
        /// <summary>
        /// The requested organization membership.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("membership")]
        public global::G.OrganizationMembership? Membership { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetOrganizationMembershipResponse" /> class.
        /// </summary>
        /// <param name="membership">
        /// The requested organization membership.<br/>
        /// Included only in responses
        /// </param>
        public GetOrganizationMembershipResponse(
            global::G.OrganizationMembership? membership)
        {
            this.Membership = membership;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetOrganizationMembershipResponse" /> class.
        /// </summary>
        public GetOrganizationMembershipResponse()
        {
        }
    }
}