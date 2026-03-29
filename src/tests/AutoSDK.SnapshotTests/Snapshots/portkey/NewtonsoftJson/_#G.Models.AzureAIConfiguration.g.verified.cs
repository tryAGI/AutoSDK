//HintName: G.Models.AzureAIConfiguration.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AzureAIConfiguration
    {
        /// <summary>
        /// Authentication mode for Azure AI
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("azure_auth_mode", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AzureAIConfigurationAzureAuthMode AzureAuthMode { get; set; } = default!;

        /// <summary>
        /// Azure AI Foundry URL
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("azure_foundry_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string AzureFoundryUrl { get; set; } = default!;

        /// <summary>
        /// Azure API version
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("azure_api_version")]
        public string? AzureApiVersion { get; set; }

        /// <summary>
        /// Azure deployment name
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("azure_deployment_name")]
        public string? AzureDeploymentName { get; set; }

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
        /// Initializes a new instance of the <see cref="AzureAIConfiguration" /> class.
        /// </summary>
        /// <param name="azureAuthMode">
        /// Authentication mode for Azure AI
        /// </param>
        /// <param name="azureFoundryUrl">
        /// Azure AI Foundry URL
        /// </param>
        /// <param name="azureApiVersion">
        /// Azure API version
        /// </param>
        /// <param name="azureDeploymentName">
        /// Azure deployment name
        /// </param>
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
        public AzureAIConfiguration(
            global::G.AzureAIConfigurationAzureAuthMode azureAuthMode,
            string azureFoundryUrl,
            string? azureApiVersion,
            string? azureDeploymentName,
            string? azureEntraTenantId,
            string? azureEntraClientId,
            string? azureEntraClientSecret,
            string? azureManagedClientId)
        {
            this.AzureAuthMode = azureAuthMode;
            this.AzureFoundryUrl = azureFoundryUrl ?? throw new global::System.ArgumentNullException(nameof(azureFoundryUrl));
            this.AzureApiVersion = azureApiVersion;
            this.AzureDeploymentName = azureDeploymentName;
            this.AzureEntraTenantId = azureEntraTenantId;
            this.AzureEntraClientId = azureEntraClientId;
            this.AzureEntraClientSecret = azureEntraClientSecret;
            this.AzureManagedClientId = azureManagedClientId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AzureAIConfiguration" /> class.
        /// </summary>
        public AzureAIConfiguration()
        {
        }
    }
}