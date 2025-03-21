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
        [global::Newtonsoft.Json.JsonProperty("event_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string EventId { get; set; } = default!;

        /// <summary>
        /// The ID of the user message item that will be created.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("item_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ItemId { get; set; } = default!;

        /// <summary>
        /// The ID of the preceding item after which the new item will be inserted.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("previous_item_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string PreviousItemId { get; set; } = default!;

        /// <summary>
        /// The event type, must be `input_audio_buffer.committed`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.RealtimeServerEventInputAudioBufferCommittedType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeServerEventInputAudioBufferCommitted" /> class.
        /// </summary>
        /// <param name="eventId">
        /// The unique ID of the server event.
        /// </param>
        /// <param name="itemId">
        /// The ID of the user message item that will be created.
        /// </param>
        /// <param name="previousItemId">
        /// The ID of the preceding item after which the new item will be inserted.
        /// </param>
        /// <param name="type">
        /// The event type, must be `input_audio_buffer.committed`.
        /// </param>
        public RealtimeServerEventInputAudioBufferCommitted(
            string eventId,
            string itemId,
            string previousItemId,
            global::G.RealtimeServerEventInputAudioBufferCommittedType type)
        {
            this.EventId = eventId ?? throw new global::System.ArgumentNullException(nameof(eventId));
            this.ItemId = itemId ?? throw new global::System.ArgumentNullException(nameof(itemId));
            this.PreviousItemId = previousItemId ?? throw new global::System.ArgumentNullException(nameof(previousItemId));
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