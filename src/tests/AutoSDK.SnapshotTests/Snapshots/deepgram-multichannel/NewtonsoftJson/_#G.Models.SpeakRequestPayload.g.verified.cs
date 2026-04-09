//HintName: G.Models.SpeakRequestPayload.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Text-to-speech request.
    /// </summary>
    public sealed partial class SpeakRequestPayload
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message_type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.SpeakRequestPayloadMessageTypeJsonConverter))]
        public global::G.SpeakRequestPayloadMessageType MessageType { get; set; }

        /// <summary>
        /// Text to synthesize.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text", Required = global::Newtonsoft.Json.Required.Always)]
        public string Text { get; set; } = default!;

        /// <summary>
        /// Voice identifier.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("voice")]
        public string? Voice { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeakRequestPayload" /> class.
        /// </summary>
        /// <param name="text">
        /// Text to synthesize.
        /// </param>
        /// <param name="messageType"></param>
        /// <param name="voice">
        /// Voice identifier.
        /// </param>
        public SpeakRequestPayload(
            string text,
            global::G.SpeakRequestPayloadMessageType messageType,
            string? voice)
        {
            this.MessageType = messageType;
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Voice = voice;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeakRequestPayload" /> class.
        /// </summary>
        public SpeakRequestPayload()
        {
        }
    }
}