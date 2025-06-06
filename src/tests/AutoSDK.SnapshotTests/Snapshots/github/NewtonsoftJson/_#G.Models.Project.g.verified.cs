﻿//HintName: G.Models.Project.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Projects are a way to organize columns and cards of work.
    /// </summary>
    public sealed partial class Project
    {
        /// <summary>
        /// Example: https://api.github.com/repos/api-playground/projects-test
        /// </summary>
        /// <example>https://api.github.com/repos/api-playground/projects-test</example>
        [global::Newtonsoft.Json.JsonProperty("owner_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string OwnerUrl { get; set; } = default!;

        /// <summary>
        /// Example: https://api.github.com/projects/1002604
        /// </summary>
        /// <example>https://api.github.com/projects/1002604</example>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// Example: https://github.com/api-playground/projects-test/projects/12
        /// </summary>
        /// <example>https://github.com/api-playground/projects-test/projects/12</example>
        [global::Newtonsoft.Json.JsonProperty("html_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string HtmlUrl { get; set; } = default!;

        /// <summary>
        /// Example: https://api.github.com/projects/1002604/columns
        /// </summary>
        /// <example>https://api.github.com/projects/1002604/columns</example>
        [global::Newtonsoft.Json.JsonProperty("columns_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string ColumnsUrl { get; set; } = default!;

        /// <summary>
        /// Example: 1002604
        /// </summary>
        /// <example>1002604</example>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public int Id { get; set; } = default!;

        /// <summary>
        /// Example: MDc6UHJvamVjdDEwMDI2MDQ=
        /// </summary>
        /// <example>MDc6UHJvamVjdDEwMDI2MDQ=</example>
        [global::Newtonsoft.Json.JsonProperty("node_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string NodeId { get; set; } = default!;

        /// <summary>
        /// Name of the project<br/>
        /// Example: Week One Sprint
        /// </summary>
        /// <example>Week One Sprint</example>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Body of the project<br/>
        /// Example: This project represents the sprint of the first week in January
        /// </summary>
        /// <example>This project represents the sprint of the first week in January</example>
        [global::Newtonsoft.Json.JsonProperty("body", Required = global::Newtonsoft.Json.Required.Always)]
        public string? Body { get; set; } = default!;

        /// <summary>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::Newtonsoft.Json.JsonProperty("number", Required = global::Newtonsoft.Json.Required.Always)]
        public int Number { get; set; } = default!;

        /// <summary>
        /// State of the project; either 'open' or 'closed'<br/>
        /// Example: open
        /// </summary>
        /// <example>open</example>
        [global::Newtonsoft.Json.JsonProperty("state", Required = global::Newtonsoft.Json.Required.Always)]
        public string State { get; set; } = default!;

        /// <summary>
        /// A GitHub user.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("creator", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.NullableSimpleUser? Creator { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updated_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime UpdatedAt { get; set; } = default!;

        /// <summary>
        /// The baseline permission that all organization members have on this project. Only present if owner is an organization.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("organization_permission")]
        public global::G.ProjectOrganizationPermission? OrganizationPermission { get; set; }

        /// <summary>
        /// Whether or not this project can be seen by everyone. Only present if owner is an organization.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("private")]
        public bool? Private { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Project" /> class.
        /// </summary>
        /// <param name="ownerUrl">
        /// Example: https://api.github.com/repos/api-playground/projects-test
        /// </param>
        /// <param name="url">
        /// Example: https://api.github.com/projects/1002604
        /// </param>
        /// <param name="htmlUrl">
        /// Example: https://github.com/api-playground/projects-test/projects/12
        /// </param>
        /// <param name="columnsUrl">
        /// Example: https://api.github.com/projects/1002604/columns
        /// </param>
        /// <param name="id">
        /// Example: 1002604
        /// </param>
        /// <param name="nodeId">
        /// Example: MDc6UHJvamVjdDEwMDI2MDQ=
        /// </param>
        /// <param name="name">
        /// Name of the project<br/>
        /// Example: Week One Sprint
        /// </param>
        /// <param name="body">
        /// Body of the project<br/>
        /// Example: This project represents the sprint of the first week in January
        /// </param>
        /// <param name="number">
        /// Example: 1
        /// </param>
        /// <param name="state">
        /// State of the project; either 'open' or 'closed'<br/>
        /// Example: open
        /// </param>
        /// <param name="creator">
        /// A GitHub user.
        /// </param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="organizationPermission">
        /// The baseline permission that all organization members have on this project. Only present if owner is an organization.
        /// </param>
        /// <param name="private">
        /// Whether or not this project can be seen by everyone. Only present if owner is an organization.
        /// </param>
        public Project(
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
            global::G.NullableSimpleUser? creator,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            global::G.ProjectOrganizationPermission? organizationPermission,
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
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.OrganizationPermission = organizationPermission;
            this.Private = @private;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Project" /> class.
        /// </summary>
        public Project()
        {
        }
    }
}