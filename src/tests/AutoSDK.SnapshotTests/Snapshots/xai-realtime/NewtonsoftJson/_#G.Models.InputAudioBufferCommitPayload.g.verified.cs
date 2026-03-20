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
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.InputAudioBufferCommitPayloadType Type { get; set; }

        /// <summary>
        /// Optional event ID.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("event_id")]
        public string? EventId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InputAudioBufferCommitPayload" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="eventId">
        /// Optional event ID.
        /// </param>
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