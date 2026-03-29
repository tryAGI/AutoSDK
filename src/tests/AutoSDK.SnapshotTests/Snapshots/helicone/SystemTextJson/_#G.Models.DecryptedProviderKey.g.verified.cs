//HintName: G.Models.DecryptedProviderKey.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DecryptedProviderKey
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cuid")]
        public string? Cuid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider_secret_key")]
        public string? ProviderSecretKey { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider_key_name")]
        public string? ProviderKeyName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider_name")]
        public string? ProviderName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider_key")]
        public string? ProviderKey { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("org_id")]
        public string? OrgId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DecryptedProviderKey" /> class.
        /// </summary>
        /// <param name="cuid"></param>
        /// <param name="providerSecretKey"></param>
        /// <param name="providerKeyName"></param>
        /// <param name="providerName"></param>
        /// <param name="providerKey"></param>
        /// <param name="orgId"></param>
        /// <param name="id"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DecryptedProviderKey(
            string? cuid,
            string? providerSecretKey,
            string? providerKeyName,
            string? providerName,
            string? providerKey,
            string? orgId,
            string? id)
        {
            this.Cuid = cuid;
            this.ProviderSecretKey = providerSecretKey;
            this.ProviderKeyName = providerKeyName;
            this.ProviderName = providerName;
            this.ProviderKey = providerKey;
            this.OrgId = orgId;
            this.Id = id;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DecryptedProviderKey" /> class.
        /// </summary>
        public DecryptedProviderKey()
        {
        }
    }
}