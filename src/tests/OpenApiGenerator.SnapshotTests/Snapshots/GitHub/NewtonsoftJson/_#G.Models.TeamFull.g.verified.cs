﻿//HintName: G.Models.TeamFull.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Groups of organization members that gives permissions on specified repositories.
    /// </summary>
    public sealed partial class TeamFull
    {
        /// <summary>
        /// Unique identifier of the team
        /// <br/>Example: 42
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public int Id { get; set; } = default!;

        /// <summary>
        /// <br/>Example: MDQ6VGVhbTE=
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("node_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string NodeId { get; set; } = default!;

        /// <summary>
        /// URL for the team
        /// <br/>Example: https://api.github.com/organizations/1/team/1
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// <br/>Example: https://github.com/orgs/rails/teams/core
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("html_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string HtmlUrl { get; set; } = default!;

        /// <summary>
        /// Name of the team
        /// <br/>Example: Developers
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// <br/>Example: justice-league
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("slug", Required = global::Newtonsoft.Json.Required.Always)]
        public string Slug { get; set; } = default!;

        /// <summary>
        /// <br/>Example: A great team.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description", Required = global::Newtonsoft.Json.Required.Always)]
        public string? Description { get; set; } = default!;

        /// <summary>
        /// The level of privacy this team should have
        /// <br/>Example: closed
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("privacy")]
        public TeamFullPrivacy? Privacy { get; set; }

        /// <summary>
        /// The notification setting the team has set
        /// <br/>Example: notifications_enabled
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("notification_setting")]
        public TeamFullNotificationSetting? NotificationSetting { get; set; }

        /// <summary>
        /// Permission that the team will have for its repositories
        /// <br/>Example: push
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("permission", Required = global::Newtonsoft.Json.Required.Always)]
        public string Permission { get; set; } = default!;

        /// <summary>
        /// <br/>Example: https://api.github.com/organizations/1/team/1/members{/member}
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("members_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string MembersUrl { get; set; } = default!;

        /// <summary>
        /// <br/>Example: https://api.github.com/organizations/1/team/1/repos
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("repositories_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string RepositoriesUrl { get; set; } = default!;

        /// <summary>
        /// Groups of organization members that gives permissions on specified repositories.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("parent")]
        public NullableTeamSimple? Parent { get; set; }

        /// <summary>
        /// <br/>Example: 3
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("members_count", Required = global::Newtonsoft.Json.Required.Always)]
        public int MembersCount { get; set; } = default!;

        /// <summary>
        /// <br/>Example: 10
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("repos_count", Required = global::Newtonsoft.Json.Required.Always)]
        public int ReposCount { get; set; } = default!;

        /// <summary>
        /// <br/>Example: 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// <br/>Example: 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updated_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime UpdatedAt { get; set; } = default!;

        /// <summary>
        /// Team Organization
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("organization", Required = global::Newtonsoft.Json.Required.Always)]
        public TeamOrganization Organization { get; set; } = default!;

        /// <summary>
        /// Distinguished Name (DN) that team maps to within LDAP environment
        /// <br/>Example: uid=example,ou=users,dc=github,dc=com
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ldap_dn")]
        public string? LdapDn { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}