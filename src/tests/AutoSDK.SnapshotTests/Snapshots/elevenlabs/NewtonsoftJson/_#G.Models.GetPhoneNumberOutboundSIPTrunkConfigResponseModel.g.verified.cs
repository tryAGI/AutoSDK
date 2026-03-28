//HintName: G.Models.GetPhoneNumberOutboundSIPTrunkConfigResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// SIP Trunk configuration details for a phone number
    /// </summary>
    public sealed partial class GetPhoneNumberOutboundSIPTrunkConfigResponseModel
    {
        /// <summary>
        /// Hostname or IP the SIP INVITE is sent to
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("address", Required = global::Newtonsoft.Json.Required.Always)]
        public string Address { get; set; } = default!;

        /// <summary>
        /// Protocol to use for SIP transport
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("transport", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.SIPTrunkTransportEnum Transport { get; set; } = default!;

        /// <summary>
        /// Whether or not to encrypt media (data layer).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("media_encryption", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.SIPMediaEncryptionEnum MediaEncryption { get; set; } = default!;

        /// <summary>
        /// SIP headers for INVITE request
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("headers")]
        public global::System.Collections.Generic.Dictionary<string, string>? Headers { get; set; }

        /// <summary>
        /// Whether authentication credentials are configured
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("has_auth_credentials", Required = global::Newtonsoft.Json.Required.Always)]
        public bool HasAuthCredentials { get; set; } = default!;

        /// <summary>
        /// SIP trunk username (if available)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("username")]
        public string? Username { get; set; }

        /// <summary>
        /// Whether a LiveKit SIP outbound trunk is configured<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("has_outbound_trunk")]
        public bool? HasOutboundTrunk { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetPhoneNumberOutboundSIPTrunkConfigResponseModel" /> class.
        /// </summary>
        /// <param name="address">
        /// Hostname or IP the SIP INVITE is sent to
        /// </param>
        /// <param name="transport">
        /// Protocol to use for SIP transport
        /// </param>
        /// <param name="mediaEncryption">
        /// Whether or not to encrypt media (data layer).
        /// </param>
        /// <param name="hasAuthCredentials">
        /// Whether authentication credentials are configured
        /// </param>
        /// <param name="headers">
        /// SIP headers for INVITE request
        /// </param>
        /// <param name="username">
        /// SIP trunk username (if available)
        /// </param>
        /// <param name="hasOutboundTrunk">
        /// Whether a LiveKit SIP outbound trunk is configured<br/>
        /// Default Value: false
        /// </param>
        public GetPhoneNumberOutboundSIPTrunkConfigResponseModel(
            string address,
            global::G.SIPTrunkTransportEnum transport,
            global::G.SIPMediaEncryptionEnum mediaEncryption,
            bool hasAuthCredentials,
            global::System.Collections.Generic.Dictionary<string, string>? headers,
            string? username,
            bool? hasOutboundTrunk)
        {
            this.Address = address ?? throw new global::System.ArgumentNullException(nameof(address));
            this.Transport = transport;
            this.MediaEncryption = mediaEncryption;
            this.Headers = headers;
            this.HasAuthCredentials = hasAuthCredentials;
            this.Username = username;
            this.HasOutboundTrunk = hasOutboundTrunk;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetPhoneNumberOutboundSIPTrunkConfigResponseModel" /> class.
        /// </summary>
        public GetPhoneNumberOutboundSIPTrunkConfigResponseModel()
        {
        }
    }
}