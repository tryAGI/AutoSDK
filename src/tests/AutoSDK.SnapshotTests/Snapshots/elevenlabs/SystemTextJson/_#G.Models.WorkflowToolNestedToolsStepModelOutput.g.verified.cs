//HintName: G.Models.WorkflowToolNestedToolsStepModelOutput.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WorkflowToolNestedToolsStepModelOutput
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("step_latency_secs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double StepLatencySecs { get; set; }

        /// <summary>
        /// Default Value: nested_tools
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("node_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NodeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requests")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.ConversationHistoryTranscriptToolCallCommonModelOutput> Requests { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("results")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.OneOf<global::G.ConversationHistoryTranscriptOtherToolsResultCommonModel, global::G.ConversationHistoryTranscriptSystemToolResultCommonModelOutput, global::G.ConversationHistoryTranscriptApiIntegrationWebhookToolsResultCommonModel, global::G.ConversationHistoryTranscriptWorkflowToolsResultCommonModelOutput>> Results { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_successful")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsSuccessful { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowToolNestedToolsStepModelOutput" /> class.
        /// </summary>
        /// <param name="stepLatencySecs"></param>
        /// <param name="type">
        /// Default Value: nested_tools
        /// </param>
        /// <param name="nodeId"></param>
        /// <param name="requests"></param>
        /// <param name="results"></param>
        /// <param name="isSuccessful"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WorkflowToolNestedToolsStepModelOutput(
            double stepLatencySecs,
            string nodeId,
            global::System.Collections.Generic.IList<global::G.ConversationHistoryTranscriptToolCallCommonModelOutput> requests,
            global::System.Collections.Generic.IList<global::G.OneOf<global::G.ConversationHistoryTranscriptOtherToolsResultCommonModel, global::G.ConversationHistoryTranscriptSystemToolResultCommonModelOutput, global::G.ConversationHistoryTranscriptApiIntegrationWebhookToolsResultCommonModel, global::G.ConversationHistoryTranscriptWorkflowToolsResultCommonModelOutput>> results,
            bool isSuccessful,
            string? type)
        {
            this.StepLatencySecs = stepLatencySecs;
            this.NodeId = nodeId ?? throw new global::System.ArgumentNullException(nameof(nodeId));
            this.Requests = requests ?? throw new global::System.ArgumentNullException(nameof(requests));
            this.Results = results ?? throw new global::System.ArgumentNullException(nameof(results));
            this.IsSuccessful = isSuccessful;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowToolNestedToolsStepModelOutput" /> class.
        /// </summary>
        public WorkflowToolNestedToolsStepModelOutput()
        {
        }
    }
}