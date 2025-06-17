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
        [global::Newtonsoft.Json.JsonProperty("usage_count", Required = global::Newtonsoft.Json.Required.Always)]
        public int UsageCount { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("embedding_model", Required = global::Newtonsoft.Json.Required.Always)]
        public string EmbeddingModel { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationHistoryRagUsageCommonModel" /> class.
        /// </summary>
        /// <param name="usageCount"></param>
        /// <param name="embeddingModel"></param>
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