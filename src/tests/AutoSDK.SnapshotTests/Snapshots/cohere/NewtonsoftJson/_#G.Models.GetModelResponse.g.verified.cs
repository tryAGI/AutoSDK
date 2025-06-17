//HintName: G.Models.GetModelResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Contains information about the model and which API endpoints it can be used with.
    /// </summary>
    public sealed partial class GetModelResponse
    {
        /// <summary>
        /// The maximum number of tokens that the model can process in a single request. Note that not all of these tokens are always available due to special tokens and preambles that Cohere has added by default.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("context_length")]
        public double? ContextLength { get; set; }

        /// <summary>
        /// The API endpoints that the model is default to.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("default_endpoints")]
        public global::System.Collections.Generic.IList<global::G.CompatibleEndpoint>? DefaultEndpoints { get; set; }

        /// <summary>
        /// The API endpoints that the model is compatible with.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("endpoints")]
        public global::System.Collections.Generic.IList<global::G.CompatibleEndpoint>? Endpoints { get; set; }

        /// <summary>
        /// The features that the model supports.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("features")]
        public global::System.Collections.Generic.IList<string>? Features { get; set; }

        /// <summary>
        /// Whether the model has been fine-tuned or not.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("finetuned")]
        public bool? Finetuned { get; set; }

        /// <summary>
        /// Specify this name in the `model` parameter of API requests to use your chosen model.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Whether the model supports image inputs or not.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("supports_vision")]
        public bool? SupportsVision { get; set; }

        /// <summary>
        /// Public URL to the tokenizer's configuration file.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tokenizer_url")]
        public string? TokenizerUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetModelResponse" /> class.
        /// </summary>
        /// <param name="contextLength">
        /// The maximum number of tokens that the model can process in a single request. Note that not all of these tokens are always available due to special tokens and preambles that Cohere has added by default.
        /// </param>
        /// <param name="defaultEndpoints">
        /// The API endpoints that the model is default to.
        /// </param>
        /// <param name="endpoints">
        /// The API endpoints that the model is compatible with.
        /// </param>
        /// <param name="features">
        /// The features that the model supports.
        /// </param>
        /// <param name="finetuned">
        /// Whether the model has been fine-tuned or not.
        /// </param>
        /// <param name="name">
        /// Specify this name in the `model` parameter of API requests to use your chosen model.
        /// </param>
        /// <param name="supportsVision">
        /// Whether the model supports image inputs or not.
        /// </param>
        /// <param name="tokenizerUrl">
        /// Public URL to the tokenizer's configuration file.
        /// </param>
        public GetModelResponse(
            double? contextLength,
            global::System.Collections.Generic.IList<global::G.CompatibleEndpoint>? defaultEndpoints,
            global::System.Collections.Generic.IList<global::G.CompatibleEndpoint>? endpoints,
            global::System.Collections.Generic.IList<string>? features,
            bool? finetuned,
            string? name,
            bool? supportsVision,
            string? tokenizerUrl)
        {
            this.ContextLength = contextLength;
            this.DefaultEndpoints = defaultEndpoints;
            this.Endpoints = endpoints;
            this.Features = features;
            this.Finetuned = finetuned;
            this.Name = name;
            this.SupportsVision = supportsVision;
            this.TokenizerUrl = tokenizerUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetModelResponse" /> class.
        /// </summary>
        public GetModelResponse()
        {
        }
    }
}