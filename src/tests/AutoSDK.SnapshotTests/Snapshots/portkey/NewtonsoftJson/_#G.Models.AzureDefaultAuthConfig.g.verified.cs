//HintName: G.Models.AzureDefaultAuthConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AzureDefaultAuthConfig
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("azure_auth_mode")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.AzureDefaultAuthConfigAzureAuthModeJsonConverter))]
        public global::G.AzureDefaultAuthConfigAzureAuthMode AzureAuthMode { get; set; }

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
        /// Initializes a new instance of the <see cref="AzureDefaultAuthConfig" /> class.
        /// </summary>
        /// <param name="azureVaultUrl"></param>
        /// <param name="azureAuthMode"></param>
        public AzureDefaultAuthConfig(
            string azureVaultUrl,
            global::G.AzureDefaultAuthConfigAzureAuthMode azureAuthMode)
        {
            this.AzureAuthMode = azureAuthMode;
            this.AzureVaultUrl = azureVaultUrl ?? throw new global::System.ArgumentNullException(nameof(azureVaultUrl));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AzureDefaultAuthConfig" /> class.
        /// </summary>
        public AzureDefaultAuthConfig()
        {
        }
    }
}