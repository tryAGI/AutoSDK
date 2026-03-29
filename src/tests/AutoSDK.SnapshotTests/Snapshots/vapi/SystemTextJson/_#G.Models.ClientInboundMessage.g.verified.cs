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
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverter<global::G.ClientInboundMessageAddMessage, global::G.ClientInboundMessageControl, global::G.ClientInboundMessageSay, global::G.ClientInboundMessageEndCall, global::G.ClientInboundMessageTransfer, global::G.ClientInboundMessageSendTransportMessage>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.OneOf<global::G.ClientInboundMessageAddMessage, global::G.ClientInboundMessageControl, global::G.ClientInboundMessageSay, global::G.ClientInboundMessageEndCall, global::G.ClientInboundMessageTransfer, global::G.ClientInboundMessageSendTransportMessage> Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientInboundMessage" /> class.
        /// </summary>
        /// <param name="message">
        /// These are the messages that can be sent from client-side SDKs to control the call.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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