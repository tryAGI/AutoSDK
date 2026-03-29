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
        [global::Newtonsoft.Json.JsonProperty("hierarchical_indexing")]
        public bool? HierarchicalIndexing { get; set; }

        /// <summary>
        /// 是否开启关键词索引（默认为true）
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("keyword_indexing")]
        public bool? KeywordIndexing { get; set; }

        /// <summary>
        /// 向量模型
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model")]
        public string? Model { get; set; }

        /// <summary>
        /// 是否开启向量索引（默认为true）
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("vector_indexing")]
        public bool? VectorIndexing { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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