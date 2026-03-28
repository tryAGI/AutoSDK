//HintName: G.Models.PartialTranscriptPayload.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Event sent when a partial transcript is available.
    /// </summary>
    public sealed partial class PartialTranscriptPayload
    {
        /// <summary>
        /// Must be 'partial_transcript'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.PartialTranscriptPayloadMessageTypeJsonConverter))]
        public global::G.PartialTranscriptPayloadMessageType MessageType { get; set; }

        /// <summary>
        /// The partial transcript text.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PartialTranscriptPayload" /> class.
        /// </summary>
        /// <param name="text">
        /// The partial transcript text.
        /// </param>
        /// <param name="messageType">
        /// Must be 'partial_transcript'.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PartialTranscriptPayload(
            string text,
            global::G.PartialTranscriptPayloadMessageType messageType)
        {
            this.MessageType = messageType;
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PartialTranscriptPayload" /> class.
        /// </summary>
        public PartialTranscriptPayload()
        {
        }
    }
}