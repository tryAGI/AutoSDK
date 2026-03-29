//HintName: G.Models.PostInternalTriggerLogsRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PostInternalTriggerLogsRequest
    {
        /// <summary>
        /// Return logs from the last N time units<br/>
        /// Example: 5m
        /// </summary>
        /// <example>5m</example>
        [global::Newtonsoft.Json.JsonProperty("time")]
        public global::G.PostInternalTriggerLogsRequestTime? Time { get; set; }

        /// <summary>
        /// Start time for logs (epoch timestamp in milliseconds)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("from")]
        public double? From { get; set; }

        /// <summary>
        /// End time for logs (epoch timestamp in milliseconds)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("to")]
        public double? To { get; set; }

        /// <summary>
        /// Filter logs by their status level<br/>
        /// Example: success
        /// </summary>
        /// <example>success</example>
        [global::Newtonsoft.Json.JsonProperty("status")]
        public global::G.PostInternalTriggerLogsRequestStatus? Status { get; set; }

        /// <summary>
        /// Search term to filter logs
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("search")]
        public string? Search { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("integrationId")]
        public global::System.Guid? IntegrationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("entityId")]
        public string? EntityId { get; set; }

        /// <summary>
        /// Filter logs by user ID
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("userId")]
        public string? UserId { get; set; }

        /// <summary>
        /// The limit of trigger logs to return<br/>
        /// Default Value: 20
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("limit")]
        public double? Limit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cursor")]
        public string? Cursor { get; set; }

        /// <summary>
        /// Advanced search parameters for filtering logs
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("search_params")]
        public global::System.Collections.Generic.IList<global::G.PostInternalTriggerLogsRequestSearchParam>? SearchParams { get; set; }

        /// <summary>
        /// Whether to include payload fields in the response. Set to false for faster list views.<br/>
        /// Default Value: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("include_payload")]
        public bool? IncludePayload { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostInternalTriggerLogsRequest" /> class.
        /// </summary>
        /// <param name="time">
        /// Return logs from the last N time units<br/>
        /// Example: 5m
        /// </param>
        /// <param name="from">
        /// Start time for logs (epoch timestamp in milliseconds)
        /// </param>
        /// <param name="to">
        /// End time for logs (epoch timestamp in milliseconds)
        /// </param>
        /// <param name="status">
        /// Filter logs by their status level<br/>
        /// Example: success
        /// </param>
        /// <param name="search">
        /// Search term to filter logs
        /// </param>
        /// <param name="integrationId"></param>
        /// <param name="entityId"></param>
        /// <param name="userId">
        /// Filter logs by user ID
        /// </param>
        /// <param name="limit">
        /// The limit of trigger logs to return<br/>
        /// Default Value: 20
        /// </param>
        /// <param name="cursor"></param>
        /// <param name="searchParams">
        /// Advanced search parameters for filtering logs
        /// </param>
        /// <param name="includePayload">
        /// Whether to include payload fields in the response. Set to false for faster list views.<br/>
        /// Default Value: true
        /// </param>
        public PostInternalTriggerLogsRequest(
            global::G.PostInternalTriggerLogsRequestTime? time,
            double? from,
            double? to,
            global::G.PostInternalTriggerLogsRequestStatus? status,
            string? search,
            global::System.Guid? integrationId,
            string? entityId,
            string? userId,
            double? limit,
            string? cursor,
            global::System.Collections.Generic.IList<global::G.PostInternalTriggerLogsRequestSearchParam>? searchParams,
            bool? includePayload)
        {
            this.Time = time;
            this.From = from;
            this.To = to;
            this.Status = status;
            this.Search = search;
            this.IntegrationId = integrationId;
            this.EntityId = entityId;
            this.UserId = userId;
            this.Limit = limit;
            this.Cursor = cursor;
            this.SearchParams = searchParams;
            this.IncludePayload = includePayload;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostInternalTriggerLogsRequest" /> class.
        /// </summary>
        public PostInternalTriggerLogsRequest()
        {
        }
    }
}