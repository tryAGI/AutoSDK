//HintName: G.Models.Message.g.cs

#nullable enable

namespace G
{
    /// <summary>
    ///     Letta's internal representation of a message. Includes methods to convert to/from LLM provider formats.<br/>
    ///     Attributes:<br/>
    ///         id (str): The unique identifier of the message.<br/>
    ///         role (MessageRole): The role of the participant.<br/>
    ///         text (str): The text of the message.<br/>
    ///         user_id (str): The unique identifier of the user.<br/>
    ///         agent_id (str): The unique identifier of the agent.<br/>
    ///         model (str): The model used to make the function call.<br/>
    ///         name (str): The name of the participant.<br/>
    ///         created_at (datetime): The time the message was created.<br/>
    ///         tool_calls (List[OpenAIToolCall,]): The list of tool calls requested.<br/>
    ///         tool_call_id (str): The id of the tool call.<br/>
    ///         step_id (str): The id of the step that this message was created in.<br/>
    ///         otid (str): The offline threading id associated with this message.<br/>
    ///         tool_returns (List[ToolReturn]): The list of tool returns requested.<br/>
    ///         group_id (str): The multi-agent group that the message was sent in.<br/>
    ///         sender_id (str): The id of the sender of the message, can be an identity id or agent id.<br/>
    ///         conversation_id (str): The conversation this message belongs to.<br/>
    /// t
    /// </summary>
    public sealed partial class Message
    {
        /// <summary>
        /// The id of the user that made this object.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_by_id")]
        public string? CreatedById { get; set; }

        /// <summary>
        /// The id of the user that made this object.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_updated_by_id")]
        public string? LastUpdatedById { get; set; }

        /// <summary>
        /// The timestamp when the object was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// The timestamp when the object was last updated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// The human-friendly ID of the Message
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The unique identifier of the agent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        public string? AgentId { get; set; }

        /// <summary>
        /// The model used to make the function call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// The role of the participant.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.MessageRoleJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.MessageRole Role { get; set; }

        /// <summary>
        /// The content of the message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public global::System.Collections.Generic.IList<global::G.ContentVariant1Item>? Content { get; set; }

        /// <summary>
        /// For role user/assistant: the (optional) name of the participant. For role tool/function: the name of the function called.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The list of tool calls requested. Only applicable for role assistant.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_calls")]
        public global::System.Collections.Generic.IList<global::G.ChatCompletionMessageFunctionToolCallOutput>? ToolCalls { get; set; }

        /// <summary>
        /// The ID of the tool call. Only applicable for role tool.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_call_id")]
        public string? ToolCallId { get; set; }

        /// <summary>
        /// The id of the step that this message was created in.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("step_id")]
        public string? StepId { get; set; }

        /// <summary>
        /// The id of the run that this message was created in.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("run_id")]
        public string? RunId { get; set; }

        /// <summary>
        /// The offline threading id associated with this message
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("otid")]
        public string? Otid { get; set; }

        /// <summary>
        /// Tool execution return information for prior tool calls
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_returns")]
        public global::System.Collections.Generic.IList<global::G.LettaSchemasMessageToolReturnOutput>? ToolReturns { get; set; }

