//HintName: G.Models.SearchAllMessagesRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SearchAllMessagesRequest
    {
        /// <summary>
        /// Text query for full-text search
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("query", Required = global::Newtonsoft.Json.Required.Always)]
        public string Query { get; set; } = default!;

        /// <summary>
        /// Search mode to use<br/>
        /// Default Value: hybrid
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("search_mode")]
        public global::G.SearchAllMessagesRequestSearchMode? SearchMode { get; set; }

        /// <summary>
        /// Filter messages by agent ID
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("agent_id")]
        public string? AgentId { get; set; }

        /// <summary>
        /// Filter messages by conversation ID
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("conversation_id")]
        public string? ConversationId { get; set; }

        /// <summary>
        /// Maximum number of results to return<br/>
        /// Default Value: 50
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("limit")]
        public int? Limit { get; set; }

        /// <summary>
        /// Filter messages created after this date
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("start_date")]
        public global::System.DateTime? StartDate { get; set; }

        /// <summary>
        /// Filter messages created on or before this date
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("end_date")]
        public global::System.DateTime? EndDate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchAllMessagesRequest" /> class.
        /// </summary>
        /// <param name="query">
        /// Text query for full-text search
        /// </param>
        /// <param name="searchMode">
        /// Search mode to use<br/>
        /// Default Value: hybrid
        /// </param>
        /// <param name="agentId">
        /// Filter messages by agent ID
        /// </param>
        /// <param name="conversationId">
        /// Filter messages by conversation ID
        /// </param>
        /// <param name="limit">
        /// Maximum number of results to return<br/>
        /// Default Value: 50
        /// </param>
        /// <param name="startDate">
        /// Filter messages created after this date
        /// </param>
        /// <param name="endDate">
        /// Filter messages created on or before this date
        /// </param>
        public SearchAllMessagesRequest(
            string query,
            global::G.SearchAllMessagesRequestSearchMode? searchMode,
            string? agentId,
            string? conversationId,
            int? limit,
            global::System.DateTime? startDate,
            global::System.DateTime? endDate)
        {
            this.Query = query ?? throw new global::System.ArgumentNullException(nameof(query));
            this.SearchMode = searchMode;
            this.AgentId = agentId;
            this.ConversationId = conversationId;
            this.Limit = limit;
            this.StartDate = startDate;
            this.EndDate = endDate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchAllMessagesRequest" /> class.
        /// </summary>
        public SearchAllMessagesRequest()
        {
        }
    }
}