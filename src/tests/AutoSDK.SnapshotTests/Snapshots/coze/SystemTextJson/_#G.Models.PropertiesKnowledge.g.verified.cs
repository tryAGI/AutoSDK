//HintName: G.Models.PropertiesKnowledge.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PropertiesKnowledge
    {
        /// <summary>
        /// 自动调用 or 按需调用
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auto_call")]
        public bool? AutoCall { get; set; }

        /// <summary>
        /// 更新知识库列表 全量覆盖更新
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataset_ids")]
        public global::System.Collections.Generic.IList<string>? DatasetIds { get; set; }

        /// <summary>
        /// 搜索策略
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("search_strategy")]
        public int? SearchStrategy { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PropertiesKnowledge" /> class.
        /// </summary>
        /// <param name="autoCall">
        /// 自动调用 or 按需调用
        /// </param>
        /// <param name="datasetIds">
        /// 更新知识库列表 全量覆盖更新
        /// </param>
        /// <param name="searchStrategy">
        /// 搜索策略
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PropertiesKnowledge(
            bool? autoCall,
            global::System.Collections.Generic.IList<string>? datasetIds,
            int? searchStrategy)
        {
            this.AutoCall = autoCall;
            this.DatasetIds = datasetIds;
            this.SearchStrategy = searchStrategy;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PropertiesKnowledge" /> class.
        /// </summary>
        public PropertiesKnowledge()
        {
        }
    }
}