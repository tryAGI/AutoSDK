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
        [global::System.Text.Json.Serialization.JsonPropertyName("total_used_bytes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalUsedBytes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_max_bytes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalMaxBytes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("models")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.RAGIndexOverviewEmbeddingModelResponseModel> Models { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RAGIndexOverviewResponseModel" /> class.
        /// </summary>
        /// <param name="totalUsedBytes"></param>
        /// <param name="totalMaxBytes"></param>
        /// <param name="models"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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