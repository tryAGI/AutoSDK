//HintName: G.Models.RAGIndexOverviewEmbeddingModelResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RAGIndexOverviewEmbeddingModelResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.EmbeddingModelEnum Model { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("used_bytes", Required = global::Newtonsoft.Json.Required.Always)]
        public int UsedBytes { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RAGIndexOverviewEmbeddingModelResponseModel" /> class.
        /// </summary>
        /// <param name="model"></param>
        /// <param name="usedBytes"></param>
        public RAGIndexOverviewEmbeddingModelResponseModel(
            global::G.EmbeddingModelEnum model,
            int usedBytes)
        {
            this.Model = model;
            this.UsedBytes = usedBytes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RAGIndexOverviewEmbeddingModelResponseModel" /> class.
        /// </summary>
        public RAGIndexOverviewEmbeddingModelResponseModel()
        {
        }
    }
}