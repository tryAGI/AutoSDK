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
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.EmbeddingModelEnumJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.EmbeddingModelEnum Model { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("used_bytes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int UsedBytes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RAGIndexOverviewEmbeddingModelResponseModel" /> class.
        /// </summary>
        /// <param name="model"></param>
        /// <param name="usedBytes"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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