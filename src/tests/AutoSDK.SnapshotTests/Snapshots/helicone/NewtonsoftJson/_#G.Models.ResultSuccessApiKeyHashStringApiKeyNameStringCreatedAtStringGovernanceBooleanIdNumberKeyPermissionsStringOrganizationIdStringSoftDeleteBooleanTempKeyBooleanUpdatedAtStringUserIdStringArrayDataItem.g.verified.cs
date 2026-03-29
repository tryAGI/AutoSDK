//HintName: G.Models.ResultSuccessApiKeyHashStringApiKeyNameStringCreatedAtStringGovernanceBooleanIdNumberKeyPermissionsStringOrganizationIdStringSoftDeleteBooleanTempKeyBooleanUpdatedAtStringUserIdStringArrayDataItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResultSuccessApiKeyHashStringApiKeyNameStringCreatedAtStringGovernanceBooleanIdNumberKeyPermissionsStringOrganizationIdStringSoftDeleteBooleanTempKeyBooleanUpdatedAtStringUserIdStringArrayDataItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string UserId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updated_at", Required = global::Newtonsoft.Json.Required.Always)]
        public string UpdatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("temp_key", Required = global::Newtonsoft.Json.Required.Always)]
        public bool TempKey { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("soft_delete", Required = global::Newtonsoft.Json.Required.Always)]
        public bool SoftDelete { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("organization_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string OrganizationId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("key_permissions", Required = global::Newtonsoft.Json.Required.Always)]
        public string KeyPermissions { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public double Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("governance", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Governance { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public string CreatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("api_key_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string ApiKeyName { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("api_key_hash", Required = global::Newtonsoft.Json.Required.Always)]
        public string ApiKeyHash { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResultSuccessApiKeyHashStringApiKeyNameStringCreatedAtStringGovernanceBooleanIdNumberKeyPermissionsStringOrganizationIdStringSoftDeleteBooleanTempKeyBooleanUpdatedAtStringUserIdStringArrayDataItem" /> class.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="updatedAt"></param>
        /// <param name="tempKey"></param>
        /// <param name="softDelete"></param>
        /// <param name="organizationId"></param>
        /// <param name="keyPermissions"></param>
        /// <param name="id"></param>
        /// <param name="governance"></param>
        /// <param name="createdAt"></param>
        /// <param name="apiKeyName"></param>
        /// <param name="apiKeyHash"></param>
        public ResultSuccessApiKeyHashStringApiKeyNameStringCreatedAtStringGovernanceBooleanIdNumberKeyPermissionsStringOrganizationIdStringSoftDeleteBooleanTempKeyBooleanUpdatedAtStringUserIdStringArrayDataItem(
            string userId,
            string updatedAt,
            bool tempKey,
            bool softDelete,
            string organizationId,
            string keyPermissions,
            double id,
            bool governance,
            string createdAt,
            string apiKeyName,
            string apiKeyHash)
        {
            this.UserId = userId ?? throw new global::System.ArgumentNullException(nameof(userId));
            this.UpdatedAt = updatedAt ?? throw new global::System.ArgumentNullException(nameof(updatedAt));
            this.TempKey = tempKey;
            this.SoftDelete = softDelete;
            this.OrganizationId = organizationId ?? throw new global::System.ArgumentNullException(nameof(organizationId));
            this.KeyPermissions = keyPermissions ?? throw new global::System.ArgumentNullException(nameof(keyPermissions));
            this.Id = id;
            this.Governance = governance;
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.ApiKeyName = apiKeyName ?? throw new global::System.ArgumentNullException(nameof(apiKeyName));
            this.ApiKeyHash = apiKeyHash ?? throw new global::System.ArgumentNullException(nameof(apiKeyHash));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResultSuccessApiKeyHashStringApiKeyNameStringCreatedAtStringGovernanceBooleanIdNumberKeyPermissionsStringOrganizationIdStringSoftDeleteBooleanTempKeyBooleanUpdatedAtStringUserIdStringArrayDataItem" /> class.
        /// </summary>
        public ResultSuccessApiKeyHashStringApiKeyNameStringCreatedAtStringGovernanceBooleanIdNumberKeyPermissionsStringOrganizationIdStringSoftDeleteBooleanTempKeyBooleanUpdatedAtStringUserIdStringArrayDataItem()
        {
        }
    }
}