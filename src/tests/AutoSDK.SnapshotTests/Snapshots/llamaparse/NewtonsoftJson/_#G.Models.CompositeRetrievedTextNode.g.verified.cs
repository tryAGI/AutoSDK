//HintName: G.Models.CompositeRetrievedTextNode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CompositeRetrievedTextNode
    {
        /// <summary>
        /// The ID of the retrieved node.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid Id { get; set; } = default!;

        /// <summary>
        /// The ID of the retriever this node was retrieved from.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("retriever_id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid RetrieverId { get; set; } = default!;

        /// <summary>
        /// The name of the retrieval pipeline this node was retrieved from.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("retriever_pipeline_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string RetrieverPipelineName { get; set; } = default!;

        /// <summary>
        /// The ID of the pipeline this node was retrieved from.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pipeline_id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid PipelineId { get; set; } = default!;

        /// <summary>
        /// Metadata associated with the retrieved node.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// The text of the retrieved node.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text", Required = global::Newtonsoft.Json.Required.Always)]
        public string Text { get; set; } = default!;

        /// <summary>
        /// The start character index of the retrieved node in the document
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("start_char_idx")]
        public int? StartCharIdx { get; set; }

        /// <summary>
        /// The end character index of the retrieved node in the document
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("end_char_idx")]
        public int? EndCharIdx { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CompositeRetrievedTextNode" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the retrieved node.
        /// </param>
        /// <param name="retrieverId">
        /// The ID of the retriever this node was retrieved from.
        /// </param>
        /// <param name="retrieverPipelineName">
        /// The name of the retrieval pipeline this node was retrieved from.
        /// </param>
        /// <param name="pipelineId">
        /// The ID of the pipeline this node was retrieved from.
        /// </param>
        /// <param name="text">
        /// The text of the retrieved node.
        /// </param>
        /// <param name="metadata">
        /// Metadata associated with the retrieved node.
        /// </param>
        /// <param name="startCharIdx">
        /// The start character index of the retrieved node in the document
        /// </param>
        /// <param name="endCharIdx">
        /// The end character index of the retrieved node in the document
        /// </param>
        public CompositeRetrievedTextNode(
            global::System.Guid id,
            global::System.Guid retrieverId,
            string retrieverPipelineName,
            global::System.Guid pipelineId,
            string text,
            object? metadata,
            int? startCharIdx,
            int? endCharIdx)
        {
            this.Id = id;
            this.RetrieverId = retrieverId;
            this.RetrieverPipelineName = retrieverPipelineName ?? throw new global::System.ArgumentNullException(nameof(retrieverPipelineName));
            this.PipelineId = pipelineId;
            this.Metadata = metadata;
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.StartCharIdx = startCharIdx;
            this.EndCharIdx = endCharIdx;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CompositeRetrievedTextNode" /> class.
        /// </summary>
        public CompositeRetrievedTextNode()
        {
        }
    }
}