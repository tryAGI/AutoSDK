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
        /// Example: https://api.github.com/orgs/octocat/memberships/defunkt
        /// </summary>
        /// <example>https://api.github.com/orgs/octocat/memberships/defunkt</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// The state of the member in the organization. The `pending` state indicates the user has not yet accepted an invitation.<br/>
        /// Example: active
        /// </summary>
        /// <example>active</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OrgMembershipStateJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.OrgMembershipState State { get; set; }

        /// <summary>
        /// The user's membership type in the organization.<br/>
        /// Example: admin
        /// </summary>
        /// <example>admin</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OrgMembershipRoleJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.OrgMembershipRole Role { get; set; }

        /// <summary>
        /// Example: https://api.github.com/orgs/octocat
        /// </summary>
        /// <example>https://api.github.com/orgs/octocat</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OrganizationUrl { get; set; }

        /// <summary>
        /// A GitHub organization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.OrganizationSimple Organization { get; set; }

        /// <summary>
        /// A GitHub user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.NullableSimpleUser? User { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("permissions")]
        public global::G.OrgMembershipPermissions? Permissions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OrgMembership" /> class.
        /// </summary>
        /// <param name="url">
        /// Example: https://api.github.com/orgs/octocat/memberships/defunkt
        /// </param>
        /// <param name="state">
        /// The state of the member in the organization. The `pending` state indicates the user has not yet accepted an invitation.<br/>
        /// Example: active
        /// </param>
        /// <param name="role">
        /// The user's membership type in the organization.<br/>
        /// Example: admin
        /// </param>
        /// <param name="organizationUrl">
        /// Example: https://api.github.com/orgs/octocat
        /// </param>
        /// <param name="organization">
        /// A GitHub organization.
        /// </param>
        /// <param name="user">
        /// A GitHub user.
        /// </param>
        /// <param name="permissions"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OrgMembership(
            string url,
            global::G.OrgMembershipState state,
            global::G.OrgMembershipRole role,
            string organizationUrl,
            global::G.OrganizationSimple organization,
            global::G.NullableSimpleUser? user,
            global::G.OrgMembershipPermissions? permissions)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.State = state;
            this.Role = role;
            this.OrganizationUrl = organizationUrl ?? throw new global::System.ArgumentNullException(nameof(organizationUrl));
            this.Organization = organization ?? throw new global::System.ArgumentNullException(nameof(organization));
            this.User = user ?? throw new global::System.ArgumentNullException(nameof(user));
            this.Permissions = permissions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrgMembership" /> class.
        /// </summary>
        public OrgMembership()
        {
        }
    }
}