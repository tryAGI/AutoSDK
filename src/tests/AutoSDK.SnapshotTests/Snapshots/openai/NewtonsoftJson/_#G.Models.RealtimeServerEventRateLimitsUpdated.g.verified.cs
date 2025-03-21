//HintName: G.Models.RealtimeServerEventRateLimitsUpdated.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Emitted at the beginning of a Response to indicate the updated rate limits. <br/>
    /// When a Response is created some tokens will be "reserved" for the output <br/>
    /// tokens, the rate limits shown here reflect that reservation, which is then <br/>
    /// adjusted accordingly once the Response is completed.
    /// </summary>
    public sealed partial class RealtimeServerEventRateLimitsUpdated
    {
        /// <summary>
        /// The unique ID of the server event.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("event_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string EventId { get; set; } = default!;

        /// <summary>
        /// List of rate limit information.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("rate_limits", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.RealtimeServerEventRateLimitsUpdatedRateLimit> RateLimits { get; set; } = default!;

        /// <summary>
        /// The event type, must be `rate_limits.updated`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.RealtimeServerEventRateLimitsUpdatedType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeServerEventRateLimitsUpdated" /> class.
        /// </summary>
        /// <param name="eventId">
        /// The unique ID of the server event.
        /// </param>
        /// <param name="rateLimits">
        /// List of rate limit information.
        /// </param>
        /// <param name="type">
        /// The event type, must be `rate_limits.updated`.
        /// </param>
        public RealtimeServerEventRateLimitsUpdated(
            string eventId,
            global::System.Collections.Generic.IList<global::G.RealtimeServerEventRateLimitsUpdatedRateLimit> rateLimits,
            global::G.RealtimeServerEventRateLimitsUpdatedType type)
        {
            this.EventId = eventId ?? throw new global::System.ArgumentNullException(nameof(eventId));
            this.RateLimits = rateLimits ?? throw new global::System.ArgumentNullException(nameof(rateLimits));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeServerEventRateLimitsUpdated" /> class.
        /// </summary>
        public RealtimeServerEventRateLimitsUpdated()
        {
        }
    }
}