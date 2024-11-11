//HintName: G.Models.TriggerAsyncNamespacePipelineResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// TriggerAsyncNamespacePipelineResponse contains the information to access the<br/>
    /// status of an asynchronous pipeline execution.
    /// </summary>
    public sealed partial class TriggerAsyncNamespacePipelineResponse
    {
        /// <summary>
        /// Long-running operation information.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("operation")]
        public global::G.LongrunningOperation? Operation { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TriggerAsyncNamespacePipelineResponse" /> class.
        /// </summary>
        /// <param name="operation">
        /// Long-running operation information.<br/>
        /// Included only in responses
        /// </param>
        public TriggerAsyncNamespacePipelineResponse(
            global::G.LongrunningOperation? operation)
        {
            this.Operation = operation;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TriggerAsyncNamespacePipelineResponse" /> class.
        /// </summary>
        public TriggerAsyncNamespacePipelineResponse()
        {
        }
    }
}