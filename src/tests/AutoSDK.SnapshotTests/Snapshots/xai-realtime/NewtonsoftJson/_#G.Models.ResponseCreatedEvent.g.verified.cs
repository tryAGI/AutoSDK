//HintName: G.Models.ResponseCreatedEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A response has been created.
    /// </summary>
    public sealed partial class ResponseCreatedEvent
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ResponseCreatedEventTypeJsonConverter))]
        public global::G.ResponseCreatedEventType? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("event_id")]
        public string? EventId { get; set; }

        /// <summary>
        /// Response information from the server.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("response")]
        public global::G.ResponseInfo? Response { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseCreatedEvent" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="eventId"></param>
        /// <param name="response">
        /// Response information from the server.
        /// </param>
        public ResponseCreatedEvent(
            global::G.ResponseCreatedEventType? type,
            string? eventId,
            global::G.ResponseInfo? response)
        {
            this.Type = type;
            this.EventId = eventId;
            this.Response = response;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseCreatedEvent" /> class.
        /// </summary>
        public ResponseCreatedEvent()
        {
        }
    }
}