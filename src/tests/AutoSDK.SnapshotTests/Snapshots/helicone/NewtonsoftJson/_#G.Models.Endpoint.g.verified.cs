//HintName: G.Models.Endpoint.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Endpoint
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
        [global::Newtonsoft.Json.JsonProperty("modelConfig", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ModelProviderConfig ModelConfig { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("userConfig", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.UserEndpointConfig UserConfig { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("provider", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ModelProviderNameJsonConverter))]
        public global::G.ModelProviderName Provider { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("author", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.AuthorNameJsonConverter))]
        public global::G.AuthorName Author { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("providerModelId", Required = global::Newtonsoft.Json.Required.Always)]
        public string ProviderModelId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("supportedParameters", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.StandardParameter> SupportedParameters { get; set; } = default!;

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
        /// Initializes a new instance of the <see cref="Endpoint" /> class.
        /// </summary>
        /// <param name="pricing"></param>
        /// <param name="contextLength"></param>
        /// <param name="maxCompletionTokens"></param>
        /// <param name="ptbEnabled"></param>
        /// <param name="modelConfig"></param>
        /// <param name="userConfig"></param>
        /// <param name="provider"></param>
        /// <param name="author"></param>
        /// <param name="providerModelId"></param>
        /// <param name="supportedParameters"></param>
        /// <param name="version"></param>
        /// <param name="unsupportedParameters"></param>
        /// <param name="priority"></param>
        public Endpoint(
            global::System.Collections.Generic.IList<global::G.ModelPricing> pricing,
            double contextLength,
            double maxCompletionTokens,
            bool ptbEnabled,
            global::G.ModelProviderConfig modelConfig,
            global::G.UserEndpointConfig userConfig,
            global::G.ModelProviderName provider,
            global::G.AuthorName author,
            string providerModelId,
            global::System.Collections.Generic.IList<global::G.StandardParameter> supportedParameters,
            string? version,
            global::System.Collections.Generic.IList<global::G.StandardParameter>? unsupportedParameters,
            double? priority)
        {
            this.Pricing = pricing ?? throw new global::System.ArgumentNullException(nameof(pricing));
            this.ContextLength = contextLength;
            this.MaxCompletionTokens = maxCompletionTokens;
            this.PtbEnabled = ptbEnabled;
            this.Version = version;
            this.UnsupportedParameters = unsupportedParameters;
            this.ModelConfig = modelConfig ?? throw new global::System.ArgumentNullException(nameof(modelConfig));
            this.UserConfig = userConfig ?? throw new global::System.ArgumentNullException(nameof(userConfig));
            this.Provider = provider;
            this.Author = author;
            this.ProviderModelId = providerModelId ?? throw new global::System.ArgumentNullException(nameof(providerModelId));
            this.SupportedParameters = supportedParameters ?? throw new global::System.ArgumentNullException(nameof(supportedParameters));
            this.Priority = priority;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Endpoint" /> class.
        /// </summary>
        public Endpoint()
        {
        }
    }
}