//HintName: G.Models.PartialRatingPayload.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Make all properties in T optional
    /// </summary>
    public sealed partial class PartialRatingPayload
    {
        /// <summary>
        /// The rating score: positive for favorable, negative for unfavorable<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("score")]
        public double? Score { get; set; }

        /// <summary>
        /// The ID of the agent
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        public string? AgentId { get; set; }

        /// <summary>
        /// The ID of the chat containing the message
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chat_id")]
        public string? ChatId { get; set; }

        /// <summary>
        /// The ID of the agent's knowledge
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("knowledge_id")]
        public string? KnowledgeId { get; set; }

        /// <summary>
        /// The ID of the message to rate
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message_id")]
        public string? MessageId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PartialRatingPayload" /> class.
        /// </summary>
        /// <param name="score">
        /// The rating score: positive for favorable, negative for unfavorable<br/>
        /// Example: 1
        /// </param>
        /// <param name="agentId">
        /// The ID of the agent
        /// </param>
        /// <param name="chatId">
        /// The ID of the chat containing the message
        /// </param>
        /// <param name="knowledgeId">
        /// The ID of the agent's knowledge
        /// </param>
        /// <param name="messageId">
        /// The ID of the message to rate
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PartialRatingPayload(
            double? score,
            string? agentId,
            string? chatId,
            string? knowledgeId,
            string? messageId)
        {
            this.Score = score;
            this.AgentId = agentId;
            this.ChatId = chatId;
            this.KnowledgeId = knowledgeId;
            this.MessageId = messageId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PartialRatingPayload" /> class.
        /// </summary>
        public PartialRatingPayload()
        {
        }
    }
}