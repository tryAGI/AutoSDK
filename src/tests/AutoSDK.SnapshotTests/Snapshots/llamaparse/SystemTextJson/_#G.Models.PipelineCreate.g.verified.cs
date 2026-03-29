//HintName: G.Models.PipelineCreate.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Schema for creating a pipeline.
    /// </summary>
    public sealed partial class PipelineCreate
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("embedding_config")]
        public global::G.EmbeddingConfigVariant12? EmbeddingConfig { get; set; }

        /// <summary>
        /// Configuration for the transformation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transform_config")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<global::G.AutoTransformConfig, global::G.AdvancedModeTransformConfig, object>))]
        public global::G.AnyOf<global::G.AutoTransformConfig, global::G.AdvancedModeTransformConfig, object>? TransformConfig { get; set; }

        /// <summary>
        /// Configuration for the sparse model used in hybrid search.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sparse_model_config")]
        public global::G.SparseModelConfig? SparseModelConfig { get; set; }

        /// <summary>
        /// Data sink ID. When provided instead of data_sink, the data sink will be looked up by ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data_sink_id")]
        public global::System.Guid? DataSinkId { get; set; }

        /// <summary>
        /// Embedding model config ID. When provided instead of embedding_config, the embedding model config will be looked up by ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("embedding_model_config_id")]
        public global::System.Guid? EmbeddingModelConfigId { get; set; }

        /// <summary>
        /// Data sink. When provided instead of data_sink_id, the data sink will be created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data_sink")]
        public global::G.DataSinkCreate? DataSink { get; set; }

        /// <summary>
        /// Preset retrieval parameters for the pipeline.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("preset_retrieval_parameters")]
        public global::G.PresetRetrievalParams? PresetRetrievalParameters { get; set; }

        /// <summary>
        /// Settings that can be configured for how to use LlamaParse to parse files within a LlamaCloud pipeline.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("llama_parse_parameters")]
        public global::G.LlamaParseParameters? LlamaParseParameters { get; set; }

        /// <summary>
        /// Status of the pipeline deployment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// Metadata configuration for the pipeline.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata_config")]
        public global::G.PipelineMetadataConfig2? MetadataConfig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Type of pipeline. Either PLAYGROUND or MANAGED.<br/>
        /// Default Value: MANAGED
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pipeline_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.PipelineTypeJsonConverter))]
        public global::G.PipelineType? PipelineType { get; set; }

        /// <summary>
        /// The ID of the ManagedPipeline this playground pipeline is linked to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("managed_pipeline_id")]
        public global::System.Guid? ManagedPipelineId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PipelineCreate" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="embeddingConfig"></param>
        /// <param name="transformConfig">
        /// Configuration for the transformation.
        /// </param>
        /// <param name="sparseModelConfig">
        /// Configuration for the sparse model used in hybrid search.
        /// </param>
        /// <param name="dataSinkId">
        /// Data sink ID. When provided instead of data_sink, the data sink will be looked up by ID.
        /// </param>
        /// <param name="embeddingModelConfigId">
        /// Embedding model config ID. When provided instead of embedding_config, the embedding model config will be looked up by ID.
        /// </param>
        /// <param name="dataSink">
        /// Data sink. When provided instead of data_sink_id, the data sink will be created.
        /// </param>
        /// <param name="presetRetrievalParameters">
        /// Preset retrieval parameters for the pipeline.
        /// </param>
        /// <param name="llamaParseParameters">
        /// Settings that can be configured for how to use LlamaParse to parse files within a LlamaCloud pipeline.
        /// </param>
        /// <param name="status">
        /// Status of the pipeline deployment.
        /// </param>
        /// <param name="metadataConfig">
        /// Metadata configuration for the pipeline.
        /// </param>
        /// <param name="pipelineType">
        /// Type of pipeline. Either PLAYGROUND or MANAGED.<br/>
        /// Default Value: MANAGED
        /// </param>
        /// <param name="managedPipelineId">
        /// The ID of the ManagedPipeline this playground pipeline is linked to.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PipelineCreate(
            string name,
            global::G.EmbeddingConfigVariant12? embeddingConfig,
            global::G.AnyOf<global::G.AutoTransformConfig, global::G.AdvancedModeTransformConfig, object>? transformConfig,
            global::G.SparseModelConfig? sparseModelConfig,
            global::System.Guid? dataSinkId,
            global::System.Guid? embeddingModelConfigId,
            global::G.DataSinkCreate? dataSink,
            global::G.PresetRetrievalParams? presetRetrievalParameters,
            global::G.LlamaParseParameters? llamaParseParameters,
            string? status,
            global::G.PipelineMetadataConfig2? metadataConfig,
            global::G.PipelineType? pipelineType,
            global::System.Guid? managedPipelineId)
        {
            this.EmbeddingConfig = embeddingConfig;
            this.TransformConfig = transformConfig;
            this.SparseModelConfig = sparseModelConfig;
            this.DataSinkId = dataSinkId;
            this.EmbeddingModelConfigId = embeddingModelConfigId;
            this.DataSink = dataSink;
            this.PresetRetrievalParameters = presetRetrievalParameters;
            this.LlamaParseParameters = llamaParseParameters;
            this.Status = status;
            this.MetadataConfig = metadataConfig;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.PipelineType = pipelineType;
            this.ManagedPipelineId = managedPipelineId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PipelineCreate" /> class.
        /// </summary>
        public PipelineCreate()
        {
        }
    }
}