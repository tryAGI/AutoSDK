//HintName: G.Models.ResponseCancelPayload.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Send this event to cancel an in-progress response.
    /// </summary>
    public sealed partial class ResponseCancelPayload
    {
        /// <summary>
        /// Optional client-generated ID.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("event_id")]
        public string? EventId { get; set; }

        /// <summary>
        /// The event type.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ResponseCancelPayloadTypeJsonConverter))]
        public global::G.ResponseCancelPayloadType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseCancelPayload" /> class.
        /// </summary>
        /// <param name="eventId">
        /// Optional client-generated ID.
        /// </param>
        /// <param name="type">
        /// The event type.
        /// </param>
        public ResponseCancelPayload(
            string? eventId,
            global::G.ResponseCancelPayloadType type)
        {
            this.EventId = eventId;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseCancelPayload" /> class.
        /// </summary>
        public ResponseCancelPayload()
        {
        }
    }
}