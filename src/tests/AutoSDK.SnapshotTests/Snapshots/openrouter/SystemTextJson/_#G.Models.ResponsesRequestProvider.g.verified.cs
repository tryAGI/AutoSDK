//HintName: G.Models.ResponsesRequestProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// When multiple model providers are available, optionally indicate your routing preference.
    /// </summary>
    public sealed partial class ResponsesRequestProvider
    {
        /// <summary>
        /// Whether to allow backup providers to serve requests<br/>
        /// - true: (default) when the primary provider (or your custom providers in "order") is unavailable, use the next best provider.<br/>
        /// - false: use only the primary/custom provider, and return the upstream error if it's unavailable.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allow_fallbacks")]
        public bool? AllowFallbacks { get; set; }

        /// <summary>
        /// Whether to filter providers to only those that support the parameters you've provided. If this setting is omitted or set to false, then providers will receive only the parameters they support, and ignore the rest.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("require_parameters")]
        public bool? RequireParameters { get; set; }

        /// <summary>
        /// Data collection setting. If no available model provider meets the requirement, your request will return an error.<br/>
        /// - allow: (default) allow providers which store user data non-transiently and may train on it<br/>
        /// - deny: use only providers which do not collect user data.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data_collection")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.DataCollectionJsonConverter))]
        public global::G.DataCollection? DataCollection { get; set; }

        /// <summary>
        /// Whether to restrict routing to only ZDR (Zero Data Retention) endpoints. When true, only endpoints that do not retain prompts will be used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("zdr")]
        public bool? Zdr { get; set; }

        /// <summary>
        /// Whether to restrict routing to only models that allow text distillation. When true, only models where the author has allowed distillation will be used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enforce_distillable_text")]
        public bool? EnforceDistillableText { get; set; }

        /// <summary>
        /// An ordered list of provider slugs. The router will attempt to use the first provider in the subset of this list that supports your requested model, and fall back to the next if it is unavailable. If no providers are available, the request will fail with an error message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("order")]
        public global::System.Collections.Generic.IList<global::G.ResponsesRequestProviderOrderItems>? Order { get; set; }

        /// <summary>
        /// List of provider slugs to allow. If provided, this list is merged with your account-wide allowed provider settings for this request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("only")]
        public global::System.Collections.Generic.IList<global::G.ResponsesRequestProviderOnlyItems>? Only { get; set; }

        /// <summary>
        /// List of provider slugs to ignore. If provided, this list is merged with your account-wide ignored provider settings for this request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ignore")]
        public global::System.Collections.Generic.IList<global::G.ResponsesRequestProviderIgnoreItems>? Ignore { get; set; }

        /// <summary>
        /// A list of quantization levels to filter the provider by.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("quantizations")]
        public global::System.Collections.Generic.IList<global::G.Quantization>? Quantizations { get; set; }

        /// <summary>
        /// The sorting strategy to use for this request, if "order" is not specified. When set, no load balancing is performed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sort")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ResponsesRequestProviderSortJsonConverter))]
        public global::G.ResponsesRequestProviderSort? Sort { get; set; }

        /// <summary>
        /// The object specifying the maximum price you want to pay for this request. USD price per million tokens, for prompt and completion.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_price")]
        public global::G.ResponsesRequestProviderMaxPrice? MaxPrice { get; set; }

        /// <summary>
        /// Preferred minimum throughput (in tokens per second). Can be a number (applies to p50) or an object with percentile-specific cutoffs. Endpoints below the threshold(s) may still be used, but are deprioritized in routing. When using fallback models, this may cause a fallback model to be used instead of the primary model if it meets the threshold.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("preferred_min_throughput")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.PreferredMinThroughputJsonConverter))]
        public global::G.PreferredMinThroughput? PreferredMinThroughput { get; set; }

        /// <summary>
        /// Preferred maximum latency (in seconds). Can be a number (applies to p50) or an object with percentile-specific cutoffs. Endpoints above the threshold(s) may still be used, but are deprioritized in routing. When using fallback models, this may cause a fallback model to be used instead of the primary model if it meets the threshold.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("preferred_max_latency")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.PreferredMaxLatencyJsonConverter))]
        public global::G.PreferredMaxLatency? PreferredMaxLatency { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsesRequestProvider" /> class.
        /// </summary>
        /// <param name="allowFallbacks">
        /// Whether to allow backup providers to serve requests<br/>
        /// - true: (default) when the primary provider (or your custom providers in "order") is unavailable, use the next best provider.<br/>
        /// - false: use only the primary/custom provider, and return the upstream error if it's unavailable.
        /// </param>
        /// <param name="requireParameters">
        /// Whether to filter providers to only those that support the parameters you've provided. If this setting is omitted or set to false, then providers will receive only the parameters they support, and ignore the rest.
        /// </param>
        /// <param name="dataCollection">
        /// Data collection setting. If no available model provider meets the requirement, your request will return an error.<br/>
        /// - allow: (default) allow providers which store user data non-transiently and may train on it<br/>
        /// - deny: use only providers which do not collect user data.
        /// </param>
        /// <param name="zdr">
        /// Whether to restrict routing to only ZDR (Zero Data Retention) endpoints. When true, only endpoints that do not retain prompts will be used.
        /// </param>
        /// <param name="enforceDistillableText">
        /// Whether to restrict routing to only models that allow text distillation. When true, only models where the author has allowed distillation will be used.
        /// </param>
        /// <param name="order">
        /// An ordered list of provider slugs. The router will attempt to use the first provider in the subset of this list that supports your requested model, and fall back to the next if it is unavailable. If no providers are available, the request will fail with an error message.
        /// </param>
        /// <param name="only">
        /// List of provider slugs to allow. If provided, this list is merged with your account-wide allowed provider settings for this request.
        /// </param>
        /// <param name="ignore">
        /// List of provider slugs to ignore. If provided, this list is merged with your account-wide ignored provider settings for this request.
        /// </param>
        /// <param name="quantizations">
        /// A list of quantization levels to filter the provider by.
        /// </param>
        /// <param name="sort">
        /// The sorting strategy to use for this request, if "order" is not specified. When set, no load balancing is performed.
        /// </param>
        /// <param name="maxPrice">
        /// The object specifying the maximum price you want to pay for this request. USD price per million tokens, for prompt and completion.
        /// </param>
        /// <param name="preferredMinThroughput">
        /// Preferred minimum throughput (in tokens per second). Can be a number (applies to p50) or an object with percentile-specific cutoffs. Endpoints below the threshold(s) may still be used, but are deprioritized in routing. When using fallback models, this may cause a fallback model to be used instead of the primary model if it meets the threshold.
        /// </param>
        /// <param name="preferredMaxLatency">
        /// Preferred maximum latency (in seconds). Can be a number (applies to p50) or an object with percentile-specific cutoffs. Endpoints above the threshold(s) may still be used, but are deprioritized in routing. When using fallback models, this may cause a fallback model to be used instead of the primary model if it meets the threshold.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponsesRequestProvider(
            bool? allowFallbacks,
            bool? requireParameters,
            global::G.DataCollection? dataCollection,
            bool? zdr,
            bool? enforceDistillableText,
            global::System.Collections.Generic.IList<global::G.ResponsesRequestProviderOrderItems>? order,
            global::System.Collections.Generic.IList<global::G.ResponsesRequestProviderOnlyItems>? only,
            global::System.Collections.Generic.IList<global::G.ResponsesRequestProviderIgnoreItems>? ignore,
            global::System.Collections.Generic.IList<global::G.Quantization>? quantizations,
            global::G.ResponsesRequestProviderSort? sort,
            global::G.ResponsesRequestProviderMaxPrice? maxPrice,
            global::G.PreferredMinThroughput? preferredMinThroughput,
            global::G.PreferredMaxLatency? preferredMaxLatency)
        {
            this.AllowFallbacks = allowFallbacks;
            this.RequireParameters = requireParameters;
            this.DataCollection = dataCollection;
            this.Zdr = zdr;
            this.EnforceDistillableText = enforceDistillableText;
            this.Order = order;
            this.Only = only;
            this.Ignore = ignore;
            this.Quantizations = quantizations;
            this.Sort = sort;
            this.MaxPrice = maxPrice;
            this.PreferredMinThroughput = preferredMinThroughput;
            this.PreferredMaxLatency = preferredMaxLatency;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsesRequestProvider" /> class.
        /// </summary>
        public ResponsesRequestProvider()
        {
        }
    }
}