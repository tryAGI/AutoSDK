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
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UpdatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("temp_key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool TempKey { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("soft_delete")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool SoftDelete { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OrganizationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key_permissions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string KeyPermissions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("governance")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Governance { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_key_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ApiKeyName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_key_hash")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ApiKeyHash { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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