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
        /// Optional client-generated ID used to identify this event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_id")]
        public string? EventId { get; set; }

        /// <summary>
        /// The event type, must be `conversation.item.truncate`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.RealtimeClientEventConversationItemTruncateTypeJsonConverter))]
        public global::G.RealtimeClientEventConversationItemTruncateType Type { get; set; }

        /// <summary>
        /// The ID of the assistant message item to truncate. Only assistant message <br/>
        /// items can be truncated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("item_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ItemId { get; set; }

        /// <summary>
        /// The index of the content part to truncate. Set this to 0.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ContentIndex { get; set; }

        /// <summary>
        /// Inclusive duration up to which audio is truncated, in milliseconds. If <br/>
        /// the audio_end_ms is greater than the actual audio duration, the server <br/>
        /// will respond with an error.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_end_ms")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int AudioEndMs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeClientEventConversationItemTruncate" /> class.
        /// </summary>
        /// <param name="eventId">
        /// Optional client-generated ID used to identify this event.
        /// </param>
        /// <param name="type">
        /// The event type, must be `conversation.item.truncate`.
        /// </param>
        /// <param name="itemId">
        /// The ID of the assistant message item to truncate. Only assistant message <br/>
        /// items can be truncated.
        /// </param>
        /// <param name="contentIndex">
        /// The index of the content part to truncate. Set this to 0.
        /// </param>
        /// <param name="audioEndMs">
        /// Inclusive duration up to which audio is truncated, in milliseconds. If <br/>
        /// the audio_end_ms is greater than the actual audio duration, the server <br/>
        /// will respond with an error.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeClientEventConversationItemTruncate(
            string itemId,
            int contentIndex,
            int audioEndMs,
            string? eventId,
            global::G.RealtimeClientEventConversationItemTruncateType type)
        {
            this.ItemId = itemId ?? throw new global::System.ArgumentNullException(nameof(itemId));
            this.ContentIndex = contentIndex;
            this.AudioEndMs = audioEndMs;
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