//HintName: G.Models.CommittedTranscriptPayload.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Event sent when a transcript is committed.
    /// </summary>
    public sealed partial class CommittedTranscriptPayload
    {
        /// <summary>
        /// Must be 'committed_transcript'.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message_type")]
        public global::G.CommittedTranscriptPayloadMessageType MessageType { get; set; }

        /// <summary>
        /// The committed transcript text.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text", Required = global::Newtonsoft.Json.Required.Always)]
        public string Text { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CommittedTranscriptPayload" /> class.
        /// </summary>
        /// <param name="messageType">
        /// Must be 'committed_transcript'.
        /// </param>
        /// <param name="text">
        /// The committed transcript text.
        /// </param>
        public CommittedTranscriptPayload(
            string text,
            global::G.CommittedTranscriptPayloadMessageType messageType)
        {
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.MessageType = messageType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CommittedTranscriptPayload" /> class.
        /// </summary>
        public CommittedTranscriptPayload()
        {
        }
    }
}