//HintName: G.Models.ResponseDonePayload.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Returned when a Response is done streaming.
    /// </summary>
    public sealed partial class ResponseDonePayload
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
        public global::G.ResponseDonePayloadType Type { get; set; }

        /// <summary>
        /// The response resource.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("response")]
        public global::G.Response? Response { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseDonePayload" /> class.
        /// </summary>
        /// <param name="eventId">
        /// The unique ID of the server event.
        /// </param>
        /// <param name="type">
        /// The event type.
        /// </param>
        /// <param name="response">
        /// The response resource.
        /// </param>
        public ResponseDonePayload(
            string eventId,
            global::G.ResponseDonePayloadType type,
            global::G.Response? response)
        {
            this.EventId = eventId ?? throw new global::System.ArgumentNullException(nameof(eventId));
            this.Type = type;
            this.Response = response;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseDonePayload" /> class.
        /// </summary>
        public ResponseDonePayload()
        {
        }
    }
}