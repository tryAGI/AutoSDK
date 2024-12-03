//HintName: G.Models.AppSchemasTenant.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Tenant schema.
    /// </summary>
    public sealed partial class AppSchemasTenant
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
        [global::Newtonsoft.Json.JsonProperty("tenant_handle")]
        public string? TenantHandle { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AppSchemasTenant" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="organizationId"></param>
        /// <param name="createdAt"></param>
        /// <param name="displayName"></param>
        /// <param name="isPersonal"></param>
        /// <param name="tenantHandle"></param>
        public AppSchemasTenant(
            global::System.Guid id,
            global::System.DateTime createdAt,
            string displayName,
            bool isPersonal,
            global::System.Guid? organizationId,
            string? tenantHandle)
        {
            this.Id = id;
            this.CreatedAt = createdAt;
            this.DisplayName = displayName ?? throw new global::System.ArgumentNullException(nameof(displayName));
            this.IsPersonal = isPersonal;
            this.OrganizationId = organizationId;
            this.TenantHandle = tenantHandle;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppSchemasTenant" /> class.
        /// </summary>
        public AppSchemasTenant()
        {
        }
    }
}