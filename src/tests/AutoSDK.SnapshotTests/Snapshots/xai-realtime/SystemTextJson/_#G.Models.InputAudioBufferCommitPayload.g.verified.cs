//HintName: G.Models.InputAudioBufferCommitPayload.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Commit the current input audio buffer.
    /// </summary>
    public sealed partial class InputAudioBufferCommitPayload
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.InputAudioBufferCommitPayloadTypeJsonConverter))]
        public global::G.InputAudioBufferCommitPayloadType Type { get; set; }

        /// <summary>
        /// Optional event ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_id")]
        public string? EventId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InputAudioBufferCommitPayload" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="eventId">
        /// Optional event ID.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InputAudioBufferCommitPayload(
            global::G.InputAudioBufferCommitPayloadType type,
            string? eventId)
        {
            this.Type = type;
            this.EventId = eventId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InputAudioBufferCommitPayload" /> class.
        /// </summary>
        public InputAudioBufferCommitPayload()
        {
        }
    }
}