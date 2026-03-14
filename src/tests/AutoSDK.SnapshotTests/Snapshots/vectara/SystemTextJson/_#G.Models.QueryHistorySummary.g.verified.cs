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
        /// The ID of the query history.<br/>
        /// Example: qry_1234567890
        /// </summary>
        /// <example>qry_1234567890</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The actual query made.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("query")]
        public string? Query { get; set; }

        /// <summary>
        /// The corpus key that the query was made on.<br/>
        /// Example: eu_carbon
        /// </summary>
        /// <example>eu_carbon</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("corpus_key")]
        public string? CorpusKey { get; set; }

        /// <summary>
        /// ISO date time indicating when the query was first received.<br/>
        /// Example: 2025-06-01T12:00:00Z
        /// </summary>
        /// <example>2025-06-01T12:00:00Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("started_at")]
        public global::System.DateTime? StartedAt { get; set; }

        /// <summary>
        /// Time that the query took in milliseconds.<br/>
        /// Example: 50
        /// </summary>
        /// <example>50</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("latency_millis")]
        public int? LatencyMillis { get; set; }

        /// <summary>
        /// The unique ID of the chat associated with the query, if this query is part of a chat.<br/>
        /// Example: chat_1234567890
        /// </summary>
        /// <example>chat_1234567890</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("chat_id")]
        public string? ChatId { get; set; }

        /// <summary>
        /// Generated response to the query, if requested.<br/>
        /// Example: The carbon reduction efforts by EU banks in 2023 show a significant increase, with a 20% rise in initiatives driven by regulatory pressure.
        /// </summary>
        /// <example>The carbon reduction efforts by EU banks in 2023 show a significant increase, with a 20% rise in initiatives driven by regulatory pressure.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("generation")]
        public string? Generation { get; set; }

        /// <summary>
        /// The factual consistency score of the generation.<br/>
        /// Example: 0.98
        /// </summary>
        /// <example>0.98</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("factual_consistency_score")]
        public float? FactualConsistencyScore { get; set; }

        /// <summary>
        /// The agent key if this query was made through an agent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_key")]
        public string? AgentKey { get; set; }

        /// <summary>
        /// The session key if this query was made through an agent session.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_key")]
        public string? SessionKey { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryHistorySummary" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the query history.<br/>
        /// Example: qry_1234567890
        /// </param>
        /// <param name="query">
        /// The actual query made.
        /// </param>
        /// <param name="corpusKey">
        /// The corpus key that the query was made on.<br/>
        /// Example: eu_carbon
        /// </param>
        /// <param name="startedAt">
        /// ISO date time indicating when the query was first received.<br/>
        /// Example: 2025-06-01T12:00:00Z
        /// </param>
        /// <param name="latencyMillis">
        /// Time that the query took in milliseconds.<br/>
        /// Example: 50
        /// </param>
        /// <param name="chatId">
        /// The unique ID of the chat associated with the query, if this query is part of a chat.<br/>
        /// Example: chat_1234567890
        /// </param>
        /// <param name="generation">
        /// Generated response to the query, if requested.<br/>
        /// Example: The carbon reduction efforts by EU banks in 2023 show a significant increase, with a 20% rise in initiatives driven by regulatory pressure.
        /// </param>
        /// <param name="factualConsistencyScore">
        /// The factual consistency score of the generation.<br/>
        /// Example: 0.98
        /// </param>
        /// <param name="agentKey">
        /// The agent key if this query was made through an agent.
        /// </param>
        /// <param name="sessionKey">
        /// The session key if this query was made through an agent session.
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
            float? factualConsistencyScore,
            string? agentKey,
            string? sessionKey)
        {
            this.Id = id;
            this.Query = query;
            this.CorpusKey = corpusKey;
            this.StartedAt = startedAt;
            this.LatencyMillis = latencyMillis;
            this.ChatId = chatId;
            this.Generation = generation;
            this.FactualConsistencyScore = factualConsistencyScore;
            this.AgentKey = agentKey;
            this.SessionKey = sessionKey;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryHistorySummary" /> class.
        /// </summary>
        public QueryHistorySummary()
        {
        }
    }
}