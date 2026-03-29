//HintName: G.Models.SessionResult.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SessionResult
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public string CreatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("latest_request_created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public string LatestRequestCreatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("session_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string SessionId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("session_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string SessionName { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_cost", Required = global::Newtonsoft.Json.Required.Always)]
        public double TotalCost { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_requests", Required = global::Newtonsoft.Json.Required.Always)]
        public double TotalRequests { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt_tokens", Required = global::Newtonsoft.Json.Required.Always)]
        public double PromptTokens { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("completion_tokens", Required = global::Newtonsoft.Json.Required.Always)]
        public double CompletionTokens { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_tokens", Required = global::Newtonsoft.Json.Required.Always)]
        public double TotalTokens { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("avg_latency", Required = global::Newtonsoft.Json.Required.Always)]
        public double AvgLatency { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user_ids", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> UserIds { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionResult" /> class.
        /// </summary>
        /// <param name="createdAt"></param>
        /// <param name="latestRequestCreatedAt"></param>
        /// <param name="sessionId"></param>
        /// <param name="sessionName"></param>
        /// <param name="totalCost"></param>
        /// <param name="totalRequests"></param>
        /// <param name="promptTokens"></param>
        /// <param name="completionTokens"></param>
        /// <param name="totalTokens"></param>
        /// <param name="avgLatency"></param>
        /// <param name="userIds"></param>
        public SessionResult(
            string createdAt,
            string latestRequestCreatedAt,
            string sessionId,
            string sessionName,
            double totalCost,
            double totalRequests,
            double promptTokens,
            double completionTokens,
            double totalTokens,
            double avgLatency,
            global::System.Collections.Generic.IList<string> userIds)
        {
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.LatestRequestCreatedAt = latestRequestCreatedAt ?? throw new global::System.ArgumentNullException(nameof(latestRequestCreatedAt));
            this.SessionId = sessionId ?? throw new global::System.ArgumentNullException(nameof(sessionId));
            this.SessionName = sessionName ?? throw new global::System.ArgumentNullException(nameof(sessionName));
            this.TotalCost = totalCost;
            this.TotalRequests = totalRequests;
            this.PromptTokens = promptTokens;
            this.CompletionTokens = completionTokens;
            this.TotalTokens = totalTokens;
            this.AvgLatency = avgLatency;
            this.UserIds = userIds ?? throw new global::System.ArgumentNullException(nameof(userIds));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionResult" /> class.
        /// </summary>
        public SessionResult()
        {
        }
    }
}