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
        [global::Newtonsoft.Json.JsonProperty("azure_auth_mode")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.AzureEntraAuthConfigAzureAuthModeJsonConverter))]
        public global::G.AzureEntraAuthConfigAzureAuthMode AzureAuthMode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("azure_entra_tenant_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string AzureEntraTenantId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("azure_entra_client_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string AzureEntraClientId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("azure_entra_client_secret", Required = global::Newtonsoft.Json.Required.Always)]
        public string AzureEntraClientSecret { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("azure_vault_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string AzureVaultUrl { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AzureEntraAuthConfig" /> class.
        /// </summary>
        /// <param name="azureEntraTenantId"></param>
        /// <param name="azureEntraClientId"></param>
        /// <param name="azureEntraClientSecret"></param>
        /// <param name="azureVaultUrl"></param>
        /// <param name="azureAuthMode"></param>
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