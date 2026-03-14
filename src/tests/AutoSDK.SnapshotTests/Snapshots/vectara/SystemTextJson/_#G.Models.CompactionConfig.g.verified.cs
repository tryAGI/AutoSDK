//HintName: G.Models.CompactionConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Configuration for automatic context compaction.
    /// </summary>
    public sealed partial class CompactionConfig
    {
        /// <summary>
        /// Enable automatic context compaction.<br/>
        /// Default Value: true<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Context usage % (50-95) at which compaction is applied.<br/>
        /// Default Value: 80<br/>
        /// Example: 80
        /// </summary>
        /// <example>80</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("threshold_percent")]
        public int? ThresholdPercent { get; set; }

        /// <summary>
        /// Number of recent inputs to keep verbatim (not compacted).<br/>
        /// Default Value: 3<br/>
        /// Example: 3
        /// </summary>
        /// <example>3</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("keep_recent_inputs")]
        public int? KeepRecentInputs { get; set; }

        /// <summary>
        /// Custom additional instructions for the compaction summarization prompt.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("compaction_message")]
        public string? CompactionMessage { get; set; }

        /// <summary>
        /// How tool events are included in the compaction input.<br/>
        /// Default Value: include_outputs
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_event_policy")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CompactionConfigToolEventPolicyJsonConverter))]
        public global::G.CompactionConfigToolEventPolicy? ToolEventPolicy { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CompactionConfig" /> class.
        /// </summary>
        /// <param name="enabled">
        /// Enable automatic context compaction.<br/>
        /// Default Value: true<br/>
        /// Example: true
        /// </param>
        /// <param name="thresholdPercent">
        /// Context usage % (50-95) at which compaction is applied.<br/>
        /// Default Value: 80<br/>
        /// Example: 80
        /// </param>
        /// <param name="keepRecentInputs">
        /// Number of recent inputs to keep verbatim (not compacted).<br/>
        /// Default Value: 3<br/>
        /// Example: 3
        /// </param>
        /// <param name="compactionMessage">
        /// Custom additional instructions for the compaction summarization prompt.
        /// </param>
        /// <param name="toolEventPolicy">
        /// How tool events are included in the compaction input.<br/>
        /// Default Value: include_outputs
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CompactionConfig(
            bool? enabled,
            int? thresholdPercent,
            int? keepRecentInputs,
            string? compactionMessage,
            global::G.CompactionConfigToolEventPolicy? toolEventPolicy)
        {
            this.Enabled = enabled;
            this.ThresholdPercent = thresholdPercent;
            this.KeepRecentInputs = keepRecentInputs;
            this.CompactionMessage = compactionMessage;
            this.ToolEventPolicy = toolEventPolicy;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CompactionConfig" /> class.
        /// </summary>
        public CompactionConfig()
        {
        }
    }
}