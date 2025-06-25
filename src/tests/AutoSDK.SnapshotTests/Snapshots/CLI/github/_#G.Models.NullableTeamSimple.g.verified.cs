//HintName: G.Models.NullableTeamSimple.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Groups of organization members that gives permissions on specified repositories.
    /// </summary>
    public sealed partial class NullableTeamSimple
    {
        /// <summary>
        /// Unique identifier of the team<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Id { get; set; }

        /// <summary>
        /// Example: MDQ6VGVhbTE=
        /// </summary>
        /// <example>MDQ6VGVhbTE=</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("node_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NodeId { get; set; }

        /// <summary>
        /// URL for the team<br/>
        /// Example: https://api.github.com/organizations/1/team/1
        /// </summary>
        /// <example>https://api.github.com/organizations/1/team/1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Example: https://api.github.com/organizations/1/team/1/members{/member}
        /// </summary>
        /// <example>https://api.github.com/organizations/1/team/1/members{/member}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("members_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string MembersUrl { get; set; }

        /// <summary>
        /// Name of the team<br/>
        /// Example: Justice League
        /// </summary>
        /// <example>Justice League</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Description of the team<br/>
        /// Example: A great team.
        /// </summary>
        /// <example>A great team.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? Description { get; set; }

        /// <summary>
        /// Permission that the team will have for its repositories<br/>
        /// Example: admin
        /// </summary>
        /// <example>admin</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("permission")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Permission { get; set; }

        /// <summary>
        /// The level of privacy this team should have<br/>
        /// Example: closed
        /// </summary>
        /// <example>closed</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("privacy")]
        public string? Privacy { get; set; }

        /// <summary>
        /// The notification setting the team has set<br/>
        /// Example: notifications_enabled
        /// </summary>
        /// <example>notifications_enabled</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("notification_setting")]
        public string? NotificationSetting { get; set; }

        /// <summary>
        /// Example: https://github.com/orgs/rails/teams/core
        /// </summary>
        /// <example>https://github.com/orgs/rails/teams/core</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("html_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string HtmlUrl { get; set; }

        /// <summary>
        /// Example: https://api.github.com/organizations/1/team/1/repos
        /// </summary>
        /// <example>https://api.github.com/organizations/1/team/1/repos</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("repositories_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RepositoriesUrl { get; set; }

        /// <summary>
        /// Example: justice-league
        /// </summary>
        /// <example>justice-league</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("slug")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Slug { get; set; }

        /// <summary>
        /// Distinguished Name (DN) that team maps to within LDAP environment<br/>
        /// Example: uid=example,ou=users,dc=github,dc=com
        /// </summary>
        /// <example>uid=example,ou=users,dc=github,dc=com</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("ldap_dn")]
        public string? LdapDn { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NullableTeamSimple" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier of the team<br/>
        /// Example: 1
        /// </param>
        /// <param name="nodeId">
        /// Example: MDQ6VGVhbTE=
        /// </param>
        /// <param name="url">
        /// URL for the team<br/>
        /// Example: https://api.github.com/organizations/1/team/1
        /// </param>
        /// <param name="membersUrl">
        /// Example: https://api.github.com/organizations/1/team/1/members{/member}
        /// </param>
        /// <param name="name">
        /// Name of the team<br/>
        /// Example: Justice League
        /// </param>
        /// <param name="description">
        /// Description of the team<br/>
        /// Example: A great team.
        /// </param>
        /// <param name="permission">
        /// Permission that the team will have for its repositories<br/>
        /// Example: admin
        /// </param>
        /// <param name="privacy">
        /// The level of privacy this team should have<br/>
        /// Example: closed
        /// </param>
        /// <param name="notificationSetting">
        /// The notification setting the team has set<br/>
        /// Example: notifications_enabled
        /// </param>
        /// <param name="htmlUrl">
        /// Example: https://github.com/orgs/rails/teams/core
        /// </param>
        /// <param name="repositoriesUrl">
        /// Example: https://api.github.com/organizations/1/team/1/repos
        /// </param>
        /// <param name="slug">
        /// Example: justice-league
        /// </param>
        /// <param name="ldapDn">
        /// Distinguished Name (DN) that team maps to within LDAP environment<br/>
        /// Example: uid=example,ou=users,dc=github,dc=com
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NullableTeamSimple(
            int id,
            string nodeId,
            string url,
            string membersUrl,
            string name,
            string? description,
            string permission,
            string htmlUrl,
            string repositoriesUrl,
            string slug,
            string? privacy,
            string? notificationSetting,
            string? ldapDn)
        {
            this.Id = id;
            this.NodeId = nodeId ?? throw new global::System.ArgumentNullException(nameof(nodeId));
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.MembersUrl = membersUrl ?? throw new global::System.ArgumentNullException(nameof(membersUrl));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Permission = permission ?? throw new global::System.ArgumentNullException(nameof(permission));
            this.HtmlUrl = htmlUrl ?? throw new global::System.ArgumentNullException(nameof(htmlUrl));
            this.RepositoriesUrl = repositoriesUrl ?? throw new global::System.ArgumentNullException(nameof(repositoriesUrl));
            this.Slug = slug ?? throw new global::System.ArgumentNullException(nameof(slug));
            this.Privacy = privacy;
            this.NotificationSetting = notificationSetting;
            this.LdapDn = ldapDn;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NullableTeamSimple" /> class.
        /// </summary>
        public NullableTeamSimple()
        {
        }
    }
}