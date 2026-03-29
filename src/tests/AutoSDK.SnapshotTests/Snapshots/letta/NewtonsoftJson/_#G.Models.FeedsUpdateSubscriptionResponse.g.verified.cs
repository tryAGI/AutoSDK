//HintName: G.Models.FeedsUpdateSubscriptionResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FeedsUpdateSubscriptionResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("feed_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string FeedId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("agent_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string AgentId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("agent_name")]
        public string? AgentName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cron_schedule", Required = global::Newtonsoft.Json.Required.Always)]
        public string CronSchedule { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("merge_strategy", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.FeedsUpdateSubscriptionResponseMergeStrategy MergeStrategy { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt_template")]
        public string? PromptTemplate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("next_scheduled_at", Required = global::Newtonsoft.Json.Required.Always)]
        public string NextScheduledAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("last_consumed_sequence", Required = global::Newtonsoft.Json.Required.Always)]
        public double LastConsumedSequence { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("last_consumed_at")]
        public string? LastConsumedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("disabled_at")]
        public string? DisabledAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public string CreatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updated_at", Required = global::Newtonsoft.Json.Required.Always)]
        public string UpdatedAt { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FeedsUpdateSubscriptionResponse" /> class.
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
        public FeedsUpdateSubscriptionResponse(
            string id,
            string feedId,
            string agentId,
            string cronSchedule,
            global::G.FeedsUpdateSubscriptionResponseMergeStrategy mergeStrategy,
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
        /// Initializes a new instance of the <see cref="FeedsUpdateSubscriptionResponse" /> class.
        /// </summary>
        public FeedsUpdateSubscriptionResponse()
        {
        }
    }
}