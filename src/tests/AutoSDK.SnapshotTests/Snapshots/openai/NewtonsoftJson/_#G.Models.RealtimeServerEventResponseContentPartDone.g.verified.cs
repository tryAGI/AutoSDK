//HintName: G.Models.RealtimeServerEventResponseContentPartDone.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Returned when a content part is done streaming in an assistant message item.<br/>
    /// Also emitted when a Response is interrupted, incomplete, or cancelled.
    /// </summary>
    public sealed partial class RealtimeServerEventResponseContentPartDone
    {
        /// <summary>
        /// The index of the content part in the item's content array.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content_index", Required = global::Newtonsoft.Json.Required.Always)]
        public int ContentIndex { get; set; } = default!;

        /// <summary>
        /// The unique ID of the server event.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("event_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string EventId { get; set; } = default!;

        /// <summary>
        /// The ID of the item.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("item_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ItemId { get; set; } = default!;

        /// <summary>
        /// The index of the output item in the response.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("output_index", Required = global::Newtonsoft.Json.Required.Always)]
        public int OutputIndex { get; set; } = default!;

        /// <summary>
        /// The content part that is done.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("part", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.RealtimeServerEventResponseContentPartDonePart Part { get; set; } = default!;

        /// <summary>
        /// The ID of the response.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("response_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ResponseId { get; set; } = default!;

        /// <summary>
        /// The event type, must be `response.content_part.done`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.RealtimeServerEventResponseContentPartDoneType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeServerEventResponseContentPartDone" /> class.
        /// </summary>
        /// <param name="contentIndex">
        /// The index of the content part in the item's content array.
        /// </param>
        /// <param name="eventId">
        /// The unique ID of the server event.
        /// </param>
        /// <param name="itemId">
        /// The ID of the item.
        /// </param>
        /// <param name="outputIndex">
        /// The index of the output item in the response.
        /// </param>
        /// <param name="part">
        /// The content part that is done.
        /// </param>
        /// <param name="responseId">
        /// The ID of the response.
        /// </param>
        /// <param name="type">
        /// The event type, must be `response.content_part.done`.
        /// </param>
        public RealtimeServerEventResponseContentPartDone(
            int contentIndex,
            string eventId,
            string itemId,
            int outputIndex,
            global::G.RealtimeServerEventResponseContentPartDonePart part,
            string responseId,
            global::G.RealtimeServerEventResponseContentPartDoneType type)
        {
            this.ContentIndex = contentIndex;
            this.EventId = eventId ?? throw new global::System.ArgumentNullException(nameof(eventId));
            this.ItemId = itemId ?? throw new global::System.ArgumentNullException(nameof(itemId));
            this.OutputIndex = outputIndex;
            this.Part = part ?? throw new global::System.ArgumentNullException(nameof(part));
            this.ResponseId = responseId ?? throw new global::System.ArgumentNullException(nameof(responseId));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeServerEventResponseContentPartDone" /> class.
        /// </summary>
        public RealtimeServerEventResponseContentPartDone()
        {
        }
    }
}