//HintName: G.Models.OrganizationMembership.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// An organization membership defines the relationship between an organization<br/>
    /// and a user that is attached to it.
    /// </summary>
    public sealed partial class OrganizationMembership
    {
        /// <summary>
        /// The resource name of the membership, which allows its access by<br/>
        /// organization and user ID.<br/>
        /// - Format: `organizations/{organization.id}/memberships/{user.id}`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Role of the user in the organization.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("role", Required = global::Newtonsoft.Json.Required.Always)]
        public string Role { get; set; } = default!;

        /// <summary>
        /// Organizations group several users. As entities, they can own resources such<br/>
        /// as pipelines or releases.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("organization")]
        public global::G.Organization? Organization { get; set; }

        /// <summary>
        /// User describes an individual that interacts with Instill AI. It doesn't<br/>
        /// contain any private information about the user.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user")]
        public global::G.User? User { get; set; }

        /// <summary>
        /// MembershipState describes the state of a user membership to an organization.<br/>
        ///  - MEMBERSHIP_STATE_ACTIVE: Active.<br/>
        ///  - MEMBERSHIP_STATE_PENDING: Pending, i.e., a request has been sent to the user to join an<br/>
        /// organization.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("state")]
        public global::G.MembershipState? State { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}