//HintName: G.Models.ResponseOutputItemAddedPayload.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Returned when a new Item is created during response generation.
    /// </summary>
    public sealed partial class ResponseOutputItemAddedPayload
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
        public global::G.ResponseOutputItemAddedPayloadType Type { get; set; }

        /// <summary>
        /// The ID of the response.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("response_id")]
        public string? ResponseId { get; set; }

        /// <summary>
        /// The index of the output item in the response.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("output_index")]
        public int? OutputIndex { get; set; }

        /// <summary>
        /// A realtime conversation item.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("item")]
        public global::G.ConversationItem? Item { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseOutputItemAddedPayload" /> class.
        /// </summary>
        /// <param name="eventId">
        /// The unique ID of the server event.
        /// </param>
        /// <param name="type">
        /// The event type.
        /// </param>
        /// <param name="responseId">
        /// The ID of the response.
        /// </param>
        /// <param name="outputIndex">
        /// The index of the output item in the response.
        /// </param>
        /// <param name="item">
        /// A realtime conversation item.
        /// </param>
        public ResponseOutputItemAddedPayload(
            string eventId,
            global::G.ResponseOutputItemAddedPayloadType type,
            string? responseId,
            int? outputIndex,
            global::G.ConversationItem? item)
        {
            this.EventId = eventId ?? throw new global::System.ArgumentNullException(nameof(eventId));
            this.Type = type;
            this.ResponseId = responseId;
            this.OutputIndex = outputIndex;
            this.Item = item;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseOutputItemAddedPayload" /> class.
        /// </summary>
        public ResponseOutputItemAddedPayload()
        {
        }
    }
}