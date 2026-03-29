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
        [global::System.Text.Json.Serialization.JsonPropertyName("pipeline")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.PipelinesCreatePipelineResponsePipeline Pipeline { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PipelinesCreatePipelineResponse" /> class.
        /// </summary>
        /// <param name="pipeline"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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