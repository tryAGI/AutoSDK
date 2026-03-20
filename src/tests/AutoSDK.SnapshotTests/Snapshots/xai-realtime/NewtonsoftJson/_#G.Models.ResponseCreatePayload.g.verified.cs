//HintName: G.Models.ResponseCreatePayload.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Request a response from the model.
    /// </summary>
    public sealed partial class ResponseCreatePayload
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.ResponseCreatePayloadType Type { get; set; }

        /// <summary>
        /// Optional event ID.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("event_id")]
        public string? EventId { get; set; }

        /// <summary>
        /// Response configuration for response.create events.
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
        /// <param name="type"></param>
        /// <param name="eventId">
        /// Optional event ID.
        /// </param>
        /// <param name="response">
        /// Response configuration for response.create events.
        /// </param>
        public ResponseCreatePayload(
            global::G.ResponseCreatePayloadType type,
            string? eventId,
            global::G.ResponseConfig? response)
        {
            this.Type = type;
            this.EventId = eventId;
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