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
        [global::System.Text.Json.Serialization.JsonPropertyName("region")]
        public string? Region { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("location")]
        public string? Location { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectId")]
        public string? ProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("baseUri")]
        public string? BaseUri { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deploymentName")]
        public string? DeploymentName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resourceName")]
        public string? ResourceName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("apiVersion")]
        public string? ApiVersion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("crossRegion")]
        public bool? CrossRegion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gatewayMapping")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.BodyMappingTypeJsonConverter))]
        public global::G.BodyMappingType? GatewayMapping { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modelName")]
        public string? ModelName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("heliconeModelId")]
        public string? HeliconeModelId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("providerModelId")]
        public string? ProviderModelId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pricing")]
        public global::System.Collections.Generic.IList<global::G.ModelPricing>? Pricing { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contextLength")]
        public double? ContextLength { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxCompletionTokens")]
        public double? MaxCompletionTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ptbEnabled")]
        public bool? PtbEnabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        public string? Version { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rateLimits")]
        public global::G.RateLimits? RateLimits { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("priority")]
        public double? Priority { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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