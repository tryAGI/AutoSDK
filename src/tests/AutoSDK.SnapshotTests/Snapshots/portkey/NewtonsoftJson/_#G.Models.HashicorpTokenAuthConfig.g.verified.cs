//HintName: G.Models.HashicorpTokenAuthConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class HashicorpTokenAuthConfig
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("vault_auth_type")]
        public global::G.HashicorpTokenAuthConfigVaultAuthType VaultAuthType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("vault_addr", Required = global::Newtonsoft.Json.Required.Always)]
        public string VaultAddr { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("vault_token", Required = global::Newtonsoft.Json.Required.Always)]
        public string VaultToken { get; set; } = default!;

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
        /// Initializes a new instance of the <see cref="HashicorpTokenAuthConfig" /> class.
        /// </summary>
        /// <param name="vaultAddr"></param>
        /// <param name="vaultToken"></param>
        /// <param name="vaultAuthType"></param>
        /// <param name="vaultNamespace"></param>
        public HashicorpTokenAuthConfig(
            string vaultAddr,
            string vaultToken,
            global::G.HashicorpTokenAuthConfigVaultAuthType vaultAuthType,
            string? vaultNamespace)
        {
            this.VaultAuthType = vaultAuthType;
            this.VaultAddr = vaultAddr ?? throw new global::System.ArgumentNullException(nameof(vaultAddr));
            this.VaultToken = vaultToken ?? throw new global::System.ArgumentNullException(nameof(vaultToken));
            this.VaultNamespace = vaultNamespace;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HashicorpTokenAuthConfig" /> class.
        /// </summary>
        public HashicorpTokenAuthConfig()
        {
        }
    }
}