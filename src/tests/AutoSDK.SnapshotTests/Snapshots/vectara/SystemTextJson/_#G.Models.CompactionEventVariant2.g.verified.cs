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
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; } = "compaction";

        /// <summary>
        /// Number of conversation turns that were compacted.<br/>
        /// Example: 5
        /// </summary>
        /// <example>5</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("turns_compacted")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TurnsCompacted { get; set; }

        /// <summary>
        /// Number of events that were hidden by compaction.<br/>
        /// Example: 47
        /// </summary>
        /// <example>47</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("events_compacted")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int EventsCompacted { get; set; }

        /// <summary>
        /// The plain text summary produced by compaction.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary_text")]
        public string? SummaryText { get; set; }

        /// <summary>
        /// The key of the summary created by compaction.<br/>
        /// Example: sum_abc123
        /// </summary>
        /// <example>sum_abc123</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary_key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SummaryKey { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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