//HintName: G.Models.ClientInboundMessageTransfer.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ClientInboundMessageTransfer
    {
        /// <summary>
        /// This is the type of the message. Send "transfer" message to transfer the call to a destination.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ClientInboundMessageTransferTypeJsonConverter))]
        public global::G.ClientInboundMessageTransferType Type { get; set; }

        /// <summary>
        /// This is the destination to transfer the call to.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("destination")]
        public global::G.OneOf<global::G.TransferDestinationNumber, global::G.TransferDestinationSip>? Destination { get; set; }

        /// <summary>
        /// This is the content to say.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content")]
        public string? Content { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientInboundMessageTransfer" /> class.
        /// </summary>
        /// <param name="type">
        /// This is the type of the message. Send "transfer" message to transfer the call to a destination.
        /// </param>
        /// <param name="destination">
        /// This is the destination to transfer the call to.
        /// </param>
        /// <param name="content">
        /// This is the content to say.
        /// </param>
        public ClientInboundMessageTransfer(
            global::G.ClientInboundMessageTransferType type,
            global::G.OneOf<global::G.TransferDestinationNumber, global::G.TransferDestinationSip>? destination,
            string? content)
        {
            this.Type = type;
            this.Destination = destination;
            this.Content = content;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientInboundMessageTransfer" /> class.
        /// </summary>
        public ClientInboundMessageTransfer()
        {
        }
    }
}