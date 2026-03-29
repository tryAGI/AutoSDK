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
        [global::System.Text.Json.Serialization.JsonPropertyName("modelConfig")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ModelProviderConfig ModelConfig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userConfig")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.UserEndpointConfig UserConfig { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("providerModelId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProviderModelId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("supportedParameters")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.StandardParameter> SupportedParameters { get; set; }

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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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