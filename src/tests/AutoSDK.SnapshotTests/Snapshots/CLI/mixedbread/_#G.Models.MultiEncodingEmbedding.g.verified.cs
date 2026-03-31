//HintName: G.Models.MultiEncodingEmbedding.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MultiEncodingEmbedding
    {
        /// <summary>
        /// The encoded embedding data by encoding format.Returned, if more than one encoding format is used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("embedding")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.MultipleEncodingsEmbeddingItem Embedding { get; set; }

        /// <summary>
        /// The index of the embedding.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Index { get; set; }

        /// <summary>
        /// The object type of the embedding.<br/>
        /// Default Value: embedding_dict
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string? Object { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MultiEncodingEmbedding" /> class.
        /// </summary>
        /// <param name="embedding">
        /// The encoded embedding data by encoding format.Returned, if more than one encoding format is used.
        /// </param>
        /// <param name="index">
        /// The index of the embedding.
        /// </param>
        /// <param name="object">
        /// The object type of the embedding.<br/>
        /// Default Value: embedding_dict
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MultiEncodingEmbedding(
            global::G.MultipleEncodingsEmbeddingItem embedding,
            int index,
            string? @object)
        {
            this.Embedding = embedding ?? throw new global::System.ArgumentNullException(nameof(embedding));
            this.Index = index;
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MultiEncodingEmbedding" /> class.
        /// </summary>
        public MultiEncodingEmbedding()
        {
        }
    }
}