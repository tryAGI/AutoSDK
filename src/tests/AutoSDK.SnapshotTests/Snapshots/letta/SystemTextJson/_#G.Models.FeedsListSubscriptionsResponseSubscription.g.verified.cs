//HintName: G.Models.FeedsListSubscriptionsResponseSubscription.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FeedsListSubscriptionsResponseSubscription
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
        [global::System.Text.Json.Serialization.JsonPropertyName("feed_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FeedId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AgentId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_name")]
        public string? AgentName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cron_schedule")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CronSchedule { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("merge_strategy")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.FeedsListSubscriptionsResponseSubscriptionMergeStrategyJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.FeedsListSubscriptionsResponseSubscriptionMergeStrategy MergeStrategy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_template")]
        public string? PromptTemplate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_scheduled_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NextScheduledAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_consumed_sequence")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double LastConsumedSequence { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_consumed_at")]
        public string? LastConsumedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disabled_at")]
        public string? DisabledAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FeedsListSubscriptionsResponseSubscription" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="feedId"></param>
        /// <param name="agentId"></param>
        /// <param name="cronSchedule"></param>
        /// <param name="mergeStrategy"></param>
        /// <param name="nextScheduledAt"></param>
        /// <param name="lastConsumedSequence"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="agentName"></param>
        /// <param name="promptTemplate"></param>
        /// <param name="lastConsumedAt"></param>
        /// <param name="disabledAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FeedsListSubscriptionsResponseSubscription(
            string id,
            string feedId,
            string agentId,
            string cronSchedule,
            global::G.FeedsListSubscriptionsResponseSubscriptionMergeStrategy mergeStrategy,
            string nextScheduledAt,
            double lastConsumedSequence,
            string createdAt,
            string updatedAt,
            string? agentName,
            string? promptTemplate,
            string? lastConsumedAt,
            string? disabledAt)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.FeedId = feedId ?? throw new global::System.ArgumentNullException(nameof(feedId));
            this.AgentId = agentId ?? throw new global::System.ArgumentNullException(nameof(agentId));
            this.AgentName = agentName;
            this.CronSchedule = cronSchedule ?? throw new global::System.ArgumentNullException(nameof(cronSchedule));
            this.MergeStrategy = mergeStrategy;
            this.PromptTemplate = promptTemplate;
            this.NextScheduledAt = nextScheduledAt ?? throw new global::System.ArgumentNullException(nameof(nextScheduledAt));
            this.LastConsumedSequence = lastConsumedSequence;
            this.LastConsumedAt = lastConsumedAt;
            this.DisabledAt = disabledAt;
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.UpdatedAt = updatedAt ?? throw new global::System.ArgumentNullException(nameof(updatedAt));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FeedsListSubscriptionsResponseSubscription" /> class.
        /// </summary>
        public FeedsListSubscriptionsResponseSubscription()
        {
        }
    }
}