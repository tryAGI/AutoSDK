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
        [global::System.Text.Json.Serialization.JsonPropertyName("azure_auth_mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AzureAIConfigurationAzureAuthModeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.AzureAIConfigurationAzureAuthMode AzureAuthMode { get; set; }

        /// <summary>
        /// Azure AI Foundry URL
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("azure_foundry_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AzureFoundryUrl { get; set; }

        /// <summary>
        /// Azure API version
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("azure_api_version")]
        public string? AzureApiVersion { get; set; }

        /// <summary>
        /// Azure deployment name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("azure_deployment_name")]
        public string? AzureDeploymentName { get; set; }

        /// <summary>
        /// Azure AD tenant ID (required for entra auth)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("azure_entra_tenant_id")]
        public string? AzureEntraTenantId { get; set; }

        /// <summary>
        /// Azure AD client ID (required for entra auth)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("azure_entra_client_id")]
        public string? AzureEntraClientId { get; set; }

        /// <summary>
        /// Azure AD client secret (required for entra auth)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("azure_entra_client_secret")]
        public string? AzureEntraClientSecret { get; set; }

        /// <summary>
        /// Managed identity client ID (optional for managed auth)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("azure_managed_client_id")]
        public string? AzureManagedClientId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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