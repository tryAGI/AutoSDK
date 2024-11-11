//HintName: G.Models.RenameNamespacePipelineResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// RenameNamespacePipelineResponse contains a renamed pipeline.
    /// </summary>
    public sealed partial class RenameNamespacePipelineResponse
    {
        /// <summary>
        /// The renamed pipeline resource.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pipeline")]
        public global::G.Pipeline? Pipeline { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RenameNamespacePipelineResponse" /> class.
        /// </summary>
        /// <param name="pipeline">
        /// The renamed pipeline resource.<br/>
        /// Included only in responses
        /// </param>
        public RenameNamespacePipelineResponse(
            global::G.Pipeline? pipeline)
        {
            this.Pipeline = pipeline;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RenameNamespacePipelineResponse" /> class.
        /// </summary>
        public RenameNamespacePipelineResponse()
        {
        }
    }
}