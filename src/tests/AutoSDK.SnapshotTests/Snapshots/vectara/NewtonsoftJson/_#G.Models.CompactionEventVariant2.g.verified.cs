//HintName: G.Models.CompactionEventVariant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CompactionEventVariant2
    {
        /// <summary>
        /// The type of event.<br/>
        /// Default Value: compaction<br/>
        /// Example: compaction
        /// </summary>
        /// <default>"compaction"</default>
        /// <example>compaction</example>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public string Type { get; set; } = default!;

        /// <summary>
        /// Number of conversation turns that were compacted.<br/>
        /// Example: 5
        /// </summary>
        /// <example>5</example>
        [global::Newtonsoft.Json.JsonProperty("turns_compacted", Required = global::Newtonsoft.Json.Required.Always)]
        public int TurnsCompacted { get; set; } = default!;

        /// <summary>
        /// Number of events that were hidden by compaction.<br/>
        /// Example: 47
        /// </summary>
        /// <example>47</example>
        [global::Newtonsoft.Json.JsonProperty("events_compacted", Required = global::Newtonsoft.Json.Required.Always)]
        public int EventsCompacted { get; set; } = default!;

        /// <summary>
        /// The plain text summary produced by compaction.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("summary_text")]
        public string? SummaryText { get; set; }

        /// <summary>
        /// The key of the summary created by compaction.<br/>
        /// Example: sum_abc123
        /// </summary>
        /// <example>sum_abc123</example>
        [global::Newtonsoft.Json.JsonProperty("summary_key", Required = global::Newtonsoft.Json.Required.Always)]
        public string SummaryKey { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CompactionEventVariant2" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of event.<br/>
        /// Default Value: compaction<br/>
        /// Example: compaction
        /// </param>
        /// <param name="turnsCompacted">
        /// Number of conversation turns that were compacted.<br/>
        /// Example: 5
        /// </param>
        /// <param name="eventsCompacted">
        /// Number of events that were hidden by compaction.<br/>
        /// Example: 47
        /// </param>
        /// <param name="summaryText">
        /// The plain text summary produced by compaction.
        /// </param>
        /// <param name="summaryKey">
        /// The key of the summary created by compaction.<br/>
        /// Example: sum_abc123
        /// </param>
        public CompactionEventVariant2(
            string type,
            int turnsCompacted,
            int eventsCompacted,
            string summaryKey,
            string? summaryText)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.TurnsCompacted = turnsCompacted;
            this.EventsCompacted = eventsCompacted;
            this.SummaryKey = summaryKey ?? throw new global::System.ArgumentNullException(nameof(summaryKey));
            this.SummaryText = summaryText;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CompactionEventVariant2" /> class.
        /// </summary>
        public CompactionEventVariant2()
        {
        }
    }
}