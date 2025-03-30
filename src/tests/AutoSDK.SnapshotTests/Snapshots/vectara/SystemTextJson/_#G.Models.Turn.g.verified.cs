//HintName: G.Models.Turn.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A single message exchange in a chat conversation, representing one user input and the corresponding response.
    /// </summary>
    public sealed partial class Turn
    {
        /// <summary>
        /// The ID of the turn.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The ID of the chat the turn resides in.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chat_id")]
        public string? ChatId { get; set; }

        /// <summary>
        /// The query made to produce this turn.<br/>
        /// Example: How do you turn this widget?
        /// </summary>
        /// <example>How do you turn this widget?</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("query")]
        public string? Query { get; set; }

        /// <summary>
        /// The response to the query.<br/>
        /// Example: The widget turns counter clockwise.
        /// </summary>
        /// <example>The widget turns counter clockwise.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("answer")]
        public string? Answer { get; set; }

        /// <summary>
        /// Indicates whether the turn is enabled and shown in future turns of the chat.<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Specifies when the turn was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Turn" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the turn.
        /// </param>
        /// <param name="chatId">
        /// The ID of the chat the turn resides in.
        /// </param>
        /// <param name="query">
        /// The query made to produce this turn.<br/>
        /// Example: How do you turn this widget?
        /// </param>
        /// <param name="answer">
        /// The response to the query.<br/>
        /// Example: The widget turns counter clockwise.
        /// </param>
        /// <param name="enabled">
        /// Indicates whether the turn is enabled and shown in future turns of the chat.<br/>
        /// Example: true
        /// </param>
        /// <param name="createdAt">
        /// Specifies when the turn was created.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Turn(
            string? id,
            string? chatId,
            string? query,
            string? answer,
            bool? enabled,
            global::System.DateTime? createdAt)
        {
            this.Id = id;
            this.ChatId = chatId;
            this.Query = query;
            this.Answer = answer;
            this.Enabled = enabled;
            this.CreatedAt = createdAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Turn" /> class.
        /// </summary>
        public Turn()
        {
        }
    }
}