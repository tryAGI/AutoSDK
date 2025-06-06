﻿//HintName: G.Models.RealtimeServerEventRateLimitsUpdatedRateLimit.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RealtimeServerEventRateLimitsUpdatedRateLimit
    {
        /// <summary>
        /// The name of the rate limit (`requests`, `tokens`).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public global::G.RealtimeServerEventRateLimitsUpdatedRateLimitName? Name { get; set; }

        /// <summary>
        /// The maximum allowed value for the rate limit.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("limit")]
        public int? Limit { get; set; }

        /// <summary>
        /// The remaining value before the limit is reached.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("remaining")]
        public int? Remaining { get; set; }

        /// <summary>
        /// Seconds until the rate limit resets.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("reset_seconds")]
        public double? ResetSeconds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeServerEventRateLimitsUpdatedRateLimit" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the rate limit (`requests`, `tokens`).
        /// </param>
        /// <param name="limit">
        /// The maximum allowed value for the rate limit.
        /// </param>
        /// <param name="remaining">
        /// The remaining value before the limit is reached.
        /// </param>
        /// <param name="resetSeconds">
        /// Seconds until the rate limit resets.
        /// </param>
        public RealtimeServerEventRateLimitsUpdatedRateLimit(
            global::G.RealtimeServerEventRateLimitsUpdatedRateLimitName? name,
            int? limit,
            int? remaining,
            double? resetSeconds)
        {
            this.Name = name;
            this.Limit = limit;
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