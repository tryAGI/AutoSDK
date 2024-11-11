//HintName: G.Models.Turn.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Turn
    {
        /// <summary>
        /// The ID of the turn.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The ID of the chat the turn resides in.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("chat_id")]
        public string? ChatId { get; set; }

        /// <summary>
        /// The query made to produce this turn.<br/>
        /// Example: How do a turn this widget?
        /// </summary>
        /// <example>How do a turn this widget?</example>
        [global::Newtonsoft.Json.JsonProperty("query")]
        public string? Query { get; set; }

        /// <summary>
        /// The response to the query.<br/>
        /// Example: The widget turns counter clockwise.
        /// </summary>
        /// <example>The widget turns counter clockwise.</example>
        [global::Newtonsoft.Json.JsonProperty("answer")]
        public string? Answer { get; set; }

        /// <summary>
        /// Indicates whether the turn is enabled and shown in futures turns of the chat.<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::Newtonsoft.Json.JsonProperty("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Specifies when the turn was created.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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
        /// Example: How do a turn this widget?
        /// </param>
        /// <param name="answer">
        /// The response to the query.<br/>
        /// Example: The widget turns counter clockwise.
        /// </param>
        /// <param name="enabled">
        /// Indicates whether the turn is enabled and shown in futures turns of the chat.<br/>
        /// Example: true
        /// </param>
        /// <param name="createdAt">
        /// Specifies when the turn was created.
        /// </param>
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