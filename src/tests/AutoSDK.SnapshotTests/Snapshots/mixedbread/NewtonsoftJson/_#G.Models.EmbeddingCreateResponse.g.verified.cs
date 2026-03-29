//HintName: G.Models.EmbeddingCreateResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EmbeddingCreateResponse
    {
        /// <summary>
        /// The usage of the model
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("usage", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.Usage Usage { get; set; } = default!;

        /// <summary>
        /// The model used
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model", Required = global::Newtonsoft.Json.Required.Always)]
        public string Model { get; set; } = default!;

        /// <summary>
        /// The created embeddings.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AnyOf<global::System.Collections.Generic.IList<global::G.Embedding>, global::System.Collections.Generic.IList<global::G.MultiEncodingEmbedding>> Data { get; set; } = default!;

        /// <summary>
        /// The object type of the response<br/>
        /// Default Value: list
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("object")]
        public string? Object { get; set; }

        /// <summary>
        /// Whether the embeddings are normalized.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("normalized", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Normalized { get; set; } = default!;

        /// <summary>
        /// The encoding formats of the embeddings.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("encoding_format", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AnyOf<global::G.EncodingFormat3?, global::System.Collections.Generic.IList<global::G.EncodingFormat3>> EncodingFormat { get; set; } = default!;

        /// <summary>
        /// The number of dimensions used for the embeddings.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dimensions")]
        public int? Dimensions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbeddingCreateResponse" /> class.
        /// </summary>
        /// <param name="usage">
        /// The usage of the model
        /// </param>
        /// <param name="model">
        /// The model used
        /// </param>
        /// <param name="data">
        /// The created embeddings.
        /// </param>
        /// <param name="normalized">
        /// Whether the embeddings are normalized.
        /// </param>
        /// <param name="encodingFormat">
        /// The encoding formats of the embeddings.
        /// </param>
        /// <param name="object">
        /// The object type of the response<br/>
        /// Default Value: list
        /// </param>
        /// <param name="dimensions">
        /// The number of dimensions used for the embeddings.
        /// </param>
        public EmbeddingCreateResponse(
            global::G.Usage usage,
            string model,
            global::G.AnyOf<global::System.Collections.Generic.IList<global::G.Embedding>, global::System.Collections.Generic.IList<global::G.MultiEncodingEmbedding>> data,
            bool normalized,
            global::G.AnyOf<global::G.EncodingFormat3?, global::System.Collections.Generic.IList<global::G.EncodingFormat3>> encodingFormat,
            string? @object,
            int? dimensions)
        {
            this.Usage = usage ?? throw new global::System.ArgumentNullException(nameof(usage));
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Data = data;
            this.Object = @object;
            this.Normalized = normalized;
            this.EncodingFormat = encodingFormat;
            this.Dimensions = dimensions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbeddingCreateResponse" /> class.
        /// </summary>
        public EmbeddingCreateResponse()
        {
        }
    }
}