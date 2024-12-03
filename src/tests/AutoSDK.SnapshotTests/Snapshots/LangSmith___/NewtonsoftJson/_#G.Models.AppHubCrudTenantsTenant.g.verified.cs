//HintName: G.Models.AppHubCrudTenantsTenant.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AppHubCrudTenantsTenant
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("display_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string DisplayName { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

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
        /// Initializes a new instance of the <see cref="AppHubCrudTenantsTenant" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="displayName"></param>
        /// <param name="createdAt"></param>
        /// <param name="tenantHandle"></param>
        public AppHubCrudTenantsTenant(
            global::System.Guid id,
            string displayName,
            global::System.DateTime createdAt,
            string? tenantHandle)
        {
            this.Id = id;
            this.DisplayName = displayName ?? throw new global::System.ArgumentNullException(nameof(displayName));
            this.CreatedAt = createdAt;
            this.TenantHandle = tenantHandle;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppHubCrudTenantsTenant" /> class.
        /// </summary>
        public AppHubCrudTenantsTenant()
        {
        }
    }
}