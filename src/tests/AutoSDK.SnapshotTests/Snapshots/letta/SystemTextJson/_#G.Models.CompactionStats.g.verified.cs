//HintName: G.Models.CompactionStats.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Statistics about a memory compaction operation.
    /// </summary>
    public sealed partial class CompactionStats
    {
        /// <summary>
        /// What triggered the compaction (e.g., 'context_window_exceeded', 'post_step_context_check')
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trigger")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Trigger { get; set; }

        /// <summary>
        /// Token count before compaction (from LLM usage stats, includes full context sent to LLM)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("context_tokens_before")]
        public int? ContextTokensBefore { get; set; }

        /// <summary>
        /// Token count after compaction (message tokens only, does not include tool definitions)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("context_tokens_after")]
        public int? ContextTokensAfter { get; set; }

        /// <summary>
        /// The model's context window size
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("context_window")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ContextWindow { get; set; }

        /// <summary>
        /// Number of messages before compaction
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("messages_count_before")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MessagesCountBefore { get; set; }

        /// <summary>
        /// Number of messages after compaction
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("messages_count_after")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MessagesCountAfter { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CompactionStats" /> class.
        /// </summary>
        /// <param name="trigger">
        /// What triggered the compaction (e.g., 'context_window_exceeded', 'post_step_context_check')
        /// </param>
        /// <param name="contextWindow">
        /// The model's context window size
        /// </param>
        /// <param name="messagesCountBefore">
        /// Number of messages before compaction
        /// </param>
        /// <param name="messagesCountAfter">
        /// Number of messages after compaction
        /// </param>
        /// <param name="contextTokensBefore">
        /// Token count before compaction (from LLM usage stats, includes full context sent to LLM)
        /// </param>
        /// <param name="contextTokensAfter">
        /// Token count after compaction (message tokens only, does not include tool definitions)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CompactionStats(
            string trigger,
            int contextWindow,
            int messagesCountBefore,
            int messagesCountAfter,
            int? contextTokensBefore,
            int? contextTokensAfter)
        {
            this.Trigger = trigger ?? throw new global::System.ArgumentNullException(nameof(trigger));
            this.ContextTokensBefore = contextTokensBefore;
            this.ContextTokensAfter = contextTokensAfter;
            this.ContextWindow = contextWindow;
            this.MessagesCountBefore = messagesCountBefore;
            this.MessagesCountAfter = messagesCountAfter;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CompactionStats" /> class.
        /// </summary>
        public CompactionStats()
        {
        }
    }
}