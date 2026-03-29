//HintName: G.Models.PipelinesCreatePipelineResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PipelinesCreatePipelineResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pipeline", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.PipelinesCreatePipelineResponsePipeline Pipeline { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PipelinesCreatePipelineResponse" /> class.
        /// </summary>
        /// <param name="pipeline"></param>
        public PipelinesCreatePipelineResponse(
            global::G.PipelinesCreatePipelineResponsePipeline pipeline)
        {
            this.Pipeline = pipeline ?? throw new global::System.ArgumentNullException(nameof(pipeline));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PipelinesCreatePipelineResponse" /> class.
        /// </summary>
        public PipelinesCreatePipelineResponse()
        {
        }
    }
}