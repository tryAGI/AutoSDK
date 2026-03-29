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
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.ClientInboundMessageSendTransportMessageType Type { get; set; }

        /// <summary>
        /// This is the transport-specific message to send.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.OneOf<global::G.VapiSipTransportMessage, global::G.TwilioTransportMessage> Message { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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