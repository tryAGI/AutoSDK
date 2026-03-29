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
        [global::System.Text.Json.Serialization.JsonPropertyName("transport")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.TwilioTransportMessageTransportJsonConverter))]
        public global::G.TwilioTransportMessageTransport Transport { get; set; }

        /// <summary>
        /// This is the TwiML to send to the Twilio call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("twiml")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Twiml { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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