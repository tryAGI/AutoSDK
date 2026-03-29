//HintName: G.Models.SortLeafUsers.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SortLeafUsers
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public global::G.SortDirection? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user_id")]
        public global::G.SortDirection? UserId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("active_for")]
        public global::G.SortDirection? ActiveFor { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("first_active")]
        public global::G.SortDirection? FirstActive { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("last_active")]
        public global::G.SortDirection? LastActive { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_requests")]
        public global::G.SortDirection? TotalRequests { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("average_requests_per_day_active")]
        public global::G.SortDirection? AverageRequestsPerDayActive { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("average_tokens_per_request")]
        public global::G.SortDirection? AverageTokensPerRequest { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_prompt_tokens")]
        public global::G.SortDirection? TotalPromptTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_completion_tokens")]
        public global::G.SortDirection? TotalCompletionTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cost")]
        public global::G.SortDirection? Cost { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("rate_limited_count")]
        public global::G.SortDirection? RateLimitedCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SortLeafUsers" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="userId"></param>
        /// <param name="activeFor"></param>
        /// <param name="firstActive"></param>
        /// <param name="lastActive"></param>
        /// <param name="totalRequests"></param>
        /// <param name="averageRequestsPerDayActive"></param>
        /// <param name="averageTokensPerRequest"></param>
        /// <param name="totalPromptTokens"></param>
        /// <param name="totalCompletionTokens"></param>
        /// <param name="cost"></param>
        /// <param name="rateLimitedCount"></param>
        public SortLeafUsers(
            global::G.SortDirection? id,
            global::G.SortDirection? userId,
            global::G.SortDirection? activeFor,
            global::G.SortDirection? firstActive,
            global::G.SortDirection? lastActive,
            global::G.SortDirection? totalRequests,
            global::G.SortDirection? averageRequestsPerDayActive,
            global::G.SortDirection? averageTokensPerRequest,
            global::G.SortDirection? totalPromptTokens,
            global::G.SortDirection? totalCompletionTokens,
            global::G.SortDirection? cost,
            global::G.SortDirection? rateLimitedCount)
        {
            this.Id = id;
            this.UserId = userId;
            this.ActiveFor = activeFor;
            this.FirstActive = firstActive;
            this.LastActive = lastActive;
            this.TotalRequests = totalRequests;
            this.AverageRequestsPerDayActive = averageRequestsPerDayActive;
            this.AverageTokensPerRequest = averageTokensPerRequest;
            this.TotalPromptTokens = totalPromptTokens;
            this.TotalCompletionTokens = totalCompletionTokens;
            this.Cost = cost;
            this.RateLimitedCount = rateLimitedCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SortLeafUsers" /> class.
        /// </summary>
        public SortLeafUsers()
        {
        }
    }
}