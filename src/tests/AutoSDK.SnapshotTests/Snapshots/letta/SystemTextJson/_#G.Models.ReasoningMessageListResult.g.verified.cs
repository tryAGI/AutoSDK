//HintName: G.Models.ReasoningMessageListResult.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Reasoning message list result with agent context.<br/>
    /// Shape is identical to UpdateReasoningMessage but includes the owning agent_id and message id.
    /// </summary>
    public sealed partial class ReasoningMessageListResult
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reasoning")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Reasoning { get; set; }

        /// <summary>
        /// Default Value: reasoning_message
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message_type")]
        public string? MessageType { get; set; }

        /// <summary>
        /// The unique identifier of the message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string MessageId { get; set; }

        /// <summary>
        /// The unique identifier of the agent that owns the message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        public string? AgentId { get; set; }

        /// <summary>
        /// The unique identifier of the conversation that the message belongs to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversation_id")]
        public string? ConversationId { get; set; }

        /// <summary>
        /// The time the message was created in ISO format.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReasoningMessageListResult" /> class.
        /// </summary>
        /// <param name="reasoning"></param>
        /// <param name="messageId">
        /// The unique identifier of the message.
        /// </param>
        /// <param name="createdAt">
        /// The time the message was created in ISO format.
        /// </param>
        /// <param name="messageType">
        /// Default Value: reasoning_message
        /// </param>
        /// <param name="agentId">
        /// The unique identifier of the agent that owns the message.
        /// </param>
        /// <param name="conversationId">
        /// The unique identifier of the conversation that the message belongs to.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReasoningMessageListResult(
            string reasoning,
            string messageId,
            global::System.DateTime createdAt,
            string? messageType,
            string? agentId,
            string? conversationId)
        {
            this.Reasoning = reasoning ?? throw new global::System.ArgumentNullException(nameof(reasoning));
            this.MessageType = messageType;
            this.MessageId = messageId ?? throw new global::System.ArgumentNullException(nameof(messageId));
            this.AgentId = agentId;
            this.ConversationId = conversationId;
            this.CreatedAt = createdAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReasoningMessageListResult" /> class.
        /// </summary>
        public ReasoningMessageListResult()
        {
        }
    }
}