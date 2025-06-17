//HintName: G.Models.RAGIndexOverviewResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RAGIndexOverviewResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_used_bytes", Required = global::Newtonsoft.Json.Required.Always)]
        public int TotalUsedBytes { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_max_bytes", Required = global::Newtonsoft.Json.Required.Always)]
        public int TotalMaxBytes { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("models", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.RAGIndexOverviewEmbeddingModelResponseModel> Models { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RAGIndexOverviewResponseModel" /> class.
        /// </summary>
        /// <param name="totalUsedBytes"></param>
        /// <param name="totalMaxBytes"></param>
        /// <param name="models"></param>
        public RAGIndexOverviewResponseModel(
            int totalUsedBytes,
            int totalMaxBytes,
            global::System.Collections.Generic.IList<global::G.RAGIndexOverviewEmbeddingModelResponseModel> models)
        {
            this.TotalUsedBytes = totalUsedBytes;
            this.TotalMaxBytes = totalMaxBytes;
            this.Models = models ?? throw new global::System.ArgumentNullException(nameof(models));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RAGIndexOverviewResponseModel" /> class.
        /// </summary>
        public RAGIndexOverviewResponseModel()
        {
        }
    }
}