//HintName: G.Models.EmbeddingsApiResponseDataItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EmbeddingsApiResponseDataItem
    {
        /// <summary>
        /// The object type, which is always "embedding".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string? Object { get; set; }

        /// <summary>
        /// Each embedding is a vector represented as an array of float numbers when `output_dtype` is set to `float` and as an array of integers for all other values of `output_dtype` (`int8`, `uint8`, `binary`, and `ubinary`). The length of this vector varies depending on the specific model, `output_dimension`, and `output_dtype`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("embedding")]
        public global::System.Collections.Generic.IList<double>? Embedding { get; set; }

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
        /// Initializes a new instance of the <see cref="EmbeddingsApiResponseDataItem" /> class.
        /// </summary>
        /// <param name="object">
        /// The object type, which is always "embedding".
        /// </param>
        /// <param name="embedding">
        /// Each embedding is a vector represented as an array of float numbers when `output_dtype` is set to `float` and as an array of integers for all other values of `output_dtype` (`int8`, `uint8`, `binary`, and `ubinary`). The length of this vector varies depending on the specific model, `output_dimension`, and `output_dtype`.
        /// </param>
        /// <param name="index">
        /// An integer representing the index of the embedding within the list of embeddings.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EmbeddingsApiResponseDataItem(
            string? @object,
            global::System.Collections.Generic.IList<double>? embedding,
            int? index)
        {
            this.Object = @object;
            this.Embedding = embedding;
            this.Index = index;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbeddingsApiResponseDataItem" /> class.
        /// </summary>
        public EmbeddingsApiResponseDataItem()
        {
        }
    }
}