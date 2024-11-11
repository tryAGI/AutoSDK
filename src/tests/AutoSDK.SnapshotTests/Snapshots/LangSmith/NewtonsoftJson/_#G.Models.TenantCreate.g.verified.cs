//HintName: G.Models.TenantCreate.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Creation model for the tenant.
    /// </summary>
    public sealed partial class TenantCreate
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("organization_id")]
        public global::System.Guid? OrganizationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("display_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string DisplayName { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tenant_handle")]
        public string? TenantHandle { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_personal")]
        public bool? IsPersonal { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TenantCreate" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="organizationId"></param>
        /// <param name="displayName"></param>
        /// <param name="tenantHandle"></param>
        /// <param name="isPersonal">
        /// Default Value: false
        /// </param>
        public TenantCreate(
            string displayName,
            global::System.Guid? id,
            global::System.Guid? organizationId,
            string? tenantHandle,
            bool? isPersonal)
        {
            this.DisplayName = displayName ?? throw new global::System.ArgumentNullException(nameof(displayName));
            this.Id = id;
            this.OrganizationId = organizationId;
            this.TenantHandle = tenantHandle;
            this.IsPersonal = isPersonal;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TenantCreate" /> class.
        /// </summary>
        public TenantCreate()
        {
        }
    }
}