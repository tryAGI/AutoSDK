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
        [global::System.Text.Json.Serialization.JsonPropertyName("vault_auth_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.HashicorpTokenAuthConfigVaultAuthTypeJsonConverter))]
        public global::G.HashicorpTokenAuthConfigVaultAuthType VaultAuthType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vault_addr")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VaultAddr { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vault_token")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VaultToken { get; set; }

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
        /// Initializes a new instance of the <see cref="HashicorpTokenAuthConfig" /> class.
        /// </summary>
        /// <param name="vaultAddr"></param>
        /// <param name="vaultToken"></param>
        /// <param name="vaultAuthType"></param>
        /// <param name="vaultNamespace"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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