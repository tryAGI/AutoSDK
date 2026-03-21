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
        /// <default>"speak_request"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("message_type")]
        public string MessageType { get; set; } = "speak_request";

        /// <summary>
        /// Text to synthesize.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// Voice identifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice")]
        public string? Voice { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeakRequestPayload" /> class.
        /// </summary>
        /// <param name="messageType"></param>
        /// <param name="text">
        /// Text to synthesize.
        /// </param>
        /// <param name="voice">
        /// Voice identifier.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SpeakRequestPayload(
            string text,
            string? voice,
            string messageType = "speak_request")
        {
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.MessageType = messageType;
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