//HintName: G.Models.EndpointConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EndpointConfig
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
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("providerModelId")]
        public string? ProviderModelId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pricing")]
        public global::System.Collections.Generic.IList<global::G.ModelPricing>? Pricing { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("contextLength")]
        public double? ContextLength { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("maxCompletionTokens")]
        public double? MaxCompletionTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ptbEnabled")]
        public bool? PtbEnabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("version")]
        public string? Version { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("rateLimits")]
        public global::G.RateLimits? RateLimits { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("priority")]
        public double? Priority { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EndpointConfig" /> class.
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
        /// <param name="providerModelId"></param>
        /// <param name="pricing"></param>
        /// <param name="contextLength"></param>
        /// <param name="maxCompletionTokens"></param>
        /// <param name="ptbEnabled"></param>
        /// <param name="version"></param>
        /// <param name="rateLimits"></param>
        /// <param name="priority"></param>
        public EndpointConfig(
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
            string? heliconeModelId,
            string? providerModelId,
            global::System.Collections.Generic.IList<global::G.ModelPricing>? pricing,
            double? contextLength,
            double? maxCompletionTokens,
            bool? ptbEnabled,
            string? version,
            global::G.RateLimits? rateLimits,
            double? priority)
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
            this.ProviderModelId = providerModelId;
            this.Pricing = pricing;
            this.ContextLength = contextLength;
            this.MaxCompletionTokens = maxCompletionTokens;
            this.PtbEnabled = ptbEnabled;
            this.Version = version;
            this.RateLimits = rateLimits;
            this.Priority = priority;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EndpointConfig" /> class.
        /// </summary>
        public EndpointConfig()
        {
        }
    }
}