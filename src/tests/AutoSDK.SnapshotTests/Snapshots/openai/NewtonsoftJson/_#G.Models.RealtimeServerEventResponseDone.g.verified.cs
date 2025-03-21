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
        [global::Newtonsoft.Json.JsonProperty("event_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string EventId { get; set; } = default!;

        /// <summary>
        /// The event type, must be `response.done`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.RealtimeServerEventResponseDoneType Type { get; set; }

        /// <summary>
        /// The response resource.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("response", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.RealtimeResponse Response { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeServerEventResponseDone" /> class.
        /// </summary>
        /// <param name="eventId">
        /// The unique ID of the server event.
        /// </param>
        /// <param name="type">
        /// The event type, must be `response.done`.
        /// </param>
        /// <param name="response">
        /// The response resource.
        /// </param>
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