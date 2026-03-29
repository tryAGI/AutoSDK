//HintName: G.Models.VapiSipTransportMessage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VapiSipTransportMessage
    {
        /// <summary>
        /// This is the transport type.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("transport")]
        public global::G.VapiSipTransportMessageTransport Transport { get; set; }

        /// <summary>
        /// This is the SIP verb to use. Must be one of INFO, MESSAGE, or NOTIFY.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sipVerb", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.VapiSipTransportMessageSipVerb SipVerb { get; set; } = default!;

        /// <summary>
        /// These are the headers to include with the SIP request.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("headers")]
        public object? Headers { get; set; }

        /// <summary>
        /// This is the body of the SIP request, if any.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("body")]
        public string? Body { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VapiSipTransportMessage" /> class.
        /// </summary>
        /// <param name="sipVerb">
        /// This is the SIP verb to use. Must be one of INFO, MESSAGE, or NOTIFY.
        /// </param>
        /// <param name="transport">
        /// This is the transport type.
        /// </param>
        /// <param name="headers">
        /// These are the headers to include with the SIP request.
        /// </param>
        /// <param name="body">
        /// This is the body of the SIP request, if any.
        /// </param>
        public VapiSipTransportMessage(
            global::G.VapiSipTransportMessageSipVerb sipVerb,
            global::G.VapiSipTransportMessageTransport transport,
            object? headers,
            string? body)
        {
            this.Transport = transport;
            this.SipVerb = sipVerb;
            this.Headers = headers;
            this.Body = body;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VapiSipTransportMessage" /> class.
        /// </summary>
        public VapiSipTransportMessage()
        {
        }
    }
}