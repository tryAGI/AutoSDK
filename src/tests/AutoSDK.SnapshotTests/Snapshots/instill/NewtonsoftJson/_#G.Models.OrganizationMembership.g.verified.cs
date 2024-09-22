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
        /// - Format: `organizations/{organization.id}/memberships/{user.id}`.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Role of the user in the organization.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("role", Required = global::Newtonsoft.Json.Required.Always)]
        public string Role { get; set; } = default!;

        /// <summary>
        /// State of the membership.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("state")]
        public global::G.MembershipState? State { get; set; }

        /// <summary>
        /// User information.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user")]
        public global::G.User? User { get; set; }

        /// <summary>
        /// Organization information.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("organization")]
        public global::G.Organization? Organization { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}