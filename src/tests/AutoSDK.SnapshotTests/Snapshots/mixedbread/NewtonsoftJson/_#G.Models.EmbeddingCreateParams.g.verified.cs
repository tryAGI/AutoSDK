//HintName: G.Models.EmbeddingCreateParams.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Parameters for creating embeddings.
    /// </summary>
    public sealed partial class EmbeddingCreateParams
    {
        /// <summary>
        /// The model to use for creating embeddings.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model", Required = global::Newtonsoft.Json.Required.Always)]
        public string Model { get; set; } = default!;

        /// <summary>
        /// The input to create embeddings for.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("input", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AnyOf<string, global::System.Collections.Generic.IList<string>> Input { get; set; } = default!;

        /// <summary>
        /// The number of dimensions to use for the embeddings.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dimensions")]
        public int? Dimensions { get; set; }

        /// <summary>
        /// The prompt to use for the embedding creation.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// Whether to normalize the embeddings.<br/>
        /// Default Value: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("normalized")]
        public bool? Normalized { get; set; }

        /// <summary>
        /// The encoding format(s) of the embeddings. Can be a single format or a list of formats.<br/>
        /// Default Value: float
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("encoding_format")]
        public global::G.AnyOf<global::G.EncodingFormat3?, global::System.Collections.Generic.IList<global::G.EncodingFormat3>>? EncodingFormat { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbeddingCreateParams" /> class.
        /// </summary>
        /// <param name="model">
        /// The model to use for creating embeddings.
        /// </param>
        /// <param name="input">
        /// The input to create embeddings for.
        /// </param>
        /// <param name="dimensions">
        /// The number of dimensions to use for the embeddings.
        /// </param>
        /// <param name="prompt">
        /// The prompt to use for the embedding creation.
        /// </param>
        /// <param name="normalized">
        /// Whether to normalize the embeddings.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="encodingFormat">
        /// The encoding format(s) of the embeddings. Can be a single format or a list of formats.<br/>
        /// Default Value: float
        /// </param>
        public EmbeddingCreateParams(
            string model,
            global::G.AnyOf<string, global::System.Collections.Generic.IList<string>> input,
            int? dimensions,
            string? prompt,
            bool? normalized,
            global::G.AnyOf<global::G.EncodingFormat3?, global::System.Collections.Generic.IList<global::G.EncodingFormat3>>? encodingFormat)
        {
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Input = input;
            this.Dimensions = dimensions;
            this.Prompt = prompt;
            this.Normalized = normalized;
            this.EncodingFormat = encodingFormat;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbeddingCreateParams" /> class.
        /// </summary>
        public EmbeddingCreateParams()
        {
        }
    }
}