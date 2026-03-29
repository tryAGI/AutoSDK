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
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("active_for")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double ActiveFor { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("first_active")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FirstActive { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_active")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string LastActive { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_requests")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double TotalRequests { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("average_requests_per_day_active")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double AverageRequestsPerDayActive { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("average_tokens_per_request")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double AverageTokensPerRequest { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_completion_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double TotalCompletionTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_prompt_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double TotalPromptTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cost")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Cost { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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