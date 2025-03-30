//HintName: G.Models.QueryHistorySummary.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A summary of a previously executed query, including metadata but not full results.
    /// </summary>
    public sealed partial class QueryHistorySummary
    {
        /// <summary>
        /// The ID of the query history.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The actual query made.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("query")]
        public string? Query { get; set; }

        /// <summary>
        /// The corpus key that the query was made on.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("corpus_key")]
        public string? CorpusKey { get; set; }

        /// <summary>
        /// ISO date time indicating when the query was first received.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("started_at")]
        public global::System.DateTime? StartedAt { get; set; }

        /// <summary>
        /// Time that the query took in milliseconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("latency_millis")]
        public int? LatencyMillis { get; set; }

        /// <summary>
        /// The unique ID of the chat associated with the query, if this query is part of a chat.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chat_id")]
        public string? ChatId { get; set; }

        /// <summary>
        /// Generated response to the query, if requested.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generation")]
        public string? Generation { get; set; }

        /// <summary>
        /// The factual consistency score of the generation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("factual_consistency_score")]
        public float? FactualConsistencyScore { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryHistorySummary" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the query history.
        /// </param>
        /// <param name="query">
        /// The actual query made.
        /// </param>
        /// <param name="corpusKey">
        /// The corpus key that the query was made on.
        /// </param>
        /// <param name="startedAt">
        /// ISO date time indicating when the query was first received.
        /// </param>
        /// <param name="latencyMillis">
        /// Time that the query took in milliseconds.
        /// </param>
        /// <param name="chatId">
        /// The unique ID of the chat associated with the query, if this query is part of a chat.
        /// </param>
        /// <param name="generation">
        /// Generated response to the query, if requested.
        /// </param>
        /// <param name="factualConsistencyScore">
        /// The factual consistency score of the generation.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public QueryHistorySummary(
            string? id,
            string? query,
            string? corpusKey,
            global::System.DateTime? startedAt,
            int? latencyMillis,
            string? chatId,
            string? generation,
            float? factualConsistencyScore)
        {
            this.Id = id;
            this.Query = query;
            this.CorpusKey = corpusKey;
            this.StartedAt = startedAt;
            this.LatencyMillis = latencyMillis;
            this.ChatId = chatId;
            this.Generation = generation;
            this.FactualConsistencyScore = factualConsistencyScore;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryHistorySummary" /> class.
        /// </summary>
        public QueryHistorySummary()
        {
        }
    }
}