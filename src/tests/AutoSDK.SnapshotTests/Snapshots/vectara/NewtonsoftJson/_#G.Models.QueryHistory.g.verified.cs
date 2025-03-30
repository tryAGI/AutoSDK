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
        /// The ID of the query history.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Query one or more corpora.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("query")]
        public global::G.QueryRequest? Query { get; set; }

        /// <summary>
        /// The ID of the chat the query is a part of.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("chat_id")]
        public string? ChatId { get; set; }

        /// <summary>
        /// Time taken to complete the query, measured in milliseconds.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("latency_millis")]
        public int? LatencyMillis { get; set; }

        /// <summary>
        /// ISO date time indicating when the query was first received.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("started_at")]
        public global::System.DateTime? StartedAt { get; set; }

        /// <summary>
        /// Parts of the query pipeline. Each span explains what happened during that stage of the query pipeline.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("spans")]
        public global::System.Collections.Generic.IList<global::G.QueryHistorySpan>? Spans { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryHistory" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the query history.
        /// </param>
        /// <param name="query">
        /// Query one or more corpora.
        /// </param>
        /// <param name="chatId">
        /// The ID of the chat the query is a part of.
        /// </param>
        /// <param name="latencyMillis">
        /// Time taken to complete the query, measured in milliseconds.
        /// </param>
        /// <param name="startedAt">
        /// ISO date time indicating when the query was first received.
        /// </param>
        /// <param name="spans">
        /// Parts of the query pipeline. Each span explains what happened during that stage of the query pipeline.
        /// </param>
        public QueryHistory(
            string? id,
            global::G.QueryRequest? query,
            string? chatId,
            int? latencyMillis,
            global::System.DateTime? startedAt,
            global::System.Collections.Generic.IList<global::G.QueryHistorySpan>? spans)
        {
            this.Id = id;
            this.Query = query;
            this.ChatId = chatId;
            this.LatencyMillis = latencyMillis;
            this.StartedAt = startedAt;
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