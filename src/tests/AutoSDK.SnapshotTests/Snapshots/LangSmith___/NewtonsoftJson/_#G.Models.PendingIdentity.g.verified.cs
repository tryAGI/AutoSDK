//HintName: G.Models.PendingIdentity.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PendingIdentity
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("email", Required = global::Newtonsoft.Json.Required.Always)]
        public string Email { get; set; } = default!;

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("read_only")]
        public bool? ReadOnly { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("role_id")]
        public global::System.Guid? RoleId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("workspace_ids")]
        public global::System.Collections.Generic.IList<global::System.Guid>? WorkspaceIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("workspace_role_id")]
        public global::System.Guid? WorkspaceRoleId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("password")]
        public string? Password { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("full_name")]
        public string? FullName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("access_scope")]
        public global::G.AccessScope? AccessScope { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user_id")]
        public global::System.Guid? UserId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tenant_id")]
        public global::System.Guid? TenantId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("organization_id")]
        public global::System.Guid? OrganizationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("role_name")]
        public string? RoleName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PendingIdentity" /> class.
        /// </summary>
        /// <param name="email"></param>
        /// <param name="readOnly">
        /// Default Value: false
        /// </param>
        /// <param name="roleId"></param>
        /// <param name="workspaceIds"></param>
        /// <param name="workspaceRoleId"></param>
        /// <param name="password"></param>
        /// <param name="fullName"></param>
        /// <param name="accessScope"></param>
        /// <param name="id"></param>
        /// <param name="userId"></param>
        /// <param name="tenantId"></param>
        /// <param name="organizationId"></param>
        /// <param name="createdAt"></param>
        /// <param name="roleName"></param>
        public PendingIdentity(
            string email,
            global::System.Guid id,
            global::System.DateTime createdAt,
            bool? readOnly,
            global::System.Guid? roleId,
            global::System.Collections.Generic.IList<global::System.Guid>? workspaceIds,
            global::System.Guid? workspaceRoleId,
            string? password,
            string? fullName,
            global::G.AccessScope? accessScope,
            global::System.Guid? userId,
            global::System.Guid? tenantId,
            global::System.Guid? organizationId,
            string? roleName)
        {
            this.Email = email ?? throw new global::System.ArgumentNullException(nameof(email));
            this.Id = id;
            this.CreatedAt = createdAt;
            this.ReadOnly = readOnly;
            this.RoleId = roleId;
            this.WorkspaceIds = workspaceIds;
            this.WorkspaceRoleId = workspaceRoleId;
            this.Password = password;
            this.FullName = fullName;
            this.AccessScope = accessScope;
            this.UserId = userId;
            this.TenantId = tenantId;
            this.OrganizationId = organizationId;
            this.RoleName = roleName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PendingIdentity" /> class.
        /// </summary>
        public PendingIdentity()
        {
        }
    }
}