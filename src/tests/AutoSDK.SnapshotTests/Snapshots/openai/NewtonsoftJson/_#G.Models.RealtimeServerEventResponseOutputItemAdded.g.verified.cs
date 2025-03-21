//HintName: G.Models.RealtimeServerEventResponseOutputItemAdded.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Returned when a new Item is created during Response generation.
    /// </summary>
    public sealed partial class RealtimeServerEventResponseOutputItemAdded
    {
        /// <summary>
        /// The unique ID of the server event.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("event_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string EventId { get; set; } = default!;

        /// <summary>
        /// The item to add to the conversation.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("item", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.RealtimeConversationItem Item { get; set; } = default!;

        /// <summary>
        /// The index of the output item in the Response.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("output_index", Required = global::Newtonsoft.Json.Required.Always)]
        public int OutputIndex { get; set; } = default!;

        /// <summary>
        /// The ID of the Response to which the item belongs.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("response_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ResponseId { get; set; } = default!;

        /// <summary>
        /// The event type, must be `response.output_item.added`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.RealtimeServerEventResponseOutputItemAddedType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeServerEventResponseOutputItemAdded" /> class.
        /// </summary>
        /// <param name="eventId">
        /// The unique ID of the server event.
        /// </param>
        /// <param name="item">
        /// The item to add to the conversation.
        /// </param>
        /// <param name="outputIndex">
        /// The index of the output item in the Response.
        /// </param>
        /// <param name="responseId">
        /// The ID of the Response to which the item belongs.
        /// </param>
        /// <param name="type">
        /// The event type, must be `response.output_item.added`.
        /// </param>
        public RealtimeServerEventResponseOutputItemAdded(
            string eventId,
            global::G.RealtimeConversationItem item,
            int outputIndex,
            string responseId,
            global::G.RealtimeServerEventResponseOutputItemAddedType type)
        {
            this.EventId = eventId ?? throw new global::System.ArgumentNullException(nameof(eventId));
            this.Item = item ?? throw new global::System.ArgumentNullException(nameof(item));
            this.OutputIndex = outputIndex;
            this.ResponseId = responseId ?? throw new global::System.ArgumentNullException(nameof(responseId));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeServerEventResponseOutputItemAdded" /> class.
        /// </summary>
        public RealtimeServerEventResponseOutputItemAdded()
        {
        }
    }
}