//HintName: G.Models.TeamRoleAssignment.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The Relationship a Team has with a role.
    /// </summary>
    public sealed partial class TeamRoleAssignment
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public int Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("node_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string NodeId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("slug", Required = global::Newtonsoft.Json.Required.Always)]
        public string Slug { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description", Required = global::Newtonsoft.Json.Required.Always)]
        public string? Description { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("privacy")]
        public string? Privacy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("notification_setting")]
        public string? NotificationSetting { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("permission", Required = global::Newtonsoft.Json.Required.Always)]
        public string Permission { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("permissions")]
        public global::G.TeamRoleAssignmentPermissions? Permissions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// Example: https://github.com/orgs/rails/teams/core
        /// </summary>
        /// <example>https://github.com/orgs/rails/teams/core</example>
        [global::Newtonsoft.Json.JsonProperty("html_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string HtmlUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("members_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string MembersUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("repositories_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string RepositoriesUrl { get; set; } = default!;

        /// <summary>
        /// Groups of organization members that gives permissions on specified repositories.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("parent", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.NullableTeamSimple? Parent { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TeamRoleAssignment" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nodeId"></param>
        /// <param name="name"></param>
        /// <param name="slug"></param>
        /// <param name="description"></param>
        /// <param name="privacy"></param>
        /// <param name="notificationSetting"></param>
        /// <param name="permission"></param>
        /// <param name="permissions"></param>
        /// <param name="url"></param>
        /// <param name="htmlUrl">
        /// Example: https://github.com/orgs/rails/teams/core
        /// </param>
        /// <param name="membersUrl"></param>
        /// <param name="repositoriesUrl"></param>
        /// <param name="parent">
        /// Groups of organization members that gives permissions on specified repositories.
        /// </param>
        public TeamRoleAssignment(
            int id,
            string nodeId,
            string name,
            string slug,
            string? description,
            string permission,
            string url,
            string htmlUrl,
            string membersUrl,
            string repositoriesUrl,
            global::G.NullableTeamSimple? parent,
            string? privacy,
            string? notificationSetting,
            global::G.TeamRoleAssignmentPermissions? permissions)
        {
            this.Id = id;
            this.NodeId = nodeId ?? throw new global::System.ArgumentNullException(nameof(nodeId));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Slug = slug ?? throw new global::System.ArgumentNullException(nameof(slug));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Permission = permission ?? throw new global::System.ArgumentNullException(nameof(permission));
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.HtmlUrl = htmlUrl ?? throw new global::System.ArgumentNullException(nameof(htmlUrl));
            this.MembersUrl = membersUrl ?? throw new global::System.ArgumentNullException(nameof(membersUrl));
            this.RepositoriesUrl = repositoriesUrl ?? throw new global::System.ArgumentNullException(nameof(repositoriesUrl));
            this.Parent = parent ?? throw new global::System.ArgumentNullException(nameof(parent));
            this.Privacy = privacy;
            this.NotificationSetting = notificationSetting;
            this.Permissions = permissions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TeamRoleAssignment" /> class.
        /// </summary>
        public TeamRoleAssignment()
        {
        }
    }
}