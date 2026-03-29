//HintName: G.Models.PickRatingPayloadExcludeKeyofRatingPayloadAgentIdOrChatId.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// From T, pick a set of properties whose keys are in the union K
    /// </summary>
    public sealed partial class PickRatingPayloadExcludeKeyofRatingPayloadAgentIdOrChatId
    {
        /// <summary>
        /// The rating score: positive for favorable, negative for unfavorable<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::Newtonsoft.Json.JsonProperty("score", Required = global::Newtonsoft.Json.Required.Always)]
        public double Score { get; set; } = default!;

        /// <summary>
        /// The ID of the agent's knowledge
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("knowledge_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string KnowledgeId { get; set; } = default!;

        /// <summary>
        /// The ID of the message to rate
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message_id")]
        public string? MessageId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PickRatingPayloadExcludeKeyofRatingPayloadAgentIdOrChatId" /> class.
        /// </summary>
        /// <param name="score">
        /// The rating score: positive for favorable, negative for unfavorable<br/>
        /// Example: 1
        /// </param>
        /// <param name="knowledgeId">
        /// The ID of the agent's knowledge
        /// </param>
        /// <param name="messageId">
        /// The ID of the message to rate
        /// </param>
        public PickRatingPayloadExcludeKeyofRatingPayloadAgentIdOrChatId(
            double score,
            string knowledgeId,
            string? messageId)
        {
            this.Score = score;
            this.KnowledgeId = knowledgeId ?? throw new global::System.ArgumentNullException(nameof(knowledgeId));
            this.MessageId = messageId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PickRatingPayloadExcludeKeyofRatingPayloadAgentIdOrChatId" /> class.
        /// </summary>
        public PickRatingPayloadExcludeKeyofRatingPayloadAgentIdOrChatId()
        {
        }
    }
}