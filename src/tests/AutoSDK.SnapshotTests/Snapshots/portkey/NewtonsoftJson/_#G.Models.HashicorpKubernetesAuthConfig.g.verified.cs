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
        [global::Newtonsoft.Json.JsonProperty("vault_auth_type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.HashicorpKubernetesAuthConfigVaultAuthTypeJsonConverter))]
        public global::G.HashicorpKubernetesAuthConfigVaultAuthType VaultAuthType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("vault_addr", Required = global::Newtonsoft.Json.Required.Always)]
        public string VaultAddr { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("vault_role", Required = global::Newtonsoft.Json.Required.Always)]
        public string VaultRole { get; set; } = default!;

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
        /// Initializes a new instance of the <see cref="HashicorpKubernetesAuthConfig" /> class.
        /// </summary>
        /// <param name="vaultAddr"></param>
        /// <param name="vaultRole"></param>
        /// <param name="vaultAuthType"></param>
        /// <param name="vaultNamespace"></param>
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