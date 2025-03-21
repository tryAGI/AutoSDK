//HintName: G.Models.RealtimeServerEventError.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Returned when an error occurs, which could be a client problem or a server <br/>
    /// problem. Most errors are recoverable and the session will stay open, we <br/>
    /// recommend to implementors to monitor and log error messages by default.
    /// </summary>
    public sealed partial class RealtimeServerEventError
    {
        /// <summary>
        /// Details of the error.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("error", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.RealtimeServerEventErrorError Error { get; set; } = default!;

        /// <summary>
        /// The unique ID of the server event.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("event_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string EventId { get; set; } = default!;

        /// <summary>
        /// The event type, must be `error`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.RealtimeServerEventErrorType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeServerEventError" /> class.
        /// </summary>
        /// <param name="error">
        /// Details of the error.
        /// </param>
        /// <param name="eventId">
        /// The unique ID of the server event.
        /// </param>
        /// <param name="type">
        /// The event type, must be `error`.
        /// </param>
        public RealtimeServerEventError(
            global::G.RealtimeServerEventErrorError error,
            string eventId,
            global::G.RealtimeServerEventErrorType type)
        {
            this.Error = error ?? throw new global::System.ArgumentNullException(nameof(error));
            this.EventId = eventId ?? throw new global::System.ArgumentNullException(nameof(eventId));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeServerEventError" /> class.
        /// </summary>
        public RealtimeServerEventError()
        {
        }
    }
}