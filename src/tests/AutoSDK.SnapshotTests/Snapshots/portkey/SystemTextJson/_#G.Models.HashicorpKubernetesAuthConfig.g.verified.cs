//HintName: G.Models.HashicorpKubernetesAuthConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class HashicorpKubernetesAuthConfig
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vault_auth_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.HashicorpKubernetesAuthConfigVaultAuthTypeJsonConverter))]
        public global::G.HashicorpKubernetesAuthConfigVaultAuthType VaultAuthType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vault_addr")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VaultAddr { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vault_role")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VaultRole { get; set; }

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
        /// Initializes a new instance of the <see cref="HashicorpKubernetesAuthConfig" /> class.
        /// </summary>
        /// <param name="vaultAddr"></param>
        /// <param name="vaultRole"></param>
        /// <param name="vaultAuthType"></param>
        /// <param name="vaultNamespace"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public HashicorpKubernetesAuthConfig(
            string vaultAddr,
            string vaultRole,
            global::G.HashicorpKubernetesAuthConfigVaultAuthType vaultAuthType,
            string? vaultNamespace)
        {
            this.VaultAuthType = vaultAuthType;
            this.VaultAddr = vaultAddr ?? throw new global::System.ArgumentNullException(nameof(vaultAddr));
            this.VaultRole = vaultRole ?? throw new global::System.ArgumentNullException(nameof(vaultRole));
            this.VaultNamespace = vaultNamespace;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HashicorpKubernetesAuthConfig" /> class.
        /// </summary>
        public HashicorpKubernetesAuthConfig()
        {
        }
    }
}