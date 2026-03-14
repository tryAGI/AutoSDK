//HintName: G.Models.CreateCompactRequestVariant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateCompactRequestVariant2
    {
        /// <summary>
        /// Default Value: compact
        /// </summary>
        /// <default>"compact"</default>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public string Type { get; set; } = default!;

        /// <summary>
        /// Compact all inputs up to this event ID (inclusive), e.g. "aev_abc123".<br/>
        /// When specified, `keep_recent_inputs` is bypassed — all inputs up to the anchor are compacted.<br/>
        /// If omitted, compacts all inputs except the most recent `keep_recent_inputs` inputs.<br/>
        /// Example: aev_abc123
        /// </summary>
        /// <example>aev_abc123</example>
        [global::Newtonsoft.Json.JsonProperty("compact_up_to_event_id")]
        public string? CompactUpToEventId { get; set; }

        /// <summary>
        /// Override the compaction prompt for this compaction.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("compaction_message")]
        public string? CompactionMessage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCompactRequestVariant2" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: compact
        /// </param>
        /// <param name="compactUpToEventId">
        /// Compact all inputs up to this event ID (inclusive), e.g. "aev_abc123".<br/>
        /// When specified, `keep_recent_inputs` is bypassed — all inputs up to the anchor are compacted.<br/>
        /// If omitted, compacts all inputs except the most recent `keep_recent_inputs` inputs.<br/>
        /// Example: aev_abc123
        /// </param>
        /// <param name="compactionMessage">
        /// Override the compaction prompt for this compaction.
        /// </param>
        public CreateCompactRequestVariant2(
            string type,
            string? compactUpToEventId,
            string? compactionMessage)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.CompactUpToEventId = compactUpToEventId;
            this.CompactionMessage = compactionMessage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCompactRequestVariant2" /> class.
        /// </summary>
        public CreateCompactRequestVariant2()
        {
        }
    }
}