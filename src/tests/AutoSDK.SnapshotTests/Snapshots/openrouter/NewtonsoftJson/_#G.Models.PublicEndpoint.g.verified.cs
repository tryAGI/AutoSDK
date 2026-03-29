//HintName: G.Models.PublicEndpoint.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Information about a specific model endpoint
    /// </summary>
    public sealed partial class PublicEndpoint
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// The unique identifier for the model (permaslug)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ModelId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string ModelName { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("context_length", Required = global::Newtonsoft.Json.Required.Always)]
        public double ContextLength { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pricing", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.PublicEndpointPricing Pricing { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("provider_name", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ProviderName ProviderName { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tag", Required = global::Newtonsoft.Json.Required.Always)]
        public string Tag { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("quantization", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.PublicEndpointQuantization Quantization { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_completion_tokens")]
        public double? MaxCompletionTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_prompt_tokens")]
        public double? MaxPromptTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("supported_parameters", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.Parameter> SupportedParameters { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status")]
        public global::G.EndpointStatus? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("uptime_last_30m")]
        public double? UptimeLast30m { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("supports_implicit_caching", Required = global::Newtonsoft.Json.Required.Always)]
        public bool SupportsImplicitCaching { get; set; } = default!;

        /// <summary>
        /// Latency percentiles in milliseconds over the last 30 minutes. Latency measures time to first token. Only visible when authenticated with an API key or cookie; returns null for unauthenticated requests.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("latency_last_30m", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.PercentileStats LatencyLast30m { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("throughput_last_30m", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.PublicEndpointThroughputLast30M ThroughputLast30m { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicEndpoint" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="modelId">
        /// The unique identifier for the model (permaslug)
        /// </param>
        /// <param name="modelName"></param>
        /// <param name="contextLength"></param>
        /// <param name="pricing"></param>
        /// <param name="providerName"></param>
        /// <param name="tag"></param>
        /// <param name="quantization"></param>
        /// <param name="supportedParameters"></param>
        /// <param name="supportsImplicitCaching"></param>
        /// <param name="latencyLast30m">
        /// Latency percentiles in milliseconds over the last 30 minutes. Latency measures time to first token. Only visible when authenticated with an API key or cookie; returns null for unauthenticated requests.
        /// </param>
        /// <param name="throughputLast30m"></param>
        /// <param name="maxCompletionTokens"></param>
        /// <param name="maxPromptTokens"></param>
        /// <param name="status"></param>
        /// <param name="uptimeLast30m"></param>
        public PublicEndpoint(
            string name,
            string modelId,
            string modelName,
            double contextLength,
            global::G.PublicEndpointPricing pricing,
            global::G.ProviderName providerName,
            string tag,
            global::G.PublicEndpointQuantization quantization,
            global::System.Collections.Generic.IList<global::G.Parameter> supportedParameters,
            bool supportsImplicitCaching,
            global::G.PercentileStats latencyLast30m,
            global::G.PublicEndpointThroughputLast30M throughputLast30m,
            double? maxCompletionTokens,
            double? maxPromptTokens,
            global::G.EndpointStatus? status,
            double? uptimeLast30m)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.ModelId = modelId ?? throw new global::System.ArgumentNullException(nameof(modelId));
            this.ModelName = modelName ?? throw new global::System.ArgumentNullException(nameof(modelName));
            this.ContextLength = contextLength;
            this.Pricing = pricing ?? throw new global::System.ArgumentNullException(nameof(pricing));
            this.ProviderName = providerName;
            this.Tag = tag ?? throw new global::System.ArgumentNullException(nameof(tag));
            this.Quantization = quantization ?? throw new global::System.ArgumentNullException(nameof(quantization));
            this.MaxCompletionTokens = maxCompletionTokens;
            this.MaxPromptTokens = maxPromptTokens;
            this.SupportedParameters = supportedParameters ?? throw new global::System.ArgumentNullException(nameof(supportedParameters));
            this.Status = status;
            this.UptimeLast30m = uptimeLast30m;
            this.SupportsImplicitCaching = supportsImplicitCaching;
            this.LatencyLast30m = latencyLast30m ?? throw new global::System.ArgumentNullException(nameof(latencyLast30m));
            this.ThroughputLast30m = throughputLast30m ?? throw new global::System.ArgumentNullException(nameof(throughputLast30m));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicEndpoint" /> class.
        /// </summary>
        public PublicEndpoint()
        {
        }
    }
}