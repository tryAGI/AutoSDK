//HintName: G.Models.SparseModelConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Configuration for sparse embedding models used in hybrid search.<br/>
    /// This allows users to choose between Splade and BM25 models for<br/>
    /// sparse retrieval in managed data sinks.
    /// </summary>
    public sealed partial class SparseModelConfig
    {
        /// <summary>
        /// The sparse model type to use. 'bm25' uses Qdrant's FastEmbed BM25 model (default for new pipelines), 'splade' uses HuggingFace Splade model, 'auto' selects based on deployment mode (BYOC uses term frequency, Cloud uses Splade).<br/>
        /// Default Value: bm25
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.SparseModelTypeJsonConverter))]
        public global::G.SparseModelType? ModelType { get; set; }

        /// <summary>
        /// Default Value: SparseModelConfig
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("class_name")]
        public string? ClassName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SparseModelConfig" /> class.
        /// </summary>
        /// <param name="modelType">
        /// The sparse model type to use. 'bm25' uses Qdrant's FastEmbed BM25 model (default for new pipelines), 'splade' uses HuggingFace Splade model, 'auto' selects based on deployment mode (BYOC uses term frequency, Cloud uses Splade).<br/>
        /// Default Value: bm25
        /// </param>
        /// <param name="className">
        /// Default Value: SparseModelConfig
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SparseModelConfig(
            global::G.SparseModelType? modelType,
            string? className)
        {
            this.ModelType = modelType;
            this.ClassName = className;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SparseModelConfig" /> class.
        /// </summary>
        public SparseModelConfig()
        {
        }
    }
}