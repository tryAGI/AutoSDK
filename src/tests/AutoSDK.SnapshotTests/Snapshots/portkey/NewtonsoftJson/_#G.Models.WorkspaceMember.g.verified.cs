//HintName: G.Models.WorkspaceMember.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WorkspaceMember
    {
        /// <summary>
        /// Example: workspace-user
        /// </summary>
        /// <example>workspace-user</example>
        [global::Newtonsoft.Json.JsonProperty("object")]
        public global::G.WorkspaceMemberObject? Object { get; set; }

        /// <summary>
        /// Example: 66dc015d-0270-11f1-8eec-0e27d7367989
        /// </summary>
        /// <example>66dc015d-0270-11f1-8eec-0e27d7367989</example>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// Example: John
        /// </summary>
        /// <example>John</example>
        [global::Newtonsoft.Json.JsonProperty("first_name")]
        public string? FirstName { get; set; }

        /// <summary>
        /// Example: Doe
        /// </summary>
        /// <example>Doe</example>
        [global::Newtonsoft.Json.JsonProperty("last_name")]
        public string? LastName { get; set; }

        /// <summary>
        /// Example: admin
        /// </summary>
        /// <example>admin</example>
        [global::Newtonsoft.Json.JsonProperty("org_role")]
        public global::G.WorkspaceMemberOrgRole? OrgRole { get; set; }

        /// <summary>
        /// Example: admin
        /// </summary>
        /// <example>admin</example>
        [global::Newtonsoft.Json.JsonProperty("role")]
        public global::G.WorkspaceMemberRole? Role { get; set; }

        /// <summary>
        /// Example: 2026-03-09T07:55:25.000Z
        /// </summary>
        /// <example>2026-03-09T07:55:25.000Z</example>
        [global::Newtonsoft.Json.JsonProperty("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Example: 2026-03-09T07:55:25.000Z
        /// </summary>
        /// <example>2026-03-09T07:55:25.000Z</example>
        [global::Newtonsoft.Json.JsonProperty("last_updated_at")]
        public global::System.DateTime? LastUpdatedAt { get; set; }

        /// <summary>
        /// Example: active
        /// </summary>
        /// <example>active</example>
        [global::Newtonsoft.Json.JsonProperty("status")]
        public global::G.WorkspaceMemberStatus? Status { get; set; }

        /// <summary>
        /// Example: bf276bb9-4cef-4d87-b69b-b23a6ed6b1dd
        /// </summary>
        /// <example>bf276bb9-4cef-4d87-b69b-b23a6ed6b1dd</example>
        [global::Newtonsoft.Json.JsonProperty("workspace_id")]
        public global::System.Guid? WorkspaceId { get; set; }

        /// <summary>
        /// Example: john.doe@example.com
        /// </summary>
        /// <example>john.doe@example.com</example>
        [global::Newtonsoft.Json.JsonProperty("email")]
        public string? Email { get; set; }

        /// <summary>
        /// Example: [organisations.read, organisation_users.read, workspaces.read, logs.list, logs.view, prompts.create, prompts.read, prompts.list, configs.create, configs.read, configs.list, virtual_keys.create, virtual_keys.read, virtual_keys.list, workspace_users.create, workspace_users.read, workspace_users.list, generations.create]
        /// </summary>
        /// <example>[organisations.read, organisation_users.read, workspaces.read, logs.list, logs.view, prompts.create, prompts.read, prompts.list, configs.create, configs.read, configs.list, virtual_keys.create, virtual_keys.read, virtual_keys.list, workspace_users.create, workspace_users.read, workspace_users.list, generations.create]</example>
        [global::Newtonsoft.Json.JsonProperty("scopes")]
        public global::System.Collections.Generic.IList<string>? Scopes { get; set; }

        /// <summary>
        /// Example: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        /// <example>openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464</example>
        [global::Newtonsoft.Json.JsonProperty("settings")]
        public object? Settings { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkspaceMember" /> class.
        /// </summary>
        /// <param name="object">
        /// Example: workspace-user
        /// </param>
        /// <param name="id">
        /// Example: 66dc015d-0270-11f1-8eec-0e27d7367989
        /// </param>
        /// <param name="firstName">
        /// Example: John
        /// </param>
        /// <param name="lastName">
        /// Example: Doe
        /// </param>
        /// <param name="orgRole">
        /// Example: admin
        /// </param>
        /// <param name="role">
        /// Example: admin
        /// </param>
        /// <param name="createdAt">
        /// Example: 2026-03-09T07:55:25.000Z
        /// </param>
        /// <param name="lastUpdatedAt">
        /// Example: 2026-03-09T07:55:25.000Z
        /// </param>
        /// <param name="status">
        /// Example: active
        /// </param>
        /// <param name="workspaceId">
        /// Example: bf276bb9-4cef-4d87-b69b-b23a6ed6b1dd
        /// </param>
        /// <param name="email">
        /// Example: john.doe@example.com
        /// </param>
        /// <param name="scopes">
        /// Example: [organisations.read, organisation_users.read, workspaces.read, logs.list, logs.view, prompts.create, prompts.read, prompts.list, configs.create, configs.read, configs.list, virtual_keys.create, virtual_keys.read, virtual_keys.list, workspace_users.create, workspace_users.read, workspace_users.list, generations.create]
        /// </param>
        /// <param name="settings">
        /// Example: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        public WorkspaceMember(
            global::G.WorkspaceMemberObject? @object,
            global::System.Guid? id,
            string? firstName,
            string? lastName,
            global::G.WorkspaceMemberOrgRole? orgRole,
            global::G.WorkspaceMemberRole? role,
            global::System.DateTime? createdAt,
            global::System.DateTime? lastUpdatedAt,
            global::G.WorkspaceMemberStatus? status,
            global::System.Guid? workspaceId,
            string? email,
            global::System.Collections.Generic.IList<string>? scopes,
            object? settings)
        {
            this.Object = @object;
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.OrgRole = orgRole;
            this.Role = role;
            this.CreatedAt = createdAt;
            this.LastUpdatedAt = lastUpdatedAt;
            this.Status = status;
            this.WorkspaceId = workspaceId;
            this.Email = email;
            this.Scopes = scopes;
            this.Settings = settings;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkspaceMember" /> class.
        /// </summary>
        public WorkspaceMember()
        {
        }
    }
}