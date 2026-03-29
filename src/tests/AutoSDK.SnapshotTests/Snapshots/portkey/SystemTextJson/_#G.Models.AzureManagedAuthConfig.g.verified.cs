//HintName: G.Models.AzureManagedAuthConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AzureManagedAuthConfig
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("azure_auth_mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AzureManagedAuthConfigAzureAuthModeJsonConverter))]
        public global::G.AzureManagedAuthConfigAzureAuthMode AzureAuthMode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("azure_managed_client_id")]
        public string? AzureManagedClientId { get; set; }

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
        /// Initializes a new instance of the <see cref="AzureManagedAuthConfig" /> class.
        /// </summary>
        /// <param name="azureVaultUrl"></param>
        /// <param name="azureAuthMode"></param>
        /// <param name="azureManagedClientId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AzureManagedAuthConfig(
            string azureVaultUrl,
            global::G.AzureManagedAuthConfigAzureAuthMode azureAuthMode,
            string? azureManagedClientId)
        {
            this.AzureAuthMode = azureAuthMode;
            this.AzureManagedClientId = azureManagedClientId;
            this.AzureVaultUrl = azureVaultUrl ?? throw new global::System.ArgumentNullException(nameof(azureVaultUrl));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AzureManagedAuthConfig" /> class.
        /// </summary>
        public AzureManagedAuthConfig()
        {
        }
    }
}