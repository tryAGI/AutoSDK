//HintName: G.Models.RealtimeClientEventConversationItemTruncate.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Send this event to truncate a previous assistant message’s audio. The server <br/>
    /// will produce audio faster than realtime, so this event is useful when the user <br/>
    /// interrupts to truncate audio that has already been sent to the client but not <br/>
    /// yet played. This will synchronize the server's understanding of the audio with <br/>
    /// the client's playback.<br/>
    /// Truncating audio will delete the server-side text transcript to ensure there <br/>
    /// is not text in the context that hasn't been heard by the user.<br/>
    /// If successful, the server will respond with a `conversation.item.truncated` <br/>
    /// event. 
    /// </summary>
    public sealed partial class RealtimeClientEventConversationItemTruncate
    {
        /// <summary>
        /// Inclusive duration up to which audio is truncated, in milliseconds. If <br/>
        /// the audio_end_ms is greater than the actual audio duration, the server <br/>
        /// will respond with an error.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("audio_end_ms", Required = global::Newtonsoft.Json.Required.Always)]
        public int AudioEndMs { get; set; } = default!;

        /// <summary>
        /// The index of the content part to truncate. Set this to 0.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content_index", Required = global::Newtonsoft.Json.Required.Always)]
        public int ContentIndex { get; set; } = default!;

        /// <summary>
        /// Optional client-generated ID used to identify this event.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("event_id")]
        public string? EventId { get; set; }

        /// <summary>
        /// The ID of the assistant message item to truncate. Only assistant message <br/>
        /// items can be truncated.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("item_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ItemId { get; set; } = default!;

        /// <summary>
        /// The event type, must be `conversation.item.truncate`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.RealtimeClientEventConversationItemTruncateType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeClientEventConversationItemTruncate" /> class.
        /// </summary>
        /// <param name="audioEndMs">
        /// Inclusive duration up to which audio is truncated, in milliseconds. If <br/>
        /// the audio_end_ms is greater than the actual audio duration, the server <br/>
        /// will respond with an error.
        /// </param>
        /// <param name="contentIndex">
        /// The index of the content part to truncate. Set this to 0.
        /// </param>
        /// <param name="eventId">
        /// Optional client-generated ID used to identify this event.
        /// </param>
        /// <param name="itemId">
        /// The ID of the assistant message item to truncate. Only assistant message <br/>
        /// items can be truncated.
        /// </param>
        /// <param name="type">
        /// The event type, must be `conversation.item.truncate`.
        /// </param>
        public RealtimeClientEventConversationItemTruncate(
            int audioEndMs,
            int contentIndex,
            string itemId,
            string? eventId,
            global::G.RealtimeClientEventConversationItemTruncateType type)
        {
            this.AudioEndMs = audioEndMs;
            this.ContentIndex = contentIndex;
            this.ItemId = itemId ?? throw new global::System.ArgumentNullException(nameof(itemId));
            this.EventId = eventId;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeClientEventConversationItemTruncate" /> class.
        /// </summary>
        public RealtimeClientEventConversationItemTruncate()
        {
        }
    }
}