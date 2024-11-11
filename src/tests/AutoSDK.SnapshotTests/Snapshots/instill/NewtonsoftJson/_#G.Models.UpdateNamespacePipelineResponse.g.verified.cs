//HintName: G.Models.UpdateNamespacePipelineResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// UpdateNamespacePipelineResponse contains the updated pipeline.
    /// </summary>
    public sealed partial class UpdateNamespacePipelineResponse
    {
        /// <summary>
        /// The updated pipeline resource.<br/>
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
        /// Initializes a new instance of the <see cref="UpdateNamespacePipelineResponse" /> class.
        /// </summary>
        /// <param name="pipeline">
        /// The updated pipeline resource.<br/>
        /// Included only in responses
        /// </param>
        public UpdateNamespacePipelineResponse(
            global::G.Pipeline? pipeline)
        {
            this.Pipeline = pipeline;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateNamespacePipelineResponse" /> class.
        /// </summary>
        public UpdateNamespacePipelineResponse()
        {
        }
    }
}