//HintName: G.Models.WorkflowToolNestedToolsStepModelInput.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WorkflowToolNestedToolsStepModelInput
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("step_latency_secs", Required = global::Newtonsoft.Json.Required.Always)]
        public double StepLatencySecs { get; set; } = default!;

        /// <summary>
        /// Default Value: nested_tools
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("node_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string NodeId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("requests", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.ConversationHistoryTranscriptToolCallCommonModelInput> Requests { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("results", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.OneOf<global::G.ConversationHistoryTranscriptOtherToolsResultCommonModel, global::G.ConversationHistoryTranscriptSystemToolResultCommonModelInput, global::G.ConversationHistoryTranscriptApiIntegrationWebhookToolsResultCommonModel, global::G.ConversationHistoryTranscriptWorkflowToolsResultCommonModelInput>> Results { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_successful", Required = global::Newtonsoft.Json.Required.Always)]
        public bool IsSuccessful { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowToolNestedToolsStepModelInput" /> class.
        /// </summary>
        /// <param name="stepLatencySecs"></param>
        /// <param name="nodeId"></param>
        /// <param name="requests"></param>
        /// <param name="results"></param>
        /// <param name="isSuccessful"></param>
        /// <param name="type">
        /// Default Value: nested_tools
        /// </param>
        public WorkflowToolNestedToolsStepModelInput(
            double stepLatencySecs,
            string nodeId,
            global::System.Collections.Generic.IList<global::G.ConversationHistoryTranscriptToolCallCommonModelInput> requests,
            global::System.Collections.Generic.IList<global::G.OneOf<global::G.ConversationHistoryTranscriptOtherToolsResultCommonModel, global::G.ConversationHistoryTranscriptSystemToolResultCommonModelInput, global::G.ConversationHistoryTranscriptApiIntegrationWebhookToolsResultCommonModel, global::G.ConversationHistoryTranscriptWorkflowToolsResultCommonModelInput>> results,
            bool isSuccessful,
            string? type)
        {
            this.StepLatencySecs = stepLatencySecs;
            this.Type = type;
            this.NodeId = nodeId ?? throw new global::System.ArgumentNullException(nameof(nodeId));
            this.Requests = requests ?? throw new global::System.ArgumentNullException(nameof(requests));
            this.Results = results ?? throw new global::System.ArgumentNullException(nameof(results));
            this.IsSuccessful = isSuccessful;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowToolNestedToolsStepModelInput" /> class.
        /// </summary>
        public WorkflowToolNestedToolsStepModelInput()
        {
        }
    }
}