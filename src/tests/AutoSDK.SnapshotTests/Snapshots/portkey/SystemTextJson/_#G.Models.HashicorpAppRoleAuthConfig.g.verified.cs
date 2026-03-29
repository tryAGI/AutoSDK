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
        [global::System.Text.Json.Serialization.JsonPropertyName("vault_auth_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.HashicorpAppRoleAuthConfigVaultAuthTypeJsonConverter))]
        public global::G.HashicorpAppRoleAuthConfigVaultAuthType VaultAuthType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vault_addr")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VaultAddr { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vault_role_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VaultRoleId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vault_secret_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VaultSecretId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vault_namespace")]
        public string? VaultNamespace { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HashicorpAppRoleAuthConfig" /> class.
        /// </summary>
        /// <param name="vaultAddr"></param>
        /// <param name="vaultRoleId"></param>
        /// <param name="vaultSecretId"></param>
        /// <param name="vaultAuthType"></param>
        /// <param name="vaultNamespace"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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