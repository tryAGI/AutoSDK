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
        [global::System.Text.Json.Serialization.JsonPropertyName("index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Index { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("embedding")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverter<global::System.Collections.Generic.IList<double>, string>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.OneOf<global::System.Collections.Generic.IList<double>, string> Embedding1 { get; set; }

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
        /// <param name="index">
        /// The index of the embedding in the list of embeddings.
        /// </param>
        /// <param name="embedding1"></param>
        /// <param name="object">
        /// The object type, which is always "embedding".
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Embedding(
            int index,
            global::G.OneOf<global::System.Collections.Generic.IList<double>, string> embedding1,
            global::G.EmbeddingObject @object)
        {
            this.Index = index;
            this.Embedding1 = embedding1;
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