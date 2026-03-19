//HintName: G.Models.ErrorPayload.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Returned when an error occurs.
    /// </summary>
    public sealed partial class ErrorPayload
    {
        /// <summary>
        /// The unique ID of the server event.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("event_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string EventId { get; set; } = default!;

        /// <summary>
        /// The event type.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.ErrorPayloadType Type { get; set; }

        /// <summary>
        /// Details of an error.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("error")]
        public global::G.ErrorDetails? Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorPayload" /> class.
        /// </summary>
        /// <param name="eventId">
        /// The unique ID of the server event.
        /// </param>
        /// <param name="type">
        /// The event type.
        /// </param>
        /// <param name="error">
        /// Details of an error.
        /// </param>
        public ErrorPayload(
            string eventId,
            global::G.ErrorPayloadType type,
            global::G.ErrorDetails? error)
        {
            this.EventId = eventId ?? throw new global::System.ArgumentNullException(nameof(eventId));
            this.Type = type;
            this.Error = error;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorPayload" /> class.
        /// </summary>
        public ErrorPayload()
        {
        }
    }
}