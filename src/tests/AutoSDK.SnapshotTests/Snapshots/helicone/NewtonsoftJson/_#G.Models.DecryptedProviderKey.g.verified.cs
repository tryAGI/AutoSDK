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
        [global::Newtonsoft.Json.JsonProperty("cuid")]
        public string? Cuid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("provider_secret_key")]
        public string? ProviderSecretKey { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("provider_key_name")]
        public string? ProviderKeyName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("provider_name")]
        public string? ProviderName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("provider_key")]
        public string? ProviderKey { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("org_id")]
        public string? OrgId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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