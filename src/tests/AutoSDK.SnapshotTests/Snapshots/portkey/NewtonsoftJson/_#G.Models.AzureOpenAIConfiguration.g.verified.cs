//HintName: G.Models.AzureOpenAIConfiguration.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AzureOpenAIConfiguration
    {
        /// <summary>
        /// Authentication mode for Azure
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("azure_auth_mode", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AzureOpenAIConfigurationAzureAuthMode AzureAuthMode { get; set; } = default!;

        /// <summary>
        /// Azure OpenAI resource name
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("azure_resource_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string AzureResourceName { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("azure_deployment_config", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.AzureDeploymentConfig> AzureDeploymentConfig { get; set; } = default!;

        /// <summary>
        /// Azure AD tenant ID (required for entra auth)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("azure_entra_tenant_id")]
        public string? AzureEntraTenantId { get; set; }

        /// <summary>
        /// Azure AD client ID (required for entra auth)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("azure_entra_client_id")]
        public string? AzureEntraClientId { get; set; }

        /// <summary>
        /// Azure AD client secret (required for entra auth)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("azure_entra_client_secret")]
        public string? AzureEntraClientSecret { get; set; }

        /// <summary>
        /// Managed identity client ID (optional for managed auth)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("azure_managed_client_id")]
        public string? AzureManagedClientId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AzureOpenAIConfiguration" /> class.
        /// </summary>
        /// <param name="azureAuthMode">
        /// Authentication mode for Azure
        /// </param>
        /// <param name="azureResourceName">
        /// Azure OpenAI resource name
        /// </param>
        /// <param name="azureDeploymentConfig"></param>
        /// <param name="azureEntraTenantId">
        /// Azure AD tenant ID (required for entra auth)
        /// </param>
        /// <param name="azureEntraClientId">
        /// Azure AD client ID (required for entra auth)
        /// </param>
        /// <param name="azureEntraClientSecret">
        /// Azure AD client secret (required for entra auth)
        /// </param>
        /// <param name="azureManagedClientId">
        /// Managed identity client ID (optional for managed auth)
        /// </param>
        public AzureOpenAIConfiguration(
            global::G.AzureOpenAIConfigurationAzureAuthMode azureAuthMode,
            string azureResourceName,
            global::System.Collections.Generic.IList<global::G.AzureDeploymentConfig> azureDeploymentConfig,
            string? azureEntraTenantId,
            string? azureEntraClientId,
            string? azureEntraClientSecret,
            string? azureManagedClientId)
        {
            this.AzureAuthMode = azureAuthMode;
            this.AzureResourceName = azureResourceName ?? throw new global::System.ArgumentNullException(nameof(azureResourceName));
            this.AzureDeploymentConfig = azureDeploymentConfig ?? throw new global::System.ArgumentNullException(nameof(azureDeploymentConfig));
            this.AzureEntraTenantId = azureEntraTenantId;
            this.AzureEntraClientId = azureEntraClientId;
            this.AzureEntraClientSecret = azureEntraClientSecret;
            this.AzureManagedClientId = azureManagedClientId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AzureOpenAIConfiguration" /> class.
        /// </summary>
        public AzureOpenAIConfiguration()
        {
        }
    }
}