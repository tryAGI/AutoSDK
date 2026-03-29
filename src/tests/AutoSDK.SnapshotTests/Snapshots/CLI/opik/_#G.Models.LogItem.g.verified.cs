//HintName: G.Models.LogItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LogItem
    {
        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp")]
        public global::System.DateTime? Timestamp { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rule_id")]
        public global::System.Guid? RuleId { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("level")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.LogItemLevelJsonConverter))]
        public global::G.LogItemLevel? Level { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("markers")]
        public global::System.Collections.Generic.Dictionary<string, string>? Markers { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LogItem" /> class.
        /// </summary>
        /// <param name="timestamp">
        /// Included only in responses
        /// </param>
        /// <param name="ruleId">
        /// Included only in responses
        /// </param>
        /// <param name="level">
        /// Included only in responses
        /// </param>
        /// <param name="message">
        /// Included only in responses
        /// </param>
        /// <param name="markers">
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LogItem(
            global::System.DateTime? timestamp,
            global::System.Guid? ruleId,
            global::G.LogItemLevel? level,
            string? message,
            global::System.Collections.Generic.Dictionary<string, string>? markers)
        {
            this.Timestamp = timestamp;
            this.RuleId = ruleId;
            this.Level = level;
            this.Message = message;
            this.Markers = markers;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LogItem" /> class.
        /// </summary>
        public LogItem()
        {
        }
    }
}