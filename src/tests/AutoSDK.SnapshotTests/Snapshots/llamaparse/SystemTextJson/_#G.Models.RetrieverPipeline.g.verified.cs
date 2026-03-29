//HintName: G.Models.RetrieverPipeline.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RetrieverPipeline
    {
        /// <summary>
        /// A name for the retriever tool. Will default to the pipeline name if not provided.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// A description of the retriever tool.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The ID of the pipeline this tool uses.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pipeline_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid PipelineId { get; set; }

        /// <summary>
        /// Parameters for retrieval configuration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("preset_retrieval_parameters")]
        public global::G.PresetRetrievalParams? PresetRetrievalParameters { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RetrieverPipeline" /> class.
        /// </summary>
        /// <param name="pipelineId">
        /// The ID of the pipeline this tool uses.
        /// </param>
        /// <param name="name">
        /// A name for the retriever tool. Will default to the pipeline name if not provided.
        /// </param>
        /// <param name="description">
        /// A description of the retriever tool.
        /// </param>
        /// <param name="presetRetrievalParameters">
        /// Parameters for retrieval configuration.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RetrieverPipeline(
            global::System.Guid pipelineId,
            string? name,
            string? description,
            global::G.PresetRetrievalParams? presetRetrievalParameters)
        {
            this.Name = name;
            this.Description = description;
            this.PipelineId = pipelineId;
            this.PresetRetrievalParameters = presetRetrievalParameters;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RetrieverPipeline" /> class.
        /// </summary>
        public RetrieverPipeline()
        {
        }
    }
}