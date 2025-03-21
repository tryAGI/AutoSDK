//HintName: G.Models.RealtimeServerEventResponseCreated.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Returned when a new Response is created. The first event of response creation,<br/>
    /// where the response is in an initial state of `in_progress`.
    /// </summary>
    public sealed partial class RealtimeServerEventResponseCreated
    {
        /// <summary>
        /// The unique ID of the server event.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("event_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string EventId { get; set; } = default!;

        /// <summary>
        /// The response resource.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("response", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.RealtimeResponse Response { get; set; } = default!;

        /// <summary>
        /// The event type, must be `response.created`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.RealtimeServerEventResponseCreatedType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeServerEventResponseCreated" /> class.
        /// </summary>
        /// <param name="eventId">
        /// The unique ID of the server event.
        /// </param>
        /// <param name="response">
        /// The response resource.
        /// </param>
        /// <param name="type">
        /// The event type, must be `response.created`.
        /// </param>
        public RealtimeServerEventResponseCreated(
            string eventId,
            global::G.RealtimeResponse response,
            global::G.RealtimeServerEventResponseCreatedType type)
        {
            this.EventId = eventId ?? throw new global::System.ArgumentNullException(nameof(eventId));
            this.Response = response ?? throw new global::System.ArgumentNullException(nameof(response));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeServerEventResponseCreated" /> class.
        /// </summary>
        public RealtimeServerEventResponseCreated()
        {
        }
    }
}