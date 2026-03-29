//HintName: G.Models.TwilioTransportMessage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TwilioTransportMessage
    {
        /// <summary>
        /// This is the transport type.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("transport")]
        public global::G.TwilioTransportMessageTransport Transport { get; set; }

        /// <summary>
        /// This is the TwiML to send to the Twilio call.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("twiml", Required = global::Newtonsoft.Json.Required.Always)]
        public string Twiml { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TwilioTransportMessage" /> class.
        /// </summary>
        /// <param name="twiml">
        /// This is the TwiML to send to the Twilio call.
        /// </param>
        /// <param name="transport">
        /// This is the transport type.
        /// </param>
        public TwilioTransportMessage(
            string twiml,
            global::G.TwilioTransportMessageTransport transport)
        {
            this.Transport = transport;
            this.Twiml = twiml ?? throw new global::System.ArgumentNullException(nameof(twiml));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TwilioTransportMessage" /> class.
        /// </summary>
        public TwilioTransportMessage()
        {
        }
    }
}