//HintName: G.Models.RealtimeServerEventInputAudioBufferCommitted.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Returned when an input audio buffer is committed, either by the client or <br/>
    /// automatically in server VAD mode. The `item_id` property is the ID of the user<br/>
    /// message item that will be created, thus a `conversation.item.created` event <br/>
    /// will also be sent to the client.
    /// </summary>
    public sealed partial class RealtimeServerEventInputAudioBufferCommitted
    {
        /// <summary>
        /// The unique ID of the server event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EventId { get; set; }

        /// <summary>
        /// The event type, must be `input_audio_buffer.committed`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.RealtimeServerEventInputAudioBufferCommittedTypeJsonConverter))]
        public global::G.RealtimeServerEventInputAudioBufferCommittedType Type { get; set; }

        /// <summary>
        /// The ID of the preceding item after which the new item will be inserted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("previous_item_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PreviousItemId { get; set; }

        /// <summary>
        /// The ID of the user message item that will be created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("item_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ItemId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeServerEventInputAudioBufferCommitted" /> class.
        /// </summary>
        /// <param name="eventId">
        /// The unique ID of the server event.
        /// </param>
        /// <param name="type">
        /// The event type, must be `input_audio_buffer.committed`.
        /// </param>
        /// <param name="previousItemId">
        /// The ID of the preceding item after which the new item will be inserted.
        /// </param>
        /// <param name="itemId">
        /// The ID of the user message item that will be created.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public RealtimeServerEventInputAudioBufferCommitted(
            string eventId,
            string previousItemId,
            string itemId,
            global::G.RealtimeServerEventInputAudioBufferCommittedType type)
        {
            this.EventId = eventId ?? throw new global::System.ArgumentNullException(nameof(eventId));
            this.PreviousItemId = previousItemId ?? throw new global::System.ArgumentNullException(nameof(previousItemId));
            this.ItemId = itemId ?? throw new global::System.ArgumentNullException(nameof(itemId));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeServerEventInputAudioBufferCommitted" /> class.
        /// </summary>
        public RealtimeServerEventInputAudioBufferCommitted()
        {
        }
    }
}