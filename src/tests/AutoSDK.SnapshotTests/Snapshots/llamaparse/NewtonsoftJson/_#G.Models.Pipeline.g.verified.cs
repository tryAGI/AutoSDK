//HintName: G.Models.Pipeline.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Schema for a pipeline.
    /// </summary>
    public sealed partial class Pipeline
    {
        /// <summary>
        /// Unique identifier
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid Id { get; set; } = default!;

        /// <summary>
        /// Creation datetime
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Update datetime
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project_id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid ProjectId { get; set; } = default!;

        /// <summary>
        /// The ID of the EmbeddingModelConfig this pipeline is using.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("embedding_model_config_id")]
        public global::System.Guid? EmbeddingModelConfigId { get; set; }

        /// <summary>
        /// The embedding model configuration for this pipeline.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("embedding_model_config")]
        public global::G.EmbeddingModelConfig? EmbeddingModelConfig { get; set; }

        /// <summary>
        /// Type of pipeline. Either PLAYGROUND or MANAGED.<br/>
        /// Default Value: MANAGED
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pipeline_type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.PipelineTypeJsonConverter))]
        public global::G.PipelineType? PipelineType { get; set; }

        /// <summary>
        /// The ID of the ManagedPipeline this playground pipeline is linked to.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("managed_pipeline_id")]
        public global::System.Guid? ManagedPipelineId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("embedding_config", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.EmbeddingConfig3 EmbeddingConfig { get; set; } = default!;

        /// <summary>
        /// Configuration for the sparse model used in hybrid search.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sparse_model_config")]
        public global::G.SparseModelConfig? SparseModelConfig { get; set; }

        /// <summary>
        /// Hashes for the configuration of the pipeline.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("config_hash")]
        public global::G.PipelineConfigurationHashes? ConfigHash { get; set; }

        /// <summary>
        /// Configuration for the transformation.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("transform_config")]
        public global::G.AnyOf<global::G.AutoTransformConfig, global::G.AdvancedModeTransformConfig>? TransformConfig { get; set; }

        /// <summary>
        /// Preset retrieval parameters for the pipeline.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("preset_retrieval_parameters")]
        public global::G.PresetRetrievalParams? PresetRetrievalParameters { get; set; }

        /// <summary>
        /// Settings that can be configured for how to use LlamaParse to parse files within a LlamaCloud pipeline.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("llama_parse_parameters")]
        public global::G.LlamaParseParameters? LlamaParseParameters { get; set; }

        /// <summary>
        /// The data sink for the pipeline. If None, the pipeline will use the fully managed data sink.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data_sink")]
        public global::G.DataSink? DataSink { get; set; }

        /// <summary>
        /// Status of the pipeline.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status")]
        public global::G.PipelineStatus2? Status { get; set; }

        /// <summary>
        /// Metadata configuration for the pipeline.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata_config")]
        public global::G.PipelineMetadataConfig2? MetadataConfig { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Pipeline" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier
        /// </param>
        /// <param name="name"></param>
        /// <param name="projectId"></param>
        /// <param name="embeddingConfig"></param>
        /// <param name="createdAt">
        /// Creation datetime
        /// </param>
        /// <param name="updatedAt">
        /// Update datetime
        /// </param>
        /// <param name="embeddingModelConfigId">
        /// The ID of the EmbeddingModelConfig this pipeline is using.
        /// </param>
        /// <param name="embeddingModelConfig">
        /// The embedding model configuration for this pipeline.
        /// </param>
        /// <param name="pipelineType">
        /// Type of pipeline. Either PLAYGROUND or MANAGED.<br/>
        /// Default Value: MANAGED
        /// </param>
        /// <param name="managedPipelineId">
        /// The ID of the ManagedPipeline this playground pipeline is linked to.
        /// </param>
        /// <param name="sparseModelConfig">
        /// Configuration for the sparse model used in hybrid search.
        /// </param>
        /// <param name="configHash">
        /// Hashes for the configuration of the pipeline.
        /// </param>
        /// <param name="transformConfig">
        /// Configuration for the transformation.
        /// </param>
        /// <param name="presetRetrievalParameters">
        /// Preset retrieval parameters for the pipeline.
        /// </param>
        /// <param name="llamaParseParameters">
        /// Settings that can be configured for how to use LlamaParse to parse files within a LlamaCloud pipeline.
        /// </param>
        /// <param name="dataSink">
        /// The data sink for the pipeline. If None, the pipeline will use the fully managed data sink.
        /// </param>
        /// <param name="status">
        /// Status of the pipeline.
        /// </param>
        /// <param name="metadataConfig">
        /// Metadata configuration for the pipeline.
        /// </param>
        public Pipeline(
            global::System.Guid id,
            string name,
            global::System.Guid projectId,
            global::G.EmbeddingConfig3 embeddingConfig,
            global::System.DateTime? createdAt,
            global::System.DateTime? updatedAt,
            global::System.Guid? embeddingModelConfigId,
            global::G.EmbeddingModelConfig? embeddingModelConfig,
            global::G.PipelineType? pipelineType,
            global::System.Guid? managedPipelineId,
            global::G.SparseModelConfig? sparseModelConfig,
            global::G.PipelineConfigurationHashes? configHash,
            global::G.AnyOf<global::G.AutoTransformConfig, global::G.AdvancedModeTransformConfig>? transformConfig,
            global::G.PresetRetrievalParams? presetRetrievalParameters,
            global::G.LlamaParseParameters? llamaParseParameters,
            global::G.DataSink? dataSink,
            global::G.PipelineStatus2? status,
            global::G.PipelineMetadataConfig2? metadataConfig)
        {
            this.Id = id;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.ProjectId = projectId;
            this.EmbeddingModelConfigId = embeddingModelConfigId;
            this.EmbeddingModelConfig = embeddingModelConfig;
            this.PipelineType = pipelineType;
            this.ManagedPipelineId = managedPipelineId;
            this.EmbeddingConfig = embeddingConfig;
            this.SparseModelConfig = sparseModelConfig;
            this.ConfigHash = configHash;
            this.TransformConfig = transformConfig;
            this.PresetRetrievalParameters = presetRetrievalParameters;
            this.LlamaParseParameters = llamaParseParameters;
            this.DataSink = dataSink;
            this.Status = status;
            this.MetadataConfig = metadataConfig;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Pipeline" /> class.
        /// </summary>
        public Pipeline()
        {
        }
    }
}