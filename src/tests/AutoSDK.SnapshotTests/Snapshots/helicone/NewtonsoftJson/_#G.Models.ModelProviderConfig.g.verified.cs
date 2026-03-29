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
        [global::Newtonsoft.Json.JsonProperty("pricing", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.ModelPricing> Pricing { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("contextLength", Required = global::Newtonsoft.Json.Required.Always)]
        public double ContextLength { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("maxCompletionTokens", Required = global::Newtonsoft.Json.Required.Always)]
        public double MaxCompletionTokens { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ptbEnabled", Required = global::Newtonsoft.Json.Required.Always)]
        public bool PtbEnabled { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("version")]
        public string? Version { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("unsupportedParameters")]
        public global::System.Collections.Generic.IList<global::G.StandardParameter>? UnsupportedParameters { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("providerModelId", Required = global::Newtonsoft.Json.Required.Always)]
        public string ProviderModelId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("provider", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ModelProviderName Provider { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("author", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AuthorName Author { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("supportedParameters", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.StandardParameter> SupportedParameters { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("supportedPlugins")]
        public global::System.Collections.Generic.IList<global::G.PluginId>? SupportedPlugins { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("rateLimits")]
        public global::G.RateLimits? RateLimits { get; set; }

        /// <summary>
        /// Construct a type with a set of properties K of type T
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("endpointConfigs", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.Dictionary<string, global::G.EndpointConfig> EndpointConfigs { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("crossRegion")]
        public bool? CrossRegion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("priority")]
        public double? Priority { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("quantization")]
        public global::G.ModelProviderConfigQuantization? Quantization { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("responseFormat")]
        public global::G.ResponseFormat? ResponseFormat { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("requireExplicitRouting")]
        public bool? RequireExplicitRouting { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("providerModelIdAliases")]
        public global::System.Collections.Generic.IList<string>? ProviderModelIdAliases { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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