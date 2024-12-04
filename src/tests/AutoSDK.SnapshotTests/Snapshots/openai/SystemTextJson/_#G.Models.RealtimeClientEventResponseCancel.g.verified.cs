//HintName: G.Models.RealtimeClientEventResponseCancel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Send this event to cancel an in-progress response. The server will respond <br/>
    /// with a `response.cancelled` event or an error if there is no response to <br/>
    /// cancel.
    /// </summary>
    public sealed partial class RealtimeClientEventResponseCancel
    {
        /// <summary>
        /// Optional client-generated ID used to identify this event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_id")]
        public string? EventId { get; set; }

        /// <summary>
        /// The event type, must be `response.cancel`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.RealtimeClientEventResponseCancelTypeJsonConverter))]
        public global::G.RealtimeClientEventResponseCancelType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeClientEventResponseCancel" /> class.
        /// </summary>
        /// <param name="eventId">
        /// Optional client-generated ID used to identify this event.
        /// </param>
        /// <param name="type">
        /// The event type, must be `response.cancel`.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public RealtimeClientEventResponseCancel(
            string? eventId,
            global::G.RealtimeClientEventResponseCancelType type)
        {
            this.EventId = eventId;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeClientEventResponseCancel" /> class.
        /// </summary>
        public RealtimeClientEventResponseCancel()
        {
        }
    }
}