//HintName: G.Models.OrgMembership.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Org Membership
    /// </summary>
    public sealed partial class OrgMembership
    {
        /// <summary>
        /// <br/>Example: https://api.github.com/orgs/octocat/memberships/defunkt
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// The state of the member in the organization. The `pending` state indicates the user has not yet accepted an invitation.
        /// <br/>Example: active
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("state", Required = global::Newtonsoft.Json.Required.Always)]
        public OrgMembershipState State { get; set; } = default!;

        /// <summary>
        /// The user's membership type in the organization.
        /// <br/>Example: admin
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("role", Required = global::Newtonsoft.Json.Required.Always)]
        public OrgMembershipRole Role { get; set; } = default!;

        /// <summary>
        /// <br/>Example: https://api.github.com/orgs/octocat
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("organization_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string OrganizationUrl { get; set; } = default!;

        /// <summary>
        /// A GitHub organization.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("organization", Required = global::Newtonsoft.Json.Required.Always)]
        public OrganizationSimple Organization { get; set; } = default!;

        /// <summary>
        /// A GitHub user.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user", Required = global::Newtonsoft.Json.Required.Always)]
        public NullableSimpleUser? User { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("permissions")]
        public OrgMembershipPermissions? Permissions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}