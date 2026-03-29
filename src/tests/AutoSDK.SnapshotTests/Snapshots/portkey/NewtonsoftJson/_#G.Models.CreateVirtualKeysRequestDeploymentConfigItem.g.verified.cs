//HintName: G.Models.CreateVirtualKeysRequestDeploymentConfigItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateVirtualKeysRequestDeploymentConfigItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("apiVersion", Required = global::Newtonsoft.Json.Required.Always)]
        public string ApiVersion { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("alias")]
        public string? Alias { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_default")]
        public bool? IsDefault { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("deploymentName", Required = global::Newtonsoft.Json.Required.Always)]
        public string DeploymentName { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVirtualKeysRequestDeploymentConfigItem" /> class.
        /// </summary>
        /// <param name="apiVersion"></param>
        /// <param name="deploymentName"></param>
        /// <param name="alias"></param>
        /// <param name="isDefault"></param>
        public CreateVirtualKeysRequestDeploymentConfigItem(
            string apiVersion,
            string deploymentName,
            string? alias,
            bool? isDefault)
        {
            this.ApiVersion = apiVersion ?? throw new global::System.ArgumentNullException(nameof(apiVersion));
            this.Alias = alias;
            this.IsDefault = isDefault;
            this.DeploymentName = deploymentName ?? throw new global::System.ArgumentNullException(nameof(deploymentName));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVirtualKeysRequestDeploymentConfigItem" /> class.
        /// </summary>
        public CreateVirtualKeysRequestDeploymentConfigItem()
        {
        }
    }
}