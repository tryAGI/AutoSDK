//HintName: G.Models.HashicorpAppRoleAuthConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class HashicorpAppRoleAuthConfig
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("vault_auth_type")]
        public global::G.HashicorpAppRoleAuthConfigVaultAuthType VaultAuthType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("vault_addr", Required = global::Newtonsoft.Json.Required.Always)]
        public string VaultAddr { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("vault_role_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string VaultRoleId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("vault_secret_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string VaultSecretId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("vault_namespace")]
        public string? VaultNamespace { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HashicorpAppRoleAuthConfig" /> class.
        /// </summary>
        /// <param name="vaultAddr"></param>
        /// <param name="vaultRoleId"></param>
        /// <param name="vaultSecretId"></param>
        /// <param name="vaultAuthType"></param>
        /// <param name="vaultNamespace"></param>
        public HashicorpAppRoleAuthConfig(
            string vaultAddr,
            string vaultRoleId,
            string vaultSecretId,
            global::G.HashicorpAppRoleAuthConfigVaultAuthType vaultAuthType,
            string? vaultNamespace)
        {
            this.VaultAuthType = vaultAuthType;
            this.VaultAddr = vaultAddr ?? throw new global::System.ArgumentNullException(nameof(vaultAddr));
            this.VaultRoleId = vaultRoleId ?? throw new global::System.ArgumentNullException(nameof(vaultRoleId));
            this.VaultSecretId = vaultSecretId ?? throw new global::System.ArgumentNullException(nameof(vaultSecretId));
            this.VaultNamespace = vaultNamespace;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HashicorpAppRoleAuthConfig" /> class.
        /// </summary>
        public HashicorpAppRoleAuthConfig()
        {
        }
    }
}