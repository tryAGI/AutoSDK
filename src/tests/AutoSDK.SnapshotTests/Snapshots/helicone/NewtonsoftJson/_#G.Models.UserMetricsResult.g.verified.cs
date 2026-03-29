//HintName: G.Models.UserMetricsResult.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UserMetricsResult
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string UserId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("active_for", Required = global::Newtonsoft.Json.Required.Always)]
        public double ActiveFor { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("first_active", Required = global::Newtonsoft.Json.Required.Always)]
        public string FirstActive { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("last_active", Required = global::Newtonsoft.Json.Required.Always)]
        public string LastActive { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_requests", Required = global::Newtonsoft.Json.Required.Always)]
        public double TotalRequests { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("average_requests_per_day_active", Required = global::Newtonsoft.Json.Required.Always)]
        public double AverageRequestsPerDayActive { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("average_tokens_per_request", Required = global::Newtonsoft.Json.Required.Always)]
        public double AverageTokensPerRequest { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_completion_tokens", Required = global::Newtonsoft.Json.Required.Always)]
        public double TotalCompletionTokens { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_prompt_tokens", Required = global::Newtonsoft.Json.Required.Always)]
        public double TotalPromptTokens { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cost", Required = global::Newtonsoft.Json.Required.Always)]
        public double Cost { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserMetricsResult" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="userId"></param>
        /// <param name="activeFor"></param>
        /// <param name="firstActive"></param>
        /// <param name="lastActive"></param>
        /// <param name="totalRequests"></param>
        /// <param name="averageRequestsPerDayActive"></param>
        /// <param name="averageTokensPerRequest"></param>
        /// <param name="totalCompletionTokens"></param>
        /// <param name="totalPromptTokens"></param>
        /// <param name="cost"></param>
        public UserMetricsResult(
            string id,
            string userId,
            double activeFor,
            string firstActive,
            string lastActive,
            double totalRequests,
            double averageRequestsPerDayActive,
            double averageTokensPerRequest,
            double totalCompletionTokens,
            double totalPromptTokens,
            double cost)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.UserId = userId ?? throw new global::System.ArgumentNullException(nameof(userId));
            this.ActiveFor = activeFor;
            this.FirstActive = firstActive ?? throw new global::System.ArgumentNullException(nameof(firstActive));
            this.LastActive = lastActive ?? throw new global::System.ArgumentNullException(nameof(lastActive));
            this.TotalRequests = totalRequests;
            this.AverageRequestsPerDayActive = averageRequestsPerDayActive;
            this.AverageTokensPerRequest = averageTokensPerRequest;
            this.TotalCompletionTokens = totalCompletionTokens;
            this.TotalPromptTokens = totalPromptTokens;
            this.Cost = cost;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserMetricsResult" /> class.
        /// </summary>
        public UserMetricsResult()
        {
        }
    }
}