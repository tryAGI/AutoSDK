//HintName: G.Models.TestFromConversationMetadataOutput.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TestFromConversationMetadataOutput
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("conversation_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ConversationId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("agent_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string AgentId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("branch_id")]
        public string? BranchId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("workflow_node_id")]
        public string? WorkflowNodeId { get; set; }

        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("original_agent_reply")]
        public global::System.Collections.Generic.IList<global::G.ConversationHistoryTranscriptCommonModelOutput>? OriginalAgentReply { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TestFromConversationMetadataOutput" /> class.
        /// </summary>
        /// <param name="conversationId"></param>
        /// <param name="agentId"></param>
        /// <param name="branchId"></param>
        /// <param name="workflowNodeId"></param>
        /// <param name="originalAgentReply">
        /// Default Value: []
        /// </param>
        public TestFromConversationMetadataOutput(
            string conversationId,
            string agentId,
            string? branchId,
            string? workflowNodeId,
            global::System.Collections.Generic.IList<global::G.ConversationHistoryTranscriptCommonModelOutput>? originalAgentReply)
        {
            this.ConversationId = conversationId ?? throw new global::System.ArgumentNullException(nameof(conversationId));
            this.AgentId = agentId ?? throw new global::System.ArgumentNullException(nameof(agentId));
            this.BranchId = branchId;
            this.WorkflowNodeId = workflowNodeId;
            this.OriginalAgentReply = originalAgentReply;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TestFromConversationMetadataOutput" /> class.
        /// </summary>
        public TestFromConversationMetadataOutput()
        {
        }
    }
}