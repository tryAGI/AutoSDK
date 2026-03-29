//HintName: G.Models.AzureDeploymentConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AzureDeploymentConfig
    {
        /// <summary>
        /// Alias for the deployment
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("alias")]
        public string? Alias { get; set; }

        /// <summary>
        /// Azure API version
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("azure_api_version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AzureApiVersion { get; set; }

        /// <summary>
        /// Azure deployment name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("azure_deployment_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AzureDeploymentName { get; set; }

        /// <summary>
        /// Whether this is the default deployment<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_default")]
        public bool? IsDefault { get; set; }

        /// <summary>
        /// Azure model slug
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("azure_model_slug")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AzureModelSlug { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AzureDeploymentConfig" /> class.
        /// </summary>
        /// <param name="azureApiVersion">
        /// Azure API version
        /// </param>
        /// <param name="azureDeploymentName">
        /// Azure deployment name
        /// </param>
        /// <param name="azureModelSlug">
        /// Azure model slug
        /// </param>
        /// <param name="alias">
        /// Alias for the deployment
        /// </param>
        /// <param name="isDefault">
        /// Whether this is the default deployment<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AzureDeploymentConfig(
            string azureApiVersion,
            string azureDeploymentName,
            string azureModelSlug,
            string? alias,
            bool? isDefault)
        {
            this.Alias = alias;
            this.AzureApiVersion = azureApiVersion ?? throw new global::System.ArgumentNullException(nameof(azureApiVersion));
            this.AzureDeploymentName = azureDeploymentName ?? throw new global::System.ArgumentNullException(nameof(azureDeploymentName));
            this.IsDefault = isDefault;
            this.AzureModelSlug = azureModelSlug ?? throw new global::System.ArgumentNullException(nameof(azureModelSlug));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AzureDeploymentConfig" /> class.
        /// </summary>
        public AzureDeploymentConfig()
        {
        }
    }
}