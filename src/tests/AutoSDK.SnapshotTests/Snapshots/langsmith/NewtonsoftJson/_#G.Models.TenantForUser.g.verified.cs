//HintName: G.Models.TenantForUser.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TenantForUser
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid Id { get; set; } = default!;

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
        [global::Newtonsoft.Json.JsonProperty("display_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string DisplayName { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_personal", Required = global::Newtonsoft.Json.Required.Always)]
        public bool IsPersonal { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_deleted", Required = global::Newtonsoft.Json.Required.Always)]
        public bool IsDeleted { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tenant_handle")]
        public string? TenantHandle { get; set; }

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
        [global::Newtonsoft.Json.JsonProperty("role_name")]
        public string? RoleName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("permissions")]
        public global::System.Collections.Generic.IList<string>? Permissions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TenantForUser" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="organizationId"></param>
        /// <param name="createdAt"></param>
        /// <param name="displayName"></param>
        /// <param name="isPersonal"></param>
        /// <param name="isDeleted"></param>
        /// <param name="tenantHandle"></param>
        /// <param name="readOnly">
        /// Default Value: false
        /// </param>
        /// <param name="roleId"></param>
        /// <param name="roleName"></param>
        /// <param name="permissions"></param>
        public TenantForUser(
            global::System.Guid id,
            global::System.DateTime createdAt,
            string displayName,
            bool isPersonal,
            bool isDeleted,
            global::System.Guid? organizationId,
            string? tenantHandle,
            bool? readOnly,
            global::System.Guid? roleId,
            string? roleName,
            global::System.Collections.Generic.IList<string>? permissions)
        {
            this.Id = id;
            this.CreatedAt = createdAt;
            this.DisplayName = displayName ?? throw new global::System.ArgumentNullException(nameof(displayName));
            this.IsPersonal = isPersonal;
            this.IsDeleted = isDeleted;
            this.OrganizationId = organizationId;
            this.TenantHandle = tenantHandle;
            this.ReadOnly = readOnly;
            this.RoleId = roleId;
            this.RoleName = roleName;
            this.Permissions = permissions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TenantForUser" /> class.
        /// </summary>
        public TenantForUser()
        {
        }
    }
}