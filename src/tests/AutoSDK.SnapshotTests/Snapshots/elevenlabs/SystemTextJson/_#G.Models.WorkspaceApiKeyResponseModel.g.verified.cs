//HintName: G.Models.WorkspaceApiKeyResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WorkspaceApiKeyResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hint")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Hint { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string KeyId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("service_account_user_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ServiceAccountUserId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at_unix")]
        public int? CreatedAtUnix { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_disabled")]
        public bool? IsDisabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("permissions")]
        public global::System.Collections.Generic.IList<global::G.PermissionType>? Permissions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("character_limit")]
        public int? CharacterLimit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("character_count")]
        public int? CharacterCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hashed_xi_api_key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string HashedXiApiKey { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkspaceApiKeyResponseModel" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="hint"></param>
        /// <param name="keyId"></param>
        /// <param name="serviceAccountUserId"></param>
        /// <param name="hashedXiApiKey"></param>
        /// <param name="createdAtUnix"></param>
        /// <param name="isDisabled">
        /// Default Value: false
        /// </param>
        /// <param name="permissions"></param>
        /// <param name="characterLimit"></param>
        /// <param name="characterCount"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WorkspaceApiKeyResponseModel(
            string name,
            string hint,
            string keyId,
            string serviceAccountUserId,
            string hashedXiApiKey,
            int? createdAtUnix,
            bool? isDisabled,
            global::System.Collections.Generic.IList<global::G.PermissionType>? permissions,
            int? characterLimit,
            int? characterCount)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Hint = hint ?? throw new global::System.ArgumentNullException(nameof(hint));
            this.KeyId = keyId ?? throw new global::System.ArgumentNullException(nameof(keyId));
            this.ServiceAccountUserId = serviceAccountUserId ?? throw new global::System.ArgumentNullException(nameof(serviceAccountUserId));
            this.CreatedAtUnix = createdAtUnix;
            this.IsDisabled = isDisabled;
            this.Permissions = permissions;
            this.CharacterLimit = characterLimit;
            this.CharacterCount = characterCount;
            this.HashedXiApiKey = hashedXiApiKey ?? throw new global::System.ArgumentNullException(nameof(hashedXiApiKey));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkspaceApiKeyResponseModel" /> class.
        /// </summary>
        public WorkspaceApiKeyResponseModel()
        {
        }
    }
}