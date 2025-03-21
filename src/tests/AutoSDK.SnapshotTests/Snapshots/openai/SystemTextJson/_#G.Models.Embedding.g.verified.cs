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
        /// The embedding vector, which is a list of floats. The length of vector depends on the model as listed in the [embedding guide](/docs/guides/embeddings).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("embedding")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<double> Embedding1 { get; set; }

        /// <summary>
        /// The index of the embedding in the list of embeddings.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Index { get; set; }

        /// <summary>
        /// The object type, which is always "embedding".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.EmbeddingObjectJsonConverter))]
        public global::G.EmbeddingObject Object { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Embedding" /> class.
        /// </summary>
        /// <param name="embedding1">
        /// The embedding vector, which is a list of floats. The length of vector depends on the model as listed in the [embedding guide](/docs/guides/embeddings).
        /// </param>
        /// <param name="index">
        /// The index of the embedding in the list of embeddings.
        /// </param>
        /// <param name="object">
        /// The object type, which is always "embedding".
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Embedding(
            global::System.Collections.Generic.IList<double> embedding1,
            int index,
            global::G.EmbeddingObject @object)
        {
            this.Embedding1 = embedding1 ?? throw new global::System.ArgumentNullException(nameof(embedding1));
            this.Index = index;
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