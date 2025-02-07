//HintName: G.Models.HypeTrainEventEventData.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The event’s data.
    /// </summary>
    public sealed partial class HypeTrainEventEventData
    {
        /// <summary>
        /// The ID of the broadcaster that’s running the Hype Train.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("broadcaster_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BroadcasterId { get; set; }

        /// <summary>
        /// The UTC date and time (in RFC3339 format) that another Hype Train can start.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cooldown_end_time")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CooldownEndTime { get; set; }

        /// <summary>
        /// The UTC date and time (in RFC3339 format) that the Hype Train ends.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime ExpiresAt { get; set; }

        /// <summary>
        /// The value needed to reach the next level.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("goal")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Goal { get; set; }

        /// <summary>
        /// An ID that identifies this Hype Train.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The most recent contribution towards the Hype Train’s goal.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_contribution")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.HypeTrainEventEventDataLastContribution LastContribution { get; set; }

        /// <summary>
        /// The highest level that the Hype Train reached (the levels are 1 through 5).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("level")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Level { get; set; }

        /// <summary>
        /// The UTC date and time (in RFC3339 format) that this Hype Train started.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("started_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime StartedAt { get; set; }

        /// <summary>
        /// The top contributors for each contribution type. For example, the top contributor using BITS (by aggregate) and the top contributor using SUBS (by count).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_contributions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.HypeTrainEventEventDataTopContribution> TopContributions { get; set; }

        /// <summary>
        /// The current total amount raised.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Total { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HypeTrainEventEventData" /> class.
        /// </summary>
        /// <param name="broadcasterId">
        /// The ID of the broadcaster that’s running the Hype Train.
        /// </param>
        /// <param name="cooldownEndTime">
        /// The UTC date and time (in RFC3339 format) that another Hype Train can start.
        /// </param>
        /// <param name="expiresAt">
        /// The UTC date and time (in RFC3339 format) that the Hype Train ends.
        /// </param>
        /// <param name="goal">
        /// The value needed to reach the next level.
        /// </param>
        /// <param name="id">
        /// An ID that identifies this Hype Train.
        /// </param>
        /// <param name="lastContribution">
        /// The most recent contribution towards the Hype Train’s goal.
        /// </param>
        /// <param name="level">
        /// The highest level that the Hype Train reached (the levels are 1 through 5).
        /// </param>
        /// <param name="startedAt">
        /// The UTC date and time (in RFC3339 format) that this Hype Train started.
        /// </param>
        /// <param name="topContributions">
        /// The top contributors for each contribution type. For example, the top contributor using BITS (by aggregate) and the top contributor using SUBS (by count).
        /// </param>
        /// <param name="total">
        /// The current total amount raised.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public HypeTrainEventEventData(
            string broadcasterId,
            global::System.DateTime cooldownEndTime,
            global::System.DateTime expiresAt,
            int goal,
            string id,
            global::G.HypeTrainEventEventDataLastContribution lastContribution,
            int level,
            global::System.DateTime startedAt,
            global::System.Collections.Generic.IList<global::G.HypeTrainEventEventDataTopContribution> topContributions,
            int total)
        {
            this.BroadcasterId = broadcasterId ?? throw new global::System.ArgumentNullException(nameof(broadcasterId));
            this.CooldownEndTime = cooldownEndTime;
            this.ExpiresAt = expiresAt;
            this.Goal = goal;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.LastContribution = lastContribution ?? throw new global::System.ArgumentNullException(nameof(lastContribution));
            this.Level = level;
            this.StartedAt = startedAt;
            this.TopContributions = topContributions ?? throw new global::System.ArgumentNullException(nameof(topContributions));
            this.Total = total;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HypeTrainEventEventData" /> class.
        /// </summary>
        public HypeTrainEventEventData()
        {
        }
    }
}