//HintName: G.Models.RealtimeServerEventRateLimitsUpdatedRateLimit.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RealtimeServerEventRateLimitsUpdatedRateLimit
    {
        /// <summary>
        /// The maximum allowed value for the rate limit.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        public int? Limit { get; set; }

        /// <summary>
        /// The name of the rate limit (`requests`, `tokens`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.RealtimeServerEventRateLimitsUpdatedRateLimitNameJsonConverter))]
        public global::G.RealtimeServerEventRateLimitsUpdatedRateLimitName? Name { get; set; }

        /// <summary>
        /// The remaining value before the limit is reached.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("remaining")]
        public int? Remaining { get; set; }

        /// <summary>
        /// Seconds until the rate limit resets.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reset_seconds")]
        public double? ResetSeconds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeServerEventRateLimitsUpdatedRateLimit" /> class.
        /// </summary>
        /// <param name="limit">
        /// The maximum allowed value for the rate limit.
        /// </param>
        /// <param name="name">
        /// The name of the rate limit (`requests`, `tokens`).
        /// </param>
        /// <param name="remaining">
        /// The remaining value before the limit is reached.
        /// </param>
        /// <param name="resetSeconds">
        /// Seconds until the rate limit resets.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeServerEventRateLimitsUpdatedRateLimit(
            int? limit,
            global::G.RealtimeServerEventRateLimitsUpdatedRateLimitName? name,
            int? remaining,
            double? resetSeconds)
        {
            this.Limit = limit;
            this.Name = name;
            this.Remaining = remaining;
            this.ResetSeconds = resetSeconds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeServerEventRateLimitsUpdatedRateLimit" /> class.
        /// </summary>
        public RealtimeServerEventRateLimitsUpdatedRateLimit()
        {
        }
    }
}