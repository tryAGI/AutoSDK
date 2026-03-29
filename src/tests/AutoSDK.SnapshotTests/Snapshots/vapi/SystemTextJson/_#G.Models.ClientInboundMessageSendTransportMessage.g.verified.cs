//HintName: G.Models.ClientInboundMessageSendTransportMessage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ClientInboundMessageSendTransportMessage
    {
        /// <summary>
        /// This is the type of the message. Send "send-transport-message" to send a transport-specific message during the call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ClientInboundMessageSendTransportMessageTypeJsonConverter))]
        public global::G.ClientInboundMessageSendTransportMessageType Type { get; set; }

        /// <summary>
        /// This is the transport-specific message to send.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverter<global::G.VapiSipTransportMessage, global::G.TwilioTransportMessage>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.OneOf<global::G.VapiSipTransportMessage, global::G.TwilioTransportMessage> Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientInboundMessageSendTransportMessage" /> class.
        /// </summary>
        /// <param name="message">
        /// This is the transport-specific message to send.
        /// </param>
        /// <param name="type">
        /// This is the type of the message. Send "send-transport-message" to send a transport-specific message during the call.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ClientInboundMessageSendTransportMessage(
            global::G.OneOf<global::G.VapiSipTransportMessage, global::G.TwilioTransportMessage> message,
            global::G.ClientInboundMessageSendTransportMessageType type)
        {
            this.Type = type;
            this.Message = message;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientInboundMessageSendTransportMessage" /> class.
        /// </summary>
        public ClientInboundMessageSendTransportMessage()
        {
        }
    }
}