//HintName: G.Models.CreateRatingResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateRatingResponse
    {
        /// <summary>
        /// The ID of the agent
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("agent_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string AgentId { get; set; } = default!;

        /// <summary>
        /// The ID of the agent's knowledge
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("knowledge_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string KnowledgeId { get; set; } = default!;

        /// <summary>
        /// An external identifier
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("external_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ExternalId { get; set; } = default!;

        /// <summary>
        /// The ID of the message to rate
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message_id")]
        public string? MessageId { get; set; }

        /// <summary>
        /// The ID of the chat containing the message
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("chat_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ChatId { get; set; } = default!;

        /// <summary>
        /// The rating score: positive for favorable, negative for unfavorable<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::Newtonsoft.Json.JsonProperty("score", Required = global::Newtonsoft.Json.Required.Always)]
        public double Score { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("owner_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string OwnerId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public string CreatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("modified_at", Required = global::Newtonsoft.Json.Required.Always)]
        public string ModifiedAt { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRatingResponse" /> class.
        /// </summary>
        /// <param name="agentId">
        /// The ID of the agent
        /// </param>
        /// <param name="knowledgeId">
        /// The ID of the agent's knowledge
        /// </param>
        /// <param name="externalId">
        /// An external identifier
        /// </param>
        /// <param name="chatId">
        /// The ID of the chat containing the message
        /// </param>
        /// <param name="score">
        /// The rating score: positive for favorable, negative for unfavorable<br/>
        /// Example: 1
        /// </param>
        /// <param name="id"></param>
        /// <param name="ownerId"></param>
        /// <param name="createdAt"></param>
        /// <param name="modifiedAt"></param>
        /// <param name="messageId">
        /// The ID of the message to rate
        /// </param>
        public CreateRatingResponse(
            string agentId,
            string knowledgeId,
            string externalId,
            string chatId,
            double score,
            string id,
            string ownerId,
            string createdAt,
            string modifiedAt,
            string? messageId)
        {
            this.AgentId = agentId ?? throw new global::System.ArgumentNullException(nameof(agentId));
            this.KnowledgeId = knowledgeId ?? throw new global::System.ArgumentNullException(nameof(knowledgeId));
            this.ExternalId = externalId ?? throw new global::System.ArgumentNullException(nameof(externalId));
            this.MessageId = messageId;
            this.ChatId = chatId ?? throw new global::System.ArgumentNullException(nameof(chatId));
            this.Score = score;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.OwnerId = ownerId ?? throw new global::System.ArgumentNullException(nameof(ownerId));
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.ModifiedAt = modifiedAt ?? throw new global::System.ArgumentNullException(nameof(modifiedAt));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRatingResponse" /> class.
        /// </summary>
        public CreateRatingResponse()
        {
        }
    }
}