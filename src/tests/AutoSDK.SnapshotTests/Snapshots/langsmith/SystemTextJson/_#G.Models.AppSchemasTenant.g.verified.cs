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
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_id")]
        public global::System.Guid? OrganizationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("display_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DisplayName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_personal")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsPersonal { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_deleted")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsDeleted { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tenant_handle")]
        public string? TenantHandle { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AppSchemasTenant" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="organizationId"></param>
        /// <param name="createdAt"></param>
        /// <param name="displayName"></param>
        /// <param name="isPersonal"></param>
        /// <param name="isDeleted"></param>
        /// <param name="tenantHandle"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AppSchemasTenant(
            global::System.Guid id,
            global::System.DateTime createdAt,
            string displayName,
            bool isPersonal,
            bool isDeleted,
            global::System.Guid? organizationId,
            string? tenantHandle)
        {
            this.Id = id;
            this.CreatedAt = createdAt;
            this.DisplayName = displayName ?? throw new global::System.ArgumentNullException(nameof(displayName));
            this.IsPersonal = isPersonal;
            this.IsDeleted = isDeleted;
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