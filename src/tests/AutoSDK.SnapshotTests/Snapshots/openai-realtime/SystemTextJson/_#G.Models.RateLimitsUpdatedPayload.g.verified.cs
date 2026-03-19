//HintName: G.Models.RateLimitsUpdatedPayload.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Emitted after every response.done event to indicate updated rate limits.
    /// </summary>
    public sealed partial class RateLimitsUpdatedPayload
    {
        /// <summary>
        /// The unique ID of the server event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EventId { get; set; }

        /// <summary>
        /// The event type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.RateLimitsUpdatedPayloadTypeJsonConverter))]
        public global::G.RateLimitsUpdatedPayloadType Type { get; set; }

        /// <summary>
        /// List of rate limit information.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rate_limits")]
        public global::System.Collections.Generic.IList<global::G.RateLimitInfo>? RateLimits { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RateLimitsUpdatedPayload" /> class.
        /// </summary>
        /// <param name="eventId">
        /// The unique ID of the server event.
        /// </param>
        /// <param name="type">
        /// The event type.
        /// </param>
        /// <param name="rateLimits">
        /// List of rate limit information.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RateLimitsUpdatedPayload(
            string eventId,
            global::G.RateLimitsUpdatedPayloadType type,
            global::System.Collections.Generic.IList<global::G.RateLimitInfo>? rateLimits)
        {
            this.EventId = eventId ?? throw new global::System.ArgumentNullException(nameof(eventId));
            this.Type = type;
            this.RateLimits = rateLimits;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RateLimitsUpdatedPayload" /> class.
        /// </summary>
        public RateLimitsUpdatedPayload()
        {
        }
    }
}