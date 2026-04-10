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
        [global::Newtonsoft.Json.JsonProperty("azure_auth_mode")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.AzureManagedAuthConfigAzureAuthModeJsonConverter))]
        public global::G.AzureManagedAuthConfigAzureAuthMode AzureAuthMode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("azure_managed_client_id")]
        public string? AzureManagedClientId { get; set; }

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
        /// Initializes a new instance of the <see cref="AzureManagedAuthConfig" /> class.
        /// </summary>
        /// <param name="azureVaultUrl"></param>
        /// <param name="azureAuthMode"></param>
        /// <param name="azureManagedClientId"></param>
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