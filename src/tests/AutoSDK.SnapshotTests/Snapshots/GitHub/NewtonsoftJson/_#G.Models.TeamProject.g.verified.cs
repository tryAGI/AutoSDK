//HintName: G.Models.TeamProject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A team's access to a project.
    /// </summary>
    public sealed partial class TeamProject
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("owner_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string OwnerUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("html_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string HtmlUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("columns_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string ColumnsUrl { get; set; } = default!;

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
        [global::Newtonsoft.Json.JsonProperty("body", Required = global::Newtonsoft.Json.Required.Always)]
        public string? Body { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("number", Required = global::Newtonsoft.Json.Required.Always)]
        public int Number { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("state", Required = global::Newtonsoft.Json.Required.Always)]
        public string State { get; set; } = default!;

        /// <summary>
        /// A GitHub user.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("creator", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.SimpleUser Creator { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public string CreatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updated_at", Required = global::Newtonsoft.Json.Required.Always)]
        public string UpdatedAt { get; set; } = default!;

        /// <summary>
        /// The organization permission for this project. Only present when owner is an organization.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("organization_permission")]
        public string? OrganizationPermission { get; set; }

        /// <summary>
        /// Whether the project is private or not. Only present when owner is an organization.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("private")]
        public bool? Private { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("permissions", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.TeamProjectPermissions Permissions { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TeamProject" /> class.
        /// </summary>
        /// <param name="ownerUrl"></param>
        /// <param name="url"></param>
        /// <param name="htmlUrl"></param>
        /// <param name="columnsUrl"></param>
        /// <param name="id"></param>
        /// <param name="nodeId"></param>
        /// <param name="name"></param>
        /// <param name="body"></param>
        /// <param name="number"></param>
        /// <param name="state"></param>
        /// <param name="creator">
        /// A GitHub user.
        /// </param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="organizationPermission">
        /// The organization permission for this project. Only present when owner is an organization.
        /// </param>
        /// <param name="private">
        /// Whether the project is private or not. Only present when owner is an organization.
        /// </param>
        /// <param name="permissions"></param>
        public TeamProject(
            string ownerUrl,
            string url,
            string htmlUrl,
            string columnsUrl,
            int id,
            string nodeId,
            string name,
            string? body,
            int number,
            string state,
            global::G.SimpleUser creator,
            string createdAt,
            string updatedAt,
            global::G.TeamProjectPermissions permissions,
            string? organizationPermission,
            bool? @private)
        {
            this.OwnerUrl = ownerUrl ?? throw new global::System.ArgumentNullException(nameof(ownerUrl));
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.HtmlUrl = htmlUrl ?? throw new global::System.ArgumentNullException(nameof(htmlUrl));
            this.ColumnsUrl = columnsUrl ?? throw new global::System.ArgumentNullException(nameof(columnsUrl));
            this.Id = id;
            this.NodeId = nodeId ?? throw new global::System.ArgumentNullException(nameof(nodeId));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Body = body ?? throw new global::System.ArgumentNullException(nameof(body));
            this.Number = number;
            this.State = state ?? throw new global::System.ArgumentNullException(nameof(state));
            this.Creator = creator ?? throw new global::System.ArgumentNullException(nameof(creator));
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.UpdatedAt = updatedAt ?? throw new global::System.ArgumentNullException(nameof(updatedAt));
            this.Permissions = permissions ?? throw new global::System.ArgumentNullException(nameof(permissions));
            this.OrganizationPermission = organizationPermission;
            this.Private = @private;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TeamProject" /> class.
        /// </summary>
        public TeamProject()
        {
        }
    }
}