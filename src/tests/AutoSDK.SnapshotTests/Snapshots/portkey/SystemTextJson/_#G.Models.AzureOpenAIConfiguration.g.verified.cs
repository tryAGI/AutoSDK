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
        [global::System.Text.Json.Serialization.JsonPropertyName("azure_auth_mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AzureOpenAIConfigurationAzureAuthModeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.AzureOpenAIConfigurationAzureAuthMode AzureAuthMode { get; set; }

        /// <summary>
        /// Azure OpenAI resource name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("azure_resource_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AzureResourceName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("azure_deployment_config")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.AzureDeploymentConfig> AzureDeploymentConfig { get; set; }

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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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