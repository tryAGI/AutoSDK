//HintName: G.Models.RewrittenQuerySpan.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Provides detailed information about a rewritten query generated for a specific corpus<br/>
    /// when intelligent query rewriting is enabled.
    /// </summary>
    public sealed partial class RewrittenQuerySpan
    {
        /// <summary>
        /// Indicates the type of span. This value is always `rewritten_query`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// The corpus key that the query was made on.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("corpus_key")]
        public string? CorpusKey { get; set; }

        /// <summary>
        /// Time taken in milliseconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("latency_millis")]
        public int? LatencyMillis { get; set; }

        /// <summary>
        /// When the span started.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("started_at")]
        public global::System.DateTime? StartedAt { get; set; }

        /// <summary>
        /// Warnings that occurred during query rewriting.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("warnings")]
        public global::System.Collections.Generic.IList<global::G.RewrittenQueryWarning>? Warnings { get; set; }

        /// <summary>
        /// The result of query filter extraction.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filter_extraction")]
        public global::G.FilterExtraction? FilterExtraction { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RewrittenQuerySpan" /> class.
        /// </summary>
        /// <param name="type">
        /// Indicates the type of span. This value is always `rewritten_query`.
        /// </param>
        /// <param name="corpusKey">
        /// The corpus key that the query was made on.
        /// </param>
        /// <param name="latencyMillis">
        /// Time taken in milliseconds.
        /// </param>
        /// <param name="startedAt">
        /// When the span started.
        /// </param>
        /// <param name="warnings">
        /// Warnings that occurred during query rewriting.
        /// </param>
        /// <param name="filterExtraction">
        /// The result of query filter extraction.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RewrittenQuerySpan(
            string? type,
            string? corpusKey,
            int? latencyMillis,
            global::System.DateTime? startedAt,
            global::System.Collections.Generic.IList<global::G.RewrittenQueryWarning>? warnings,
            global::G.FilterExtraction? filterExtraction)
        {
            this.Type = type;
            this.CorpusKey = corpusKey;
            this.LatencyMillis = latencyMillis;
            this.StartedAt = startedAt;
            this.Warnings = warnings;
            this.FilterExtraction = filterExtraction;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RewrittenQuerySpan" /> class.
        /// </summary>
        public RewrittenQuerySpan()
        {
        }
    }
}