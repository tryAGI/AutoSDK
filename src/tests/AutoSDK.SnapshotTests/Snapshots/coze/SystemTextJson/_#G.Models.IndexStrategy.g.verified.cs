//HintName: G.Models.IndexStrategy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class IndexStrategy
    {
        /// <summary>
        /// 是否开启分层索引
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hierarchical_indexing")]
        public bool? HierarchicalIndexing { get; set; }

        /// <summary>
        /// 是否开启关键词索引（默认为true）
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("keyword_indexing")]
        public bool? KeywordIndexing { get; set; }

        /// <summary>
        /// 向量模型
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// 是否开启向量索引（默认为true）
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vector_indexing")]
        public bool? VectorIndexing { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IndexStrategy" /> class.
        /// </summary>
        /// <param name="hierarchicalIndexing">
        /// 是否开启分层索引
        /// </param>
        /// <param name="keywordIndexing">
        /// 是否开启关键词索引（默认为true）
        /// </param>
        /// <param name="model">
        /// 向量模型
        /// </param>
        /// <param name="vectorIndexing">
        /// 是否开启向量索引（默认为true）
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IndexStrategy(
            bool? hierarchicalIndexing,
            bool? keywordIndexing,
            string? model,
            bool? vectorIndexing)
        {
            this.HierarchicalIndexing = hierarchicalIndexing;
            this.KeywordIndexing = keywordIndexing;
            this.Model = model;
            this.VectorIndexing = vectorIndexing;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IndexStrategy" /> class.
        /// </summary>
        public IndexStrategy()
        {
        }
    }
}