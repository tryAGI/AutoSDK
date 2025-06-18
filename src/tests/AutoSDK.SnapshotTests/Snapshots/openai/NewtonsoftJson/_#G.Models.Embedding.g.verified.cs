//HintName: G.Models.Embedding.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Represents an embedding vector returned by embedding endpoint.
    /// </summary>
    public sealed partial class Embedding
    {
        /// <summary>
        /// The index of the embedding in the list of embeddings.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("index", Required = global::Newtonsoft.Json.Required.Always)]
        public int Index { get; set; } = default!;

        /// <summary>
        /// The embedding vector, which is a list of floats. The length of vector depends on the model as listed in the [embedding guide](/docs/guides/embeddings).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("embedding", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<float> Embedding1 { get; set; } = default!;

        /// <summary>
        /// The object type, which is always "embedding".
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("object")]
        public global::G.EmbeddingObject Object { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Embedding" /> class.
        /// </summary>
        /// <param name="index">
        /// The index of the embedding in the list of embeddings.
        /// </param>
        /// <param name="embedding1">
        /// The embedding vector, which is a list of floats. The length of vector depends on the model as listed in the [embedding guide](/docs/guides/embeddings).
        /// </param>
        /// <param name="object">
        /// The object type, which is always "embedding".
        /// </param>
        public Embedding(
            int index,
            global::System.Collections.Generic.IList<float> embedding1,
            global::G.EmbeddingObject @object)
        {
            this.Index = index;
            this.Embedding1 = embedding1 ?? throw new global::System.ArgumentNullException(nameof(embedding1));
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Embedding" /> class.
        /// </summary>
        public Embedding()
        {
        }
    }
}