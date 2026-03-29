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
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// A description of the retriever tool.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The ID of the pipeline this tool uses.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pipeline_id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid PipelineId { get; set; } = default!;

        /// <summary>
        /// Parameters for retrieval configuration.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("preset_retrieval_parameters")]
        public global::G.PresetRetrievalParams? PresetRetrievalParameters { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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