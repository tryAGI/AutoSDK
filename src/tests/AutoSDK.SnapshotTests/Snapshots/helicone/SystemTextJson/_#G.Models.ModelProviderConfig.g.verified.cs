//HintName: G.Models.ModelProviderConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ModelProviderConfig
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pricing")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.ModelPricing> Pricing { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contextLength")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double ContextLength { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxCompletionTokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double MaxCompletionTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ptbEnabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool PtbEnabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        public string? Version { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unsupportedParameters")]
        public global::System.Collections.Generic.IList<global::G.StandardParameter>? UnsupportedParameters { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("providerModelId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProviderModelId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ModelProviderNameJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ModelProviderName Provider { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("author")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AuthorNameJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.AuthorName Author { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("supportedParameters")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.StandardParameter> SupportedParameters { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("supportedPlugins")]
        public global::System.Collections.Generic.IList<global::G.PluginId>? SupportedPlugins { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rateLimits")]
        public global::G.RateLimits? RateLimits { get; set; }

        /// <summary>
        /// Construct a type with a set of properties K of type T
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endpointConfigs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, global::G.EndpointConfig> EndpointConfigs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("crossRegion")]
        public bool? CrossRegion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("priority")]
        public double? Priority { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("quantization")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ModelProviderConfigQuantizationJsonConverter))]
        public global::G.ModelProviderConfigQuantization? Quantization { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("responseFormat")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ResponseFormatJsonConverter))]
        public global::G.ResponseFormat? ResponseFormat { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requireExplicitRouting")]
        public bool? RequireExplicitRouting { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("providerModelIdAliases")]
        public global::System.Collections.Generic.IList<string>? ProviderModelIdAliases { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelProviderConfig" /> class.
        /// </summary>
        /// <param name="pricing"></param>
        /// <param name="contextLength"></param>
        /// <param name="maxCompletionTokens"></param>
        /// <param name="ptbEnabled"></param>
        /// <param name="providerModelId"></param>
        /// <param name="provider"></param>
        /// <param name="author"></param>
        /// <param name="supportedParameters"></param>
        /// <param name="endpointConfigs">
        /// Construct a type with a set of properties K of type T
        /// </param>
        /// <param name="version"></param>
        /// <param name="unsupportedParameters"></param>
        /// <param name="supportedPlugins"></param>
        /// <param name="rateLimits"></param>
        /// <param name="crossRegion"></param>
        /// <param name="priority"></param>
        /// <param name="quantization"></param>
        /// <param name="responseFormat"></param>
        /// <param name="requireExplicitRouting"></param>
        /// <param name="providerModelIdAliases"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModelProviderConfig(
            global::System.Collections.Generic.IList<global::G.ModelPricing> pricing,
            double contextLength,
            double maxCompletionTokens,
            bool ptbEnabled,
            string providerModelId,
            global::G.ModelProviderName provider,
            global::G.AuthorName author,
            global::System.Collections.Generic.IList<global::G.StandardParameter> supportedParameters,
            global::System.Collections.Generic.Dictionary<string, global::G.EndpointConfig> endpointConfigs,
            string? version,
            global::System.Collections.Generic.IList<global::G.StandardParameter>? unsupportedParameters,
            global::System.Collections.Generic.IList<global::G.PluginId>? supportedPlugins,
            global::G.RateLimits? rateLimits,
            bool? crossRegion,
            double? priority,
            global::G.ModelProviderConfigQuantization? quantization,
            global::G.ResponseFormat? responseFormat,
            bool? requireExplicitRouting,
            global::System.Collections.Generic.IList<string>? providerModelIdAliases)
        {
            this.Pricing = pricing ?? throw new global::System.ArgumentNullException(nameof(pricing));
            this.ContextLength = contextLength;
            this.MaxCompletionTokens = maxCompletionTokens;
            this.PtbEnabled = ptbEnabled;
            this.Version = version;
            this.UnsupportedParameters = unsupportedParameters;
            this.ProviderModelId = providerModelId ?? throw new global::System.ArgumentNullException(nameof(providerModelId));
            this.Provider = provider;
            this.Author = author;
            this.SupportedParameters = supportedParameters ?? throw new global::System.ArgumentNullException(nameof(supportedParameters));
            this.SupportedPlugins = supportedPlugins;
            this.RateLimits = rateLimits;
            this.EndpointConfigs = endpointConfigs ?? throw new global::System.ArgumentNullException(nameof(endpointConfigs));
            this.CrossRegion = crossRegion;
            this.Priority = priority;
            this.Quantization = quantization;
            this.ResponseFormat = responseFormat;
            this.RequireExplicitRouting = requireExplicitRouting;
            this.ProviderModelIdAliases = providerModelIdAliases;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelProviderConfig" /> class.
        /// </summary>
        public ModelProviderConfig()
        {
        }
    }
}