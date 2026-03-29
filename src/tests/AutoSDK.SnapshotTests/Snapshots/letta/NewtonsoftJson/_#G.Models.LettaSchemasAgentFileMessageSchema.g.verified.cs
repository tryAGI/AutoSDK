//HintName: G.Models.LettaSchemasAgentFileMessageSchema.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Message with human-readable ID for agent file
    /// </summary>
    public sealed partial class LettaSchemasAgentFileMessageSchema
    {
        /// <summary>
        /// The message type to be created.<br/>
        /// Default Value: message
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string? Type { get; set; }

        /// <summary>
        /// The role of the participant.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("role", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.MessageRole Role { get; set; } = default!;

        /// <summary>
        /// The content of the message.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AnyOf<global::System.Collections.Generic.IList<global::G.LettaMessageContentUnion>, string> Content { get; set; } = default!;

        /// <summary>
        /// The name of the participant.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The offline threading id associated with this message
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("otid")]
        public string? Otid { get; set; }

        /// <summary>
        /// The id of the sender of the message, can be an identity id or agent id
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sender_id")]
        public string? SenderId { get; set; }

        /// <summary>
        /// The id of the LLMBatchItem that this message is associated with
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("batch_item_id")]
        public string? BatchItemId { get; set; }

        /// <summary>
        /// The multi-agent group that the message was sent in
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("group_id")]
        public string? GroupId { get; set; }

        /// <summary>
        /// Human-readable identifier for this message in the file
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// The model used to make the function call
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model")]
        public string? Model { get; set; }

        /// <summary>
        /// The unique identifier of the agent
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("agent_id")]
        public string? AgentId { get; set; }

        /// <summary>
        /// The list of tool calls requested. Only applicable for role assistant.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tool_calls")]
        public global::System.Collections.Generic.IList<global::G.ChatCompletionMessageFunctionToolCallInput>? ToolCalls { get; set; }

        /// <summary>
        /// The ID of the tool call. Only applicable for role tool.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tool_call_id")]
        public string? ToolCallId { get; set; }

        /// <summary>
        /// Tool execution return information for prior tool calls
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tool_returns")]
        public global::System.Collections.Generic.IList<global::G.LettaSchemasMessageToolReturnInput>? ToolReturns { get; set; }

        /// <summary>
        /// The timestamp when the object was created.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Whether the tool has been approved
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("approve")]
        public bool? Approve { get; set; }

        /// <summary>
        /// The message ID of the approval request
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("approval_request_id")]
        public string? ApprovalRequestId { get; set; }

        /// <summary>
        /// An optional explanation for the provided approval status
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("denial_reason")]
        public string? DenialReason { get; set; }

        /// <summary>
        /// Approval returns for the message
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("approvals")]
        public global::System.Collections.Generic.IList<global::G.AnyOf<global::G.ApprovalReturn, global::G.LettaSchemasMessageToolReturnInput>>? Approvals { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LettaSchemasAgentFileMessageSchema" /> class.
        /// </summary>
        /// <param name="role">
        /// The role of the participant.
        /// </param>
        /// <param name="content">
        /// The content of the message.
        /// </param>
        /// <param name="id">
        /// Human-readable identifier for this message in the file
        /// </param>
        /// <param name="type">
        /// The message type to be created.<br/>
        /// Default Value: message
        /// </param>
        /// <param name="name">
        /// The name of the participant.
        /// </param>
        /// <param name="otid">
        /// The offline threading id associated with this message
        /// </param>
        /// <param name="senderId">
        /// The id of the sender of the message, can be an identity id or agent id
        /// </param>
        /// <param name="batchItemId">
        /// The id of the LLMBatchItem that this message is associated with
        /// </param>
        /// <param name="groupId">
        /// The multi-agent group that the message was sent in
        /// </param>
        /// <param name="model">
        /// The model used to make the function call
        /// </param>
        /// <param name="agentId">
        /// The unique identifier of the agent
        /// </param>
        /// <param name="toolCalls">
        /// The list of tool calls requested. Only applicable for role assistant.
        /// </param>
        /// <param name="toolCallId">
        /// The ID of the tool call. Only applicable for role tool.
        /// </param>
        /// <param name="toolReturns">
        /// Tool execution return information for prior tool calls
        /// </param>
        /// <param name="createdAt">
        /// The timestamp when the object was created.
        /// </param>
        /// <param name="approve">
        /// Whether the tool has been approved
        /// </param>
        /// <param name="approvalRequestId">
        /// The message ID of the approval request
        /// </param>
        /// <param name="denialReason">
        /// An optional explanation for the provided approval status
        /// </param>
        /// <param name="approvals">
        /// Approval returns for the message
        /// </param>
        public LettaSchemasAgentFileMessageSchema(
            global::G.MessageRole role,
            global::G.AnyOf<global::System.Collections.Generic.IList<global::G.LettaMessageContentUnion>, string> content,
            string id,
            string? type,
            string? name,
            string? otid,
            string? senderId,
            string? batchItemId,
            string? groupId,
            string? model,
            string? agentId,
            global::System.Collections.Generic.IList<global::G.ChatCompletionMessageFunctionToolCallInput>? toolCalls,
            string? toolCallId,
            global::System.Collections.Generic.IList<global::G.LettaSchemasMessageToolReturnInput>? toolReturns,
            global::System.DateTime? createdAt,
            bool? approve,
            string? approvalRequestId,
            string? denialReason,
            global::System.Collections.Generic.IList<global::G.AnyOf<global::G.ApprovalReturn, global::G.LettaSchemasMessageToolReturnInput>>? approvals)
        {
            this.Type = type;
            this.Role = role;
            this.Content = content;
            this.Name = name;
            this.Otid = otid;
            this.SenderId = senderId;
            this.BatchItemId = batchItemId;
            this.GroupId = groupId;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Model = model;
            this.AgentId = agentId;
            this.ToolCalls = toolCalls;
            this.ToolCallId = toolCallId;
            this.ToolReturns = toolReturns;
            this.CreatedAt = createdAt;
            this.Approve = approve;
            this.ApprovalRequestId = approvalRequestId;
            this.DenialReason = denialReason;
            this.Approvals = approvals;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LettaSchemasAgentFileMessageSchema" /> class.
        /// </summary>
        public LettaSchemasAgentFileMessageSchema()
        {
        }
    }
}