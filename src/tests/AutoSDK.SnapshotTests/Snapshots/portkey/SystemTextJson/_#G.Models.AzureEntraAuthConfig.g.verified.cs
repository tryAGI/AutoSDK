//HintName: G.Models.AzureEntraAuthConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AzureEntraAuthConfig
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("azure_auth_mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AzureEntraAuthConfigAzureAuthModeJsonConverter))]
        public global::G.AzureEntraAuthConfigAzureAuthMode AzureAuthMode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("azure_entra_tenant_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AzureEntraTenantId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("azure_entra_client_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AzureEntraClientId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("azure_entra_client_secret")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AzureEntraClientSecret { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("azure_vault_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AzureVaultUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AzureEntraAuthConfig" /> class.
        /// </summary>
        /// <param name="azureEntraTenantId"></param>
        /// <param name="azureEntraClientId"></param>
        /// <param name="azureEntraClientSecret"></param>
        /// <param name="azureVaultUrl"></param>
        /// <param name="azureAuthMode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AzureEntraAuthConfig(
            string azureEntraTenantId,
            string azureEntraClientId,
            string azureEntraClientSecret,
            string azureVaultUrl,
            global::G.AzureEntraAuthConfigAzureAuthMode azureAuthMode)
        {
            this.AzureAuthMode = azureAuthMode;
            this.AzureEntraTenantId = azureEntraTenantId ?? throw new global::System.ArgumentNullException(nameof(azureEntraTenantId));
            this.AzureEntraClientId = azureEntraClientId ?? throw new global::System.ArgumentNullException(nameof(azureEntraClientId));
            this.AzureEntraClientSecret = azureEntraClientSecret ?? throw new global::System.ArgumentNullException(nameof(azureEntraClientSecret));
            this.AzureVaultUrl = azureVaultUrl ?? throw new global::System.ArgumentNullException(nameof(azureVaultUrl));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AzureEntraAuthConfig" /> class.
        /// </summary>
        public AzureEntraAuthConfig()
        {
        }
    }
}