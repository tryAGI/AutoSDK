//HintName: G.Models.TeamSimple.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Groups of organization members that gives permissions on specified repositories.
    /// </summary>
    public sealed partial class TeamSimple
    {
        /// <summary>
        /// Unique identifier of the team<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public int Id { get; set; } = default!;

        /// <summary>
        /// Example: MDQ6VGVhbTE=
        /// </summary>
        /// <example>MDQ6VGVhbTE=</example>
        [global::Newtonsoft.Json.JsonProperty("node_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string NodeId { get; set; } = default!;

        /// <summary>
        /// URL for the team<br/>
        /// Example: https://api.github.com/organizations/1/team/1
        /// </summary>
        /// <example>https://api.github.com/organizations/1/team/1</example>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// Example: https://api.github.com/organizations/1/team/1/members{/member}
        /// </summary>
        /// <example>https://api.github.com/organizations/1/team/1/members{/member}</example>
        [global::Newtonsoft.Json.JsonProperty("members_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string MembersUrl { get; set; } = default!;

        /// <summary>
        /// Name of the team<br/>
        /// Example: Justice League
        /// </summary>
        /// <example>Justice League</example>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Description of the team<br/>
        /// Example: A great team.
        /// </summary>
        /// <example>A great team.</example>
        [global::Newtonsoft.Json.JsonProperty("description", Required = global::Newtonsoft.Json.Required.Always)]
        public string? Description { get; set; } = default!;

        /// <summary>
        /// Permission that the team will have for its repositories<br/>
        /// Example: admin
        /// </summary>
        /// <example>admin</example>
        [global::Newtonsoft.Json.JsonProperty("permission", Required = global::Newtonsoft.Json.Required.Always)]
        public string Permission { get; set; } = default!;

        /// <summary>
        /// The level of privacy this team should have<br/>
        /// Example: closed
        /// </summary>
        /// <example>closed</example>
        [global::Newtonsoft.Json.JsonProperty("privacy")]
        public string? Privacy { get; set; }

        /// <summary>
        /// The notification setting the team has set<br/>
        /// Example: notifications_enabled
        /// </summary>
        /// <example>notifications_enabled</example>
        [global::Newtonsoft.Json.JsonProperty("notification_setting")]
        public string? NotificationSetting { get; set; }

        /// <summary>
        /// Example: https://github.com/orgs/rails/teams/core
        /// </summary>
        /// <example>https://github.com/orgs/rails/teams/core</example>
        [global::Newtonsoft.Json.JsonProperty("html_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string HtmlUrl { get; set; } = default!;

        /// <summary>
        /// Example: https://api.github.com/organizations/1/team/1/repos
        /// </summary>
        /// <example>https://api.github.com/organizations/1/team/1/repos</example>
        [global::Newtonsoft.Json.JsonProperty("repositories_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string RepositoriesUrl { get; set; } = default!;

        /// <summary>
        /// Example: justice-league
        /// </summary>
        /// <example>justice-league</example>
        [global::Newtonsoft.Json.JsonProperty("slug", Required = global::Newtonsoft.Json.Required.Always)]
        public string Slug { get; set; } = default!;

        /// <summary>
        /// Distinguished Name (DN) that team maps to within LDAP environment<br/>
        /// Example: uid=example,ou=users,dc=github,dc=com
        /// </summary>
        /// <example>uid=example,ou=users,dc=github,dc=com</example>
        [global::Newtonsoft.Json.JsonProperty("ldap_dn")]
        public string? LdapDn { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TeamSimple" /> class.
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
        public TeamSimple(
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
        /// Initializes a new instance of the <see cref="TeamSimple" /> class.
        /// </summary>
        public TeamSimple()
        {
        }
    }
}