//HintName: G.Models.OrgMemberIdentity.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OrgMemberIdentity
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid OrganizationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tenant_id")]
        public global::System.Guid? TenantId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid UserId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ls_user_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid LsUserId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("read_only")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool ReadOnly { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role_id")]
        public global::System.Guid? RoleId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role_name")]
        public string? RoleName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("access_scope")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AccessScopeJsonConverter))]
        public global::G.AccessScope? AccessScope { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        public string? Email { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("full_name")]
        public string? FullName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("avatar_url")]
        public string? AvatarUrl { get; set; }

        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("linked_login_methods")]
        public global::System.Collections.Generic.IList<global::G.ProviderUserSlim>? LinkedLoginMethods { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("org_role_id")]
        public global::System.Guid? OrgRoleId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("org_role_name")]
        public string? OrgRoleName { get; set; }

        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tenant_ids")]
        public global::System.Collections.Generic.IList<global::System.Guid>? TenantIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OrgMemberIdentity" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="organizationId"></param>
        /// <param name="tenantId"></param>
        /// <param name="createdAt"></param>
        /// <param name="userId"></param>
        /// <param name="lsUserId"></param>
        /// <param name="readOnly"></param>
        /// <param name="roleId"></param>
        /// <param name="roleName"></param>
        /// <param name="accessScope"></param>
        /// <param name="email"></param>
        /// <param name="fullName"></param>
        /// <param name="avatarUrl"></param>
        /// <param name="linkedLoginMethods">
        /// Default Value: []
        /// </param>
        /// <param name="orgRoleId"></param>
        /// <param name="orgRoleName"></param>
        /// <param name="tenantIds">
        /// Default Value: []
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OrgMemberIdentity(
            global::System.Guid id,
            global::System.Guid organizationId,
            global::System.DateTime createdAt,
            global::System.Guid userId,
            global::System.Guid lsUserId,
            bool readOnly,
            global::System.Guid? tenantId,
            global::System.Guid? roleId,
            string? roleName,
            global::G.AccessScope? accessScope,
            string? email,
            string? fullName,
            string? avatarUrl,
            global::System.Collections.Generic.IList<global::G.ProviderUserSlim>? linkedLoginMethods,
            global::System.Guid? orgRoleId,
            string? orgRoleName,
            global::System.Collections.Generic.IList<global::System.Guid>? tenantIds)
        {
            this.Id = id;
            this.OrganizationId = organizationId;
            this.CreatedAt = createdAt;
            this.UserId = userId;
            this.LsUserId = lsUserId;
            this.ReadOnly = readOnly;
            this.TenantId = tenantId;
            this.RoleId = roleId;
            this.RoleName = roleName;
            this.AccessScope = accessScope;
            this.Email = email;
            this.FullName = fullName;
            this.AvatarUrl = avatarUrl;
            this.LinkedLoginMethods = linkedLoginMethods;
            this.OrgRoleId = orgRoleId;
            this.OrgRoleName = orgRoleName;
            this.TenantIds = tenantIds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrgMemberIdentity" /> class.
        /// </summary>
        public OrgMemberIdentity()
        {
        }
    }
}