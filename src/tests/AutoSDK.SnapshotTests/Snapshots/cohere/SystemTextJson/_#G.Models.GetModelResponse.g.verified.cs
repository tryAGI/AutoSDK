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
        /// Specify this name in the `model` parameter of API requests to use your chosen model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The API endpoints that the model is compatible with.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endpoints")]
        public global::System.Collections.Generic.IList<global::G.CompatibleEndpoint>? Endpoints { get; set; }

        /// <summary>
        /// Whether the model has been fine-tuned or not.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("finetuned")]
        public bool? Finetuned { get; set; }

        /// <summary>
        /// The maximum number of tokens that the model can process in a single request. Note that not all of these tokens are always available due to special tokens and preambles that Cohere has added by default.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("context_length")]
        public double? ContextLength { get; set; }

        /// <summary>
        /// Public URL to the tokenizer's configuration file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tokenizer_url")]
        public string? TokenizerUrl { get; set; }

        /// <summary>
        /// The API endpoints that the model is default to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default_endpoints")]
        public global::System.Collections.Generic.IList<global::G.CompatibleEndpoint>? DefaultEndpoints { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetModelResponse" /> class.
        /// </summary>
        /// <param name="name">
        /// Specify this name in the `model` parameter of API requests to use your chosen model.
        /// </param>
        /// <param name="endpoints">
        /// The API endpoints that the model is compatible with.
        /// </param>
        /// <param name="finetuned">
        /// Whether the model has been fine-tuned or not.
        /// </param>
        /// <param name="contextLength">
        /// The maximum number of tokens that the model can process in a single request. Note that not all of these tokens are always available due to special tokens and preambles that Cohere has added by default.
        /// </param>
        /// <param name="tokenizerUrl">
        /// Public URL to the tokenizer's configuration file.
        /// </param>
        /// <param name="defaultEndpoints">
        /// The API endpoints that the model is default to.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetModelResponse(
            string? name,
            global::System.Collections.Generic.IList<global::G.CompatibleEndpoint>? endpoints,
            bool? finetuned,
            double? contextLength,
            string? tokenizerUrl,
            global::System.Collections.Generic.IList<global::G.CompatibleEndpoint>? defaultEndpoints)
        {
            this.Name = name;
            this.Endpoints = endpoints;
            this.Finetuned = finetuned;
            this.ContextLength = contextLength;
            this.TokenizerUrl = tokenizerUrl;
            this.DefaultEndpoints = defaultEndpoints;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetModelResponse" /> class.
        /// </summary>
        public GetModelResponse()
        {
        }
    }
}