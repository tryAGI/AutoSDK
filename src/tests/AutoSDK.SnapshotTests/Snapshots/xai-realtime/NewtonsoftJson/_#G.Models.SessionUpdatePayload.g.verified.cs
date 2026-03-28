//HintName: G.Models.SessionUpdatePayload.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Update session configuration.
    /// </summary>
    public sealed partial class SessionUpdatePayload
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.SessionUpdatePayloadType Type { get; set; }

        /// <summary>
        /// Optional event ID.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("event_id")]
        public string? EventId { get; set; }

        /// <summary>
        /// Configuration for an xAI Realtime session.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("session", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.SessionConfig Session { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionUpdatePayload" /> class.
        /// </summary>
        /// <param name="session">
        /// Configuration for an xAI Realtime session.
        /// </param>
        /// <param name="type"></param>
        /// <param name="eventId">
        /// Optional event ID.
        /// </param>
        public SessionUpdatePayload(
            global::G.SessionConfig session,
            global::G.SessionUpdatePayloadType type,
            string? eventId)
        {
            this.Type = type;
            this.EventId = eventId;
            this.Session = session ?? throw new global::System.ArgumentNullException(nameof(session));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionUpdatePayload" /> class.
        /// </summary>
        public SessionUpdatePayload()
        {
        }
    }
}