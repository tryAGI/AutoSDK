//HintName: G.Models.RealtimeClientEventSessionUpdate.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Send this event to update the session’s default configuration.<br/>
    /// The client may send this event at any time to update any field,<br/>
    /// except for `voice`. However, note that once a session has been<br/>
    /// initialized with a particular `model`, it can’t be changed to<br/>
    /// another model using `session.update`.<br/>
    /// When the server receives a `session.update`, it will respond<br/>
    /// with a `session.updated` event showing the full, effective configuration.<br/>
    /// Only the fields that are present are updated. To clear a field like<br/>
    /// `instructions`, pass an empty string.
    /// </summary>
    public sealed partial class RealtimeClientEventSessionUpdate
    {
        /// <summary>
        /// Optional client-generated ID used to identify this event.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("event_id")]
        public string? EventId { get; set; }

        /// <summary>
        /// The event type, must be `session.update`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.RealtimeClientEventSessionUpdateType Type { get; set; }

        /// <summary>
        /// Realtime session object configuration.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("session", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.RealtimeSessionCreateRequest Session { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeClientEventSessionUpdate" /> class.
        /// </summary>
        /// <param name="eventId">
        /// Optional client-generated ID used to identify this event.
        /// </param>
        /// <param name="type">
        /// The event type, must be `session.update`.
        /// </param>
        /// <param name="session">
        /// Realtime session object configuration.
        /// </param>
        public RealtimeClientEventSessionUpdate(
            global::G.RealtimeSessionCreateRequest session,
            string? eventId,
            global::G.RealtimeClientEventSessionUpdateType type)
        {
            this.Session = session ?? throw new global::System.ArgumentNullException(nameof(session));
            this.EventId = eventId;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeClientEventSessionUpdate" /> class.
        /// </summary>
        public RealtimeClientEventSessionUpdate()
        {
        }
    }
}