        /// <summary>
        /// The multi-agent group that the message was sent in
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("group_id")]
        public string? GroupId { get; set; }

        /// <summary>
        /// The id of the sender of the message, can be an identity id or agent id
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sender_id")]
        public string? SenderId { get; set; }

        /// <summary>
        /// The id of the LLMBatchItem that this message is associated with
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("batch_item_id")]
        public string? BatchItemId { get; set; }

        /// <summary>
        /// The conversation this message belongs to
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversation_id")]
        public string? ConversationId { get; set; }

        /// <summary>
        /// Whether this message is part of an error step. Used only for debugging purposes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_err")]
        public bool? IsErr { get; set; }

        /// <summary>
        /// The id of the approval request if this message is associated with a tool call request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("approval_request_id")]
        public string? ApprovalRequestId { get; set; }

        /// <summary>
        /// Whether tool call is approved.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("approve")]
        public bool? Approve { get; set; }

        /// <summary>
        /// The reason the tool call request was denied.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("denial_reason")]
        public string? DenialReason { get; set; }

        /// <summary>
        /// The list of approvals for this message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("approvals")]
        public global::System.Collections.Generic.IList<global::G.AnyOf<global::G.ApprovalReturn, global::G.LettaSchemasMessageToolReturnOutput>>? Approvals { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Message" /> class.
        /// </summary>
        /// <param name="role">
        /// The role of the participant.
        /// </param>
        /// <param name="createdById">
        /// The id of the user that made this object.
        /// </param>
        /// <param name="lastUpdatedById">
        /// The id of the user that made this object.
        /// </param>
        /// <param name="createdAt">
        /// The timestamp when the object was created.
        /// </param>
        /// <param name="updatedAt">
        /// The timestamp when the object was last updated.
        /// </param>
        /// <param name="id">
        /// The human-friendly ID of the Message
        /// </param>
        /// <param name="agentId">
        /// The unique identifier of the agent.
        /// </param>
        /// <param name="model">
        /// The model used to make the function call.
        /// </param>
        /// <param name="content">
        /// The content of the message.
        /// </param>
        /// <param name="name">
        /// For role user/assistant: the (optional) name of the participant. For role tool/function: the name of the function called.
        /// </param>
        /// <param name="toolCalls">
        /// The list of tool calls requested. Only applicable for role assistant.
        /// </param>
        /// <param name="toolCallId">
        /// The ID of the tool call. Only applicable for role tool.
        /// </param>
        /// <param name="stepId">
        /// The id of the step that this message was created in.
        /// </param>
        /// <param name="runId">
        /// The id of the run that this message was created in.
        /// </param>
        /// <param name="otid">
        /// The offline threading id associated with this message
        /// </param>
        /// <param name="toolReturns">
        /// Tool execution return information for prior tool calls
        /// </param>
        /// <param name="groupId">
        /// The multi-agent group that the message was sent in
        /// </param>
        /// <param name="senderId">
        /// The id of the sender of the message, can be an identity id or agent id
        /// </param>
        /// <param name="batchItemId">
        /// The id of the LLMBatchItem that this message is associated with
        /// </param>
        /// <param name="conversationId">
        /// The conversation this message belongs to
        /// </param>
        /// <param name="isErr">
        /// Whether this message is part of an error step. Used only for debugging purposes.
        /// </param>
        /// <param name="approvalRequestId">
        /// The id of the approval request if this message is associated with a tool call request.
        /// </param>
        /// <param name="approve">
        /// Whether tool call is approved.
        /// </param>
        /// <param name="denialReason">
        /// The reason the tool call request was denied.
        /// </param>
        /// <param name="approvals">
        /// The list of approvals for this message.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Message(
            global::G.MessageRole role,
            string? createdById,
            string? lastUpdatedById,
            global::System.DateTime? createdAt,
            global::System.DateTime? updatedAt,
            string? id,
            string? agentId,
            string? model,
            global::System.Collections.Generic.IList<global::G.ContentVariant1Item>? content,
            string? name,
            global::System.Collections.Generic.IList<global::G.ChatCompletionMessageFunctionToolCallOutput>? toolCalls,
            string? toolCallId,
            string? stepId,
            string? runId,
            string? otid,
            global::System.Collections.Generic.IList<global::G.LettaSchemasMessageToolReturnOutput>? toolReturns,
            string? groupId,
            string? senderId,
            string? batchItemId,
            string? conversationId,
            bool? isErr,
            string? approvalRequestId,
            bool? approve,
            string? denialReason,
            global::System.Collections.Generic.IList<global::G.AnyOf<global::G.ApprovalReturn, global::G.LettaSchemasMessageToolReturnOutput>>? approvals)
        {
            this.CreatedById = createdById;
            this.LastUpdatedById = lastUpdatedById;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Id = id;
            this.AgentId = agentId;
            this.Model = model;
            this.Role = role;
            this.Content = content;
            this.Name = name;
            this.ToolCalls = toolCalls;
            this.ToolCallId = toolCallId;
            this.StepId = stepId;
            this.RunId = runId;
            this.Otid = otid;
            this.ToolReturns = toolReturns;
            this.GroupId = groupId;
            this.SenderId = senderId;
            this.BatchItemId = batchItemId;
            this.ConversationId = conversationId;
            this.IsErr = isErr;
            this.ApprovalRequestId = approvalRequestId;
            this.Approve = approve;
            this.DenialReason = denialReason;
            this.Approvals = approvals;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Message" /> class.
        /// </summary>
        public Message()
        {
        }
    }
}