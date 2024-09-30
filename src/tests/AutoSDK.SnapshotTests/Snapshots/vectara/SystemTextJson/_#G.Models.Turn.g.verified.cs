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
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The ID of the chat the turn resides in.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chat_id")]
        public string? ChatId { get; set; }

        /// <summary>
        /// The query made to produce this turn.<br/>
        /// Example: How do a turn this widget?
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("query")]
        public string? Query { get; set; }

        /// <summary>
        /// The response to the query.<br/>
        /// Example: The widget turns counter clockwise.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("answer")]
        public string? Answer { get; set; }

        /// <summary>
        /// Indicates whether the turn is enabled and shown in futures turns of the chat.<br/>
        /// Example: true
        /// </summary>
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
    }
}