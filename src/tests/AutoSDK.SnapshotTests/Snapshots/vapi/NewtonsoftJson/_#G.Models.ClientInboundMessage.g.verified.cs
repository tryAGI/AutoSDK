//HintName: G.Models.ClientInboundMessage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ClientInboundMessage
    {
        /// <summary>
        /// These are the messages that can be sent from client-side SDKs to control the call.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.OneOf<global::G.ClientInboundMessageAddMessage, global::G.ClientInboundMessageControl, global::G.ClientInboundMessageSay, global::G.ClientInboundMessageEndCall, global::G.ClientInboundMessageTransfer, global::G.ClientInboundMessageSendTransportMessage> Message { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientInboundMessage" /> class.
        /// </summary>
        /// <param name="message">
        /// These are the messages that can be sent from client-side SDKs to control the call.
        /// </param>
        public ClientInboundMessage(
            global::G.OneOf<global::G.ClientInboundMessageAddMessage, global::G.ClientInboundMessageControl, global::G.ClientInboundMessageSay, global::G.ClientInboundMessageEndCall, global::G.ClientInboundMessageTransfer, global::G.ClientInboundMessageSendTransportMessage> message)
        {
            this.Message = message;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientInboundMessage" /> class.
        /// </summary>
        public ClientInboundMessage()
        {
        }
    }
}