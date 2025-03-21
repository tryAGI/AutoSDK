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
        [global::System.Text.Json.Serialization.JsonPropertyName("content_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ContentIndex { get; set; }

        /// <summary>
        /// The unique ID of the server event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EventId { get; set; }

        /// <summary>
        /// The ID of the item.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("item_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ItemId { get; set; }

        /// <summary>
        /// The index of the output item in the response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int OutputIndex { get; set; }

        /// <summary>
        /// The content part that is done.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("part")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.RealtimeServerEventResponseContentPartDonePart Part { get; set; }

        /// <summary>
        /// The ID of the response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ResponseId { get; set; }

        /// <summary>
        /// The event type, must be `response.content_part.done`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.RealtimeServerEventResponseContentPartDoneTypeJsonConverter))]
        public global::G.RealtimeServerEventResponseContentPartDoneType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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