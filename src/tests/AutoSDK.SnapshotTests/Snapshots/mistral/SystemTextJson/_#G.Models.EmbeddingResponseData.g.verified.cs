//HintName: G.Models.EmbeddingResponseData.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EmbeddingResponseData
    {
        /// <summary>
        /// Example: [0.1, 0.2, 0.3]
        /// </summary>
        /// <example>[0.1, 0.2, 0.3]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("embedding")]
        public global::System.Collections.Generic.IList<double>? Embedding { get; set; }

        /// <summary>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("index")]
        public int? Index { get; set; }

        /// <summary>
        /// Example: embedding
        /// </summary>
        /// <example>embedding</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string? Object { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbeddingResponseData" /> class.
        /// </summary>
        /// <param name="embedding">
        /// Example: [0.1, 0.2, 0.3]
        /// </param>
        /// <param name="index">
        /// Example: 0
        /// </param>
        /// <param name="object">
        /// Example: embedding
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public EmbeddingResponseData(
            global::System.Collections.Generic.IList<double>? embedding,
            int? index,
            string? @object)
        {
            this.Embedding = embedding;
            this.Index = index;
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbeddingResponseData" /> class.
        /// </summary>
        public EmbeddingResponseData()
        {
        }
    }
}