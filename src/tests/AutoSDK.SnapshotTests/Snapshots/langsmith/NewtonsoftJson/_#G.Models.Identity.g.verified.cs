//HintName: G.Models.Identity.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Identity
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("organization_id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid OrganizationId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tenant_id")]
        public global::System.Guid? TenantId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user_id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid UserId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ls_user_id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid LsUserId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("read_only", Required = global::Newtonsoft.Json.Required.Always)]
        public bool ReadOnly { get; set; } = default!;

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
        [global::Newtonsoft.Json.JsonProperty("access_scope")]
        public global::G.AccessScope? AccessScope { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Identity" /> class.
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
        public Identity(
            global::System.Guid id,
            global::System.Guid organizationId,
            global::System.DateTime createdAt,
            global::System.Guid userId,
            global::System.Guid lsUserId,
            bool readOnly,
            global::System.Guid? tenantId,
            global::System.Guid? roleId,
            string? roleName,
            global::G.AccessScope? accessScope)
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
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Identity" /> class.
        /// </summary>
        public Identity()
        {
        }
    }
}