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
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The unique identifier for the model (permaslug)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ModelId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ModelName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("context_length")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double ContextLength { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pricing")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.PublicEndpointPricing Pricing { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider_name")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ProviderNameJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ProviderName ProviderName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tag")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Tag { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("quantization")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.PublicEndpointQuantization Quantization { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_completion_tokens")]
        public double? MaxCompletionTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_prompt_tokens")]
        public double? MaxPromptTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("supported_parameters")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.Parameter> SupportedParameters { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.EndpointStatusJsonConverter))]
        public global::G.EndpointStatus? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uptime_last_30m")]
        public double? UptimeLast30m { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("supports_implicit_caching")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool SupportsImplicitCaching { get; set; }

        /// <summary>
        /// Latency percentiles in milliseconds over the last 30 minutes. Latency measures time to first token. Only visible when authenticated with an API key or cookie; returns null for unauthenticated requests.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("latency_last_30m")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.PercentileStats LatencyLast30m { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("throughput_last_30m")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.PublicEndpointThroughputLast30M ThroughputLast30m { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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