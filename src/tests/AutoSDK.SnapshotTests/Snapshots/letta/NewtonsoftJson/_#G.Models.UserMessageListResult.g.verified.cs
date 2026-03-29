//HintName: G.Models.UserMessageListResult.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// User message list result with agent context.<br/>
    /// Shape is identical to UpdateUserMessage but includes the owning agent_id and message id.
    /// </summary>
    public sealed partial class UserMessageListResult
    {
        /// <summary>
        /// Default Value: user_message
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message_type")]
        public string? MessageType { get; set; }

        /// <summary>
        /// The message content sent by the user (can be a string or an array of multi-modal content parts)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AnyOf<global::System.Collections.Generic.IList<global::G.LettaUserMessageContentUnion>, string> Content { get; set; } = default!;

        /// <summary>
        /// The unique identifier of the message.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string MessageId { get; set; } = default!;

        /// <summary>
        /// The unique identifier of the agent that owns the message.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("agent_id")]
        public string? AgentId { get; set; }

        /// <summary>
        /// The unique identifier of the conversation that the message belongs to.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("conversation_id")]
        public string? ConversationId { get; set; }

        /// <summary>
        /// The time the message was created in ISO format.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserMessageListResult" /> class.
        /// </summary>
        /// <param name="content">
        /// The message content sent by the user (can be a string or an array of multi-modal content parts)
        /// </param>
        /// <param name="messageId">
        /// The unique identifier of the message.
        /// </param>
        /// <param name="createdAt">
        /// The time the message was created in ISO format.
        /// </param>
        /// <param name="messageType">
        /// Default Value: user_message
        /// </param>
        /// <param name="agentId">
        /// The unique identifier of the agent that owns the message.
        /// </param>
        /// <param name="conversationId">
        /// The unique identifier of the conversation that the message belongs to.
        /// </param>
        public UserMessageListResult(
            global::G.AnyOf<global::System.Collections.Generic.IList<global::G.LettaUserMessageContentUnion>, string> content,
            string messageId,
            global::System.DateTime createdAt,
            string? messageType,
            string? agentId,
            string? conversationId)
        {
            this.MessageType = messageType;
            this.Content = content;
            this.MessageId = messageId ?? throw new global::System.ArgumentNullException(nameof(messageId));
            this.AgentId = agentId;
            this.ConversationId = conversationId;
            this.CreatedAt = createdAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserMessageListResult" /> class.
        /// </summary>
        public UserMessageListResult()
        {
        }
    }
}