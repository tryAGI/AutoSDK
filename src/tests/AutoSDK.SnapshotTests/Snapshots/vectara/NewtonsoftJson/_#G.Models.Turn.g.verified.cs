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
        [global::Newtonsoft.Json.JsonProperty("query")]
        public string? Query { get; set; }

        /// <summary>
        /// The response to the query.<br/>
        /// Example: The widget turns counter clockwise.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("answer")]
        public string? Answer { get; set; }

        /// <summary>
        /// Indicates whether the turn is enabled and shown in futures turns of the chat.<br/>
        /// Example: true
        /// </summary>
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
    }
}