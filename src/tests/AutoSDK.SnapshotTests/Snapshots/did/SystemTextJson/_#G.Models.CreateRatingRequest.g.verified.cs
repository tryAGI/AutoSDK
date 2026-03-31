//HintName: G.Models.CreateRatingRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Construct a type with the properties of T except for those in type K.
    /// </summary>
    public sealed partial class CreateRatingRequest
    {
        /// <summary>
        /// The rating score: positive for favorable, negative for unfavorable<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("score")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Score { get; set; }

        /// <summary>
        /// The ID of the agent's knowledge
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("knowledge_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string KnowledgeId { get; set; }

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
        /// Initializes a new instance of the <see cref="CreateRatingRequest" /> class.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateRatingRequest(
            double score,
            string knowledgeId,
            string? messageId)
        {
            this.Score = score;
            this.KnowledgeId = knowledgeId ?? throw new global::System.ArgumentNullException(nameof(knowledgeId));
            this.MessageId = messageId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRatingRequest" /> class.
        /// </summary>
        public CreateRatingRequest()
        {
        }
    }
}