//HintName: G.Models.ResponseCreatePayload.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Send this event to trigger a response generation.
    /// </summary>
    public sealed partial class ResponseCreatePayload
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
        public global::G.ResponseCreatePayloadType Type { get; set; }

        /// <summary>
        /// Configuration for a response.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("response")]
        public global::G.ResponseConfig? Response { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseCreatePayload" /> class.
        /// </summary>
        /// <param name="eventId">
        /// Optional client-generated ID.
        /// </param>
        /// <param name="type">
        /// The event type.
        /// </param>
        /// <param name="response">
        /// Configuration for a response.
        /// </param>
        public ResponseCreatePayload(
            string? eventId,
            global::G.ResponseCreatePayloadType type,
            global::G.ResponseConfig? response)
        {
            this.EventId = eventId;
            this.Type = type;
            this.Response = response;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseCreatePayload" /> class.
        /// </summary>
        public ResponseCreatePayload()
        {
        }
    }
}