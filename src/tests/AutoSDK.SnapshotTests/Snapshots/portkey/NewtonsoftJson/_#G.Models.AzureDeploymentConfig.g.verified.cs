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
        [global::Newtonsoft.Json.JsonProperty("alias")]
        public string? Alias { get; set; }

        /// <summary>
        /// Azure API version
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("azure_api_version", Required = global::Newtonsoft.Json.Required.Always)]
        public string AzureApiVersion { get; set; } = default!;

        /// <summary>
        /// Azure deployment name
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("azure_deployment_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string AzureDeploymentName { get; set; } = default!;

        /// <summary>
        /// Whether this is the default deployment<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_default")]
        public bool? IsDefault { get; set; }

        /// <summary>
        /// Azure model slug
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("azure_model_slug", Required = global::Newtonsoft.Json.Required.Always)]
        public string AzureModelSlug { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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