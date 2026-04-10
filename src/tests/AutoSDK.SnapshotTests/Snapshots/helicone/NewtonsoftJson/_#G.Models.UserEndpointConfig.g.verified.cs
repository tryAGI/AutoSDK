//HintName: G.Models.UserEndpointConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UserEndpointConfig
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("region")]
        public string? Region { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("location")]
        public string? Location { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("projectId")]
        public string? ProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("baseUri")]
        public string? BaseUri { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("deploymentName")]
        public string? DeploymentName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("resourceName")]
        public string? ResourceName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("apiVersion")]
        public string? ApiVersion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("crossRegion")]
        public bool? CrossRegion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("gatewayMapping")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.BodyMappingTypeJsonConverter))]
        public global::G.BodyMappingType? GatewayMapping { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("modelName")]
        public string? ModelName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("heliconeModelId")]
        public string? HeliconeModelId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEndpointConfig" /> class.
        /// </summary>
        /// <param name="region"></param>
        /// <param name="location"></param>
        /// <param name="projectId"></param>
        /// <param name="baseUri"></param>
        /// <param name="deploymentName"></param>
        /// <param name="resourceName"></param>
        /// <param name="apiVersion"></param>
        /// <param name="crossRegion"></param>
        /// <param name="gatewayMapping"></param>
        /// <param name="modelName"></param>
        /// <param name="heliconeModelId"></param>
        public UserEndpointConfig(
            string? region,
            string? location,
            string? projectId,
            string? baseUri,
            string? deploymentName,
            string? resourceName,
            string? apiVersion,
            bool? crossRegion,
            global::G.BodyMappingType? gatewayMapping,
            string? modelName,
            string? heliconeModelId)
        {
            this.Region = region;
            this.Location = location;
            this.ProjectId = projectId;
            this.BaseUri = baseUri;
            this.DeploymentName = deploymentName;
            this.ResourceName = resourceName;
            this.ApiVersion = apiVersion;
            this.CrossRegion = crossRegion;
            this.GatewayMapping = gatewayMapping;
            this.ModelName = modelName;
            this.HeliconeModelId = heliconeModelId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEndpointConfig" /> class.
        /// </summary>
        public UserEndpointConfig()
        {
        }
    }
}