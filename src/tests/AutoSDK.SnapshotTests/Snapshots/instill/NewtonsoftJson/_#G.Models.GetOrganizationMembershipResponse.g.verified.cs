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
        /// An organization membership defines the relationship between an organization<br/>
        /// and a user that is attached to it.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("membership")]
        public global::G.OrganizationMembership? Membership { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}