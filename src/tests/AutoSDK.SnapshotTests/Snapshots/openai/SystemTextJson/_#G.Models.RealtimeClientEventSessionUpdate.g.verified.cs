//HintName: G.Models.RealtimeClientEventSessionUpdate.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Send this event to update the session’s default configuration. The client may <br/>
    /// send this event at any time to update the session configuration, and any <br/>
    /// field may be updated at any time, except for "voice". The server will respond <br/>
    /// with a `session.updated` event that shows the full effective configuration. <br/>
    /// Only fields that are present are updated, thus the correct way to clear a <br/>
    /// field like "instructions" is to pass an empty string.
    /// </summary>
    public sealed partial class RealtimeClientEventSessionUpdate
    {
        /// <summary>
        /// Optional client-generated ID used to identify this event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_id")]
        public string? EventId { get; set; }

        /// <summary>
        /// The event type, must be `session.update`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.RealtimeClientEventSessionUpdateTypeJsonConverter))]
        public global::G.RealtimeClientEventSessionUpdateType Type { get; set; }

        /// <summary>
        /// Realtime session object configuration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.RealtimeSession Session { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public RealtimeClientEventSessionUpdate(
            global::G.RealtimeSession session,
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