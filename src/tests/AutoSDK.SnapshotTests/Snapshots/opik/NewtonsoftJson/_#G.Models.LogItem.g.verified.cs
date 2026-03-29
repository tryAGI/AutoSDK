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
        [global::Newtonsoft.Json.JsonProperty("timestamp")]
        public global::System.DateTime? Timestamp { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("rule_id")]
        public global::System.Guid? RuleId { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("level")]
        public global::G.LogItemLevel? Level { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("markers")]
        public global::System.Collections.Generic.Dictionary<string, string>? Markers { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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