//HintName: G.Models.PipelinesSyncPipelineResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PipelinesSyncPipelineResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("success", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Success { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("messages_ingested", Required = global::Newtonsoft.Json.Required.Always)]
        public double MessagesIngested { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("workflow_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string WorkflowId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PipelinesSyncPipelineResponse" /> class.
        /// </summary>
        /// <param name="success"></param>
        /// <param name="messagesIngested"></param>
        /// <param name="workflowId"></param>
        public PipelinesSyncPipelineResponse(
            bool success,
            double messagesIngested,
            string workflowId)
        {
            this.Success = success;
            this.MessagesIngested = messagesIngested;
            this.WorkflowId = workflowId ?? throw new global::System.ArgumentNullException(nameof(workflowId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PipelinesSyncPipelineResponse" /> class.
        /// </summary>
        public PipelinesSyncPipelineResponse()
        {
        }
    }
}