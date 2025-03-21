//HintName: G.Models.ResponseAudioDeltaEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Emitted when there is a partial audio response.
    /// </summary>
    public sealed partial class ResponseAudioDeltaEvent
    {
        /// <summary>
        /// A chunk of Base64 encoded response audio bytes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("delta")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Delta { get; set; }

        /// <summary>
        /// The type of the event. Always `response.audio.delta`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ResponseAudioDeltaEventTypeJsonConverter))]
        public global::G.ResponseAudioDeltaEventType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseAudioDeltaEvent" /> class.
        /// </summary>
        /// <param name="delta">
        /// A chunk of Base64 encoded response audio bytes.
        /// </param>
        /// <param name="type">
        /// The type of the event. Always `response.audio.delta`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseAudioDeltaEvent(
            string delta,
            global::G.ResponseAudioDeltaEventType type)
        {
            this.Delta = delta ?? throw new global::System.ArgumentNullException(nameof(delta));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseAudioDeltaEvent" /> class.
        /// </summary>
        public ResponseAudioDeltaEvent()
        {
        }
    }
}