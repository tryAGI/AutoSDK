//HintName: G.Models.OutboundSIPTrunkConfigRequestModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OutboundSIPTrunkConfigRequestModel
    {
        /// <summary>
        /// Hostname or IP the SIP INVITE is sent to.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("address", Required = global::Newtonsoft.Json.Required.Always)]
        public string Address { get; set; } = default!;

        /// <summary>
        /// Protocol to use for SIP transport (signalling layer).<br/>
        /// Default Value: auto
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("transport")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.SIPTrunkTransportEnumJsonConverter))]
        public global::G.SIPTrunkTransportEnum? Transport { get; set; }

        /// <summary>
        /// Whether or not to encrypt media (data layer).<br/>
        /// Default Value: allowed
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("media_encryption")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.SIPMediaEncryptionEnumJsonConverter))]
        public global::G.SIPMediaEncryptionEnum? MediaEncryption { get; set; }

        /// <summary>
        /// SIP X-* headers for INVITE request. These headers are sent as-is and may help identify this call.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("headers")]
        public global::System.Collections.Generic.Dictionary<string, string>? Headers { get; set; }

        /// <summary>
        /// Optional digest authentication credentials (username/password). If not provided, ACL authentication is assumed.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("credentials")]
        public global::G.SIPTrunkCredentialsRequestModel? Credentials { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OutboundSIPTrunkConfigRequestModel" /> class.
        /// </summary>
        /// <param name="address">
        /// Hostname or IP the SIP INVITE is sent to.
        /// </param>
        /// <param name="transport">
        /// Protocol to use for SIP transport (signalling layer).<br/>
        /// Default Value: auto
        /// </param>
        /// <param name="mediaEncryption">
        /// Whether or not to encrypt media (data layer).<br/>
        /// Default Value: allowed
        /// </param>
        /// <param name="headers">
        /// SIP X-* headers for INVITE request. These headers are sent as-is and may help identify this call.
        /// </param>
        /// <param name="credentials">
        /// Optional digest authentication credentials (username/password). If not provided, ACL authentication is assumed.
        /// </param>
        public OutboundSIPTrunkConfigRequestModel(
            string address,
            global::G.SIPTrunkTransportEnum? transport,
            global::G.SIPMediaEncryptionEnum? mediaEncryption,
            global::System.Collections.Generic.Dictionary<string, string>? headers,
            global::G.SIPTrunkCredentialsRequestModel? credentials)
        {
            this.Address = address ?? throw new global::System.ArgumentNullException(nameof(address));
            this.Transport = transport;
            this.MediaEncryption = mediaEncryption;
            this.Headers = headers;
            this.Credentials = credentials;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OutboundSIPTrunkConfigRequestModel" /> class.
        /// </summary>
        public OutboundSIPTrunkConfigRequestModel()
        {
        }
    }
}