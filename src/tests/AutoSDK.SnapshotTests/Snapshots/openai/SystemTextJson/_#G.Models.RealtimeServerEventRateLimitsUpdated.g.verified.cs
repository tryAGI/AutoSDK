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
        [global::System.Text.Json.Serialization.JsonPropertyName("event_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EventId { get; set; }

        /// <summary>
        /// The event type, must be `rate_limits.updated`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.RealtimeServerEventRateLimitsUpdatedTypeJsonConverter))]
        public global::G.RealtimeServerEventRateLimitsUpdatedType Type { get; set; }

        /// <summary>
        /// List of rate limit information.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rate_limits")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.RealtimeServerEventRateLimitsUpdatedRateLimit> RateLimits { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeServerEventRateLimitsUpdated" /> class.
        /// </summary>
        /// <param name="eventId">
        /// The unique ID of the server event.
        /// </param>
        /// <param name="type">
        /// The event type, must be `rate_limits.updated`.
        /// </param>
        /// <param name="rateLimits">
        /// List of rate limit information.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
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