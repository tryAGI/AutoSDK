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
        [global::System.Text.Json.Serialization.JsonPropertyName("azure_auth_mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AzureDefaultAuthConfigAzureAuthModeJsonConverter))]
        public global::G.AzureDefaultAuthConfigAzureAuthMode AzureAuthMode { get; set; }

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
        /// Initializes a new instance of the <see cref="AzureDefaultAuthConfig" /> class.
        /// </summary>
        /// <param name="azureVaultUrl"></param>
        /// <param name="azureAuthMode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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