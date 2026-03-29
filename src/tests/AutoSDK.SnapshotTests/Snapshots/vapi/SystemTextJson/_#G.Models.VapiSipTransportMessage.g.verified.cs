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
        [global::System.Text.Json.Serialization.JsonPropertyName("transport")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.VapiSipTransportMessageTransportJsonConverter))]
        public global::G.VapiSipTransportMessageTransport Transport { get; set; }

        /// <summary>
        /// This is the SIP verb to use. Must be one of INFO, MESSAGE, or NOTIFY.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sipVerb")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.VapiSipTransportMessageSipVerbJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.VapiSipTransportMessageSipVerb SipVerb { get; set; }

        /// <summary>
        /// These are the headers to include with the SIP request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("headers")]
        public object? Headers { get; set; }

        /// <summary>
        /// This is the body of the SIP request, if any.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("body")]
        public string? Body { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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