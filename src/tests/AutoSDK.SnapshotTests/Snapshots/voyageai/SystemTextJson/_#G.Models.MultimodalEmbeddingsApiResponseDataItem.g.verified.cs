//HintName: G.Models.MultimodalEmbeddingsApiResponseDataItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MultimodalEmbeddingsApiResponseDataItem
    {
        /// <summary>
        /// The object type, which is always `embedding`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string? Object { get; set; }

        /// <summary>
        /// The embedding vector consists of a list of floating-point numbers or a Base64-encoded NumPy array depending on `output_encoding`. The length of this vector varies depending on the specific model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("embedding")]
        public byte[]? Embedding { get; set; }

        /// <summary>
        /// An integer representing the index of the embedding within the list of embeddings.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("index")]
        public int? Index { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MultimodalEmbeddingsApiResponseDataItem" /> class.
        /// </summary>
        /// <param name="object">
        /// The object type, which is always `embedding`.
        /// </param>
        /// <param name="embedding">
        /// The embedding vector consists of a list of floating-point numbers or a Base64-encoded NumPy array depending on `output_encoding`. The length of this vector varies depending on the specific model.
        /// </param>
        /// <param name="index">
        /// An integer representing the index of the embedding within the list of embeddings.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MultimodalEmbeddingsApiResponseDataItem(
            string? @object,
            byte[]? embedding,
            int? index)
        {
            this.Object = @object;
            this.Embedding = embedding;
            this.Index = index;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MultimodalEmbeddingsApiResponseDataItem" /> class.
        /// </summary>
        public MultimodalEmbeddingsApiResponseDataItem()
        {
        }
    }
}