//HintName: G.Models.Embedding.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Embedding
    {
        /// <summary>
        /// The encoded embedding.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("embedding")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.EmbeddingItemJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.EmbeddingItem Embedding1 { get; set; }

        /// <summary>
        /// The index of the embedding.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Index { get; set; }

        /// <summary>
        /// The object type of the embedding.<br/>
        /// Default Value: embedding
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string? Object { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Embedding" /> class.
        /// </summary>
        /// <param name="embedding1">
        /// The encoded embedding.
        /// </param>
        /// <param name="index">
        /// The index of the embedding.
        /// </param>
        /// <param name="object">
        /// The object type of the embedding.<br/>
        /// Default Value: embedding
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Embedding(
            global::G.EmbeddingItem embedding1,
            int index,
            string? @object)
        {
            this.Embedding1 = embedding1;
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