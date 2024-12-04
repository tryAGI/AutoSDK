//HintName: G.Models.RealtimeServerEventResponseAudioDone.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Returned when the model-generated audio is done. Also emitted when a Response<br/>
    /// is interrupted, incomplete, or cancelled.
    /// </summary>
    public sealed partial class RealtimeServerEventResponseAudioDone
    {
        /// <summary>
        /// The unique ID of the server event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EventId { get; set; }

        /// <summary>
        /// The event type, must be `response.audio.done`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.RealtimeServerEventResponseAudioDoneTypeJsonConverter))]
        public global::G.RealtimeServerEventResponseAudioDoneType Type { get; set; }

        /// <summary>
        /// The ID of the response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ResponseId { get; set; }

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
        /// The index of the content part in the item's content array.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ContentIndex { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeServerEventResponseAudioDone" /> class.
        /// </summary>
        /// <param name="eventId">
        /// The unique ID of the server event.
        /// </param>
        /// <param name="type">
        /// The event type, must be `response.audio.done`.
        /// </param>
        /// <param name="responseId">
        /// The ID of the response.
        /// </param>
        /// <param name="itemId">
        /// The ID of the item.
        /// </param>
        /// <param name="outputIndex">
        /// The index of the output item in the response.
        /// </param>
        /// <param name="contentIndex">
        /// The index of the content part in the item's content array.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public RealtimeServerEventResponseAudioDone(
            string eventId,
            string responseId,
            string itemId,
            int outputIndex,
            int contentIndex,
            global::G.RealtimeServerEventResponseAudioDoneType type)
        {
            this.EventId = eventId ?? throw new global::System.ArgumentNullException(nameof(eventId));
            this.ResponseId = responseId ?? throw new global::System.ArgumentNullException(nameof(responseId));
            this.ItemId = itemId ?? throw new global::System.ArgumentNullException(nameof(itemId));
            this.OutputIndex = outputIndex;
            this.ContentIndex = contentIndex;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeServerEventResponseAudioDone" /> class.
        /// </summary>
        public RealtimeServerEventResponseAudioDone()
        {
        }
    }
}