//HintName: G.Models.ConversationHistoryRagUsageCommonModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ConversationHistoryRagUsageCommonModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int UsageCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("embedding_model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EmbeddingModel { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationHistoryRagUsageCommonModel" /> class.
        /// </summary>
        /// <param name="usageCount"></param>
        /// <param name="embeddingModel"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConversationHistoryRagUsageCommonModel(
            int usageCount,
            string embeddingModel)
        {
            this.UsageCount = usageCount;
            this.EmbeddingModel = embeddingModel ?? throw new global::System.ArgumentNullException(nameof(embeddingModel));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationHistoryRagUsageCommonModel" /> class.
        /// </summary>
        public ConversationHistoryRagUsageCommonModel()
        {
        }
    }
}