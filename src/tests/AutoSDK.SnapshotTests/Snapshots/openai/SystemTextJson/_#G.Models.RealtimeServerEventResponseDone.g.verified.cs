//HintName: G.Models.RealtimeServerEventResponseDone.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Returned when a Response is done streaming. Always emitted, no matter the <br/>
    /// final state. The Response object included in the `response.done` event will <br/>
    /// include all output Items in the Response but will omit the raw audio data.
    /// </summary>
    public sealed partial class RealtimeServerEventResponseDone
    {
        /// <summary>
        /// The unique ID of the server event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EventId { get; set; }

        /// <summary>
        /// The response resource.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.RealtimeResponse Response { get; set; }

        /// <summary>
        /// The event type, must be `response.done`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.RealtimeServerEventResponseDoneTypeJsonConverter))]
        public global::G.RealtimeServerEventResponseDoneType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeServerEventResponseDone" /> class.
        /// </summary>
        /// <param name="eventId">
        /// The unique ID of the server event.
        /// </param>
        /// <param name="response">
        /// The response resource.
        /// </param>
        /// <param name="type">
        /// The event type, must be `response.done`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeServerEventResponseDone(
            string eventId,
            global::G.RealtimeResponse response,
            global::G.RealtimeServerEventResponseDoneType type)
        {
            this.EventId = eventId ?? throw new global::System.ArgumentNullException(nameof(eventId));
            this.Response = response ?? throw new global::System.ArgumentNullException(nameof(response));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeServerEventResponseDone" /> class.
        /// </summary>
        public RealtimeServerEventResponseDone()
        {
        }
    }
}