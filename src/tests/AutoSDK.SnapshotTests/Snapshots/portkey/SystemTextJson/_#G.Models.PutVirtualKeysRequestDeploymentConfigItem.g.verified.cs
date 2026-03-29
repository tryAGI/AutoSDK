//HintName: G.Models.PutVirtualKeysRequestDeploymentConfigItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PutVirtualKeysRequestDeploymentConfigItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("apiVersion")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ApiVersion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("alias")]
        public string? Alias { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_default")]
        public bool? IsDefault { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deploymentName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DeploymentName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PutVirtualKeysRequestDeploymentConfigItem" /> class.
        /// </summary>
        /// <param name="apiVersion"></param>
        /// <param name="deploymentName"></param>
        /// <param name="alias"></param>
        /// <param name="isDefault"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PutVirtualKeysRequestDeploymentConfigItem(
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
        /// Initializes a new instance of the <see cref="PutVirtualKeysRequestDeploymentConfigItem" /> class.
        /// </summary>
        public PutVirtualKeysRequestDeploymentConfigItem()
        {
        }
    }
}