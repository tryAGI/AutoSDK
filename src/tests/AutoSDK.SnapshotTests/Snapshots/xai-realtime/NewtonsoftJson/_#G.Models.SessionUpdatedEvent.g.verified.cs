//HintName: G.Models.SessionUpdatedEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Session configuration has been updated.
    /// </summary>
    public sealed partial class SessionUpdatedEvent
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.SessionUpdatedEventType? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("event_id")]
        public string? EventId { get; set; }

        /// <summary>
        /// Session information from the server.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("session")]
        public global::G.SessionInfo? Session { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionUpdatedEvent" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="eventId"></param>
        /// <param name="session">
        /// Session information from the server.
        /// </param>
        public SessionUpdatedEvent(
            global::G.SessionUpdatedEventType? type,
            string? eventId,
            global::G.SessionInfo? session)
        {
            this.Type = type;
            this.EventId = eventId;
            this.Session = session;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionUpdatedEvent" /> class.
        /// </summary>
        public SessionUpdatedEvent()
        {
        }
    }
}