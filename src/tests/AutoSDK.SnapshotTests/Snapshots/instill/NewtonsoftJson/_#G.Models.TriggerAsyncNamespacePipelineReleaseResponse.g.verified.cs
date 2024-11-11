//HintName: G.Models.TriggerAsyncNamespacePipelineReleaseResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// TriggerAsyncNamespacePipelineReleaseResponse contains the information to access<br/>
    /// the status of an asynchronous pipeline execution.
    /// </summary>
    public sealed partial class TriggerAsyncNamespacePipelineReleaseResponse
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
        /// Initializes a new instance of the <see cref="TriggerAsyncNamespacePipelineReleaseResponse" /> class.
        /// </summary>
        /// <param name="operation">
        /// Long-running operation information.<br/>
        /// Included only in responses
        /// </param>
        public TriggerAsyncNamespacePipelineReleaseResponse(
            global::G.LongrunningOperation? operation)
        {
            this.Operation = operation;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TriggerAsyncNamespacePipelineReleaseResponse" /> class.
        /// </summary>
        public TriggerAsyncNamespacePipelineReleaseResponse()
        {
        }
    }
}