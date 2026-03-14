//HintName: G.Models.QueryHistory.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A complete record of a previously executed query, including the request parameters and response.
    /// </summary>
    public sealed partial class QueryHistory
    {
        /// <summary>
        /// The ID of the query history.<br/>
        /// Example: qry_1234567890
        /// </summary>
        /// <example>qry_1234567890</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Query one or more corpora.<br/>
        /// Example: {"query":"Summarize risk exposure and QA issues across divisions","search":{"corpora":[{"corpus_key":"ops_manuals","metadata_filter":"doc.topic = \u0027QA\u0027 AND doc.severity = \u0027high\u0027","lexical_interpolation":0.005},{"corpus_key":"fin_docs","metadata_filter":"doc.region = \u0027EMEA\u0027 AND doc.type = \u0027risk_report\u0027","lexical_interpolation":0.005}],"context_configuration":{"sentences_before":2,"sentences_after":2,"start_tag":"\u003Cem\u003E","end_tag":"\u003C/em\u003E"},"reranker":{"type":"customer_reranker","reranker_name":"Rerank_Multilingual_v1"}},"generation":{"generation_preset_name":"vectara-summary-ext-24-05-med-omni","response_language":"eng","enable_factual_consistency_score":true},"stream_response":false}
        /// </summary>
        /// <example>{"query":"Summarize risk exposure and QA issues across divisions","search":{"corpora":[{"corpus_key":"ops_manuals","metadata_filter":"doc.topic = \u0027QA\u0027 AND doc.severity = \u0027high\u0027","lexical_interpolation":0.005},{"corpus_key":"fin_docs","metadata_filter":"doc.region = \u0027EMEA\u0027 AND doc.type = \u0027risk_report\u0027","lexical_interpolation":0.005}],"context_configuration":{"sentences_before":2,"sentences_after":2,"start_tag":"\u003Cem\u003E","end_tag":"\u003C/em\u003E"},"reranker":{"type":"customer_reranker","reranker_name":"Rerank_Multilingual_v1"}},"generation":{"generation_preset_name":"vectara-summary-ext-24-05-med-omni","response_language":"eng","enable_factual_consistency_score":true},"stream_response":false}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("query")]
        public global::G.QueryRequest? Query { get; set; }

        /// <summary>
        /// The ID of the chat the query is a part of.<br/>
        /// Example: chat_1234567890
        /// </summary>
        /// <example>chat_1234567890</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("chat_id")]
        public string? ChatId { get; set; }

        /// <summary>
        /// Time taken to complete the query, measured in milliseconds.<br/>
        /// Example: 150
        /// </summary>
        /// <example>150</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("latency_millis")]
        public int? LatencyMillis { get; set; }

        /// <summary>
        /// ISO date time indicating when the query was first received.<br/>
        /// Example: 2025-06-01T12:00:00Z
        /// </summary>
        /// <example>2025-06-01T12:00:00Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("started_at")]
        public global::System.DateTime? StartedAt { get; set; }

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
        /// Parts of the query pipeline. Each span explains what happened during that stage of the query pipeline.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("spans")]
        public global::System.Collections.Generic.IList<global::G.QueryHistorySpan>? Spans { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryHistory" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the query history.<br/>
        /// Example: qry_1234567890
        /// </param>
        /// <param name="query">
        /// Query one or more corpora.<br/>
        /// Example: {"query":"Summarize risk exposure and QA issues across divisions","search":{"corpora":[{"corpus_key":"ops_manuals","metadata_filter":"doc.topic = \u0027QA\u0027 AND doc.severity = \u0027high\u0027","lexical_interpolation":0.005},{"corpus_key":"fin_docs","metadata_filter":"doc.region = \u0027EMEA\u0027 AND doc.type = \u0027risk_report\u0027","lexical_interpolation":0.005}],"context_configuration":{"sentences_before":2,"sentences_after":2,"start_tag":"\u003Cem\u003E","end_tag":"\u003C/em\u003E"},"reranker":{"type":"customer_reranker","reranker_name":"Rerank_Multilingual_v1"}},"generation":{"generation_preset_name":"vectara-summary-ext-24-05-med-omni","response_language":"eng","enable_factual_consistency_score":true},"stream_response":false}
        /// </param>
        /// <param name="chatId">
        /// The ID of the chat the query is a part of.<br/>
        /// Example: chat_1234567890
        /// </param>
        /// <param name="latencyMillis">
        /// Time taken to complete the query, measured in milliseconds.<br/>
        /// Example: 150
        /// </param>
        /// <param name="startedAt">
        /// ISO date time indicating when the query was first received.<br/>
        /// Example: 2025-06-01T12:00:00Z
        /// </param>
        /// <param name="agentKey">
        /// The agent key if this query was made through an agent.
        /// </param>
        /// <param name="sessionKey">
        /// The session key if this query was made through an agent session.
        /// </param>
        /// <param name="spans">
        /// Parts of the query pipeline. Each span explains what happened during that stage of the query pipeline.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public QueryHistory(
            string? id,
            global::G.QueryRequest? query,
            string? chatId,
            int? latencyMillis,
            global::System.DateTime? startedAt,
            string? agentKey,
            string? sessionKey,
            global::System.Collections.Generic.IList<global::G.QueryHistorySpan>? spans)
        {
            this.Id = id;
            this.Query = query;
            this.ChatId = chatId;
            this.LatencyMillis = latencyMillis;
            this.StartedAt = startedAt;
            this.AgentKey = agentKey;
            this.SessionKey = sessionKey;
            this.Spans = spans;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryHistory" /> class.
        /// </summary>
        public QueryHistory()
        {
        }
    }
}