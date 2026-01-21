//HintName: G.Models.CreateSIPTrunkPhoneNumberRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// SIP trunk phone number request<br/>
    /// Includes termination URI and optional digest authentication credentials.<br/>
    /// If credentials are provided, both username and password must be included.<br/>
    /// If credentials are not provided, ACL authentication is assumed. (user needs to add our ips in their settings)
    /// </summary>
    public sealed partial class CreateSIPTrunkPhoneNumberRequest
    {
        /// <summary>
        /// Phone number
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("phone_number", Required = global::Newtonsoft.Json.Required.Always)]
        public string PhoneNumber { get; set; } = default!;

        /// <summary>
        /// Label for the phone number
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("label", Required = global::Newtonsoft.Json.Required.Always)]
        public string Label { get; set; } = default!;

        /// <summary>
        /// Default Value: sip_trunk
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("provider")]
        public string? Provider { get; set; }

        /// <summary>
        /// SIP trunk termination URI
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("termination_uri", Required = global::Newtonsoft.Json.Required.Always)]
        public string TerminationUri { get; set; } = default!;

        /// <summary>
        /// Hostname or IP the SIP INVITE is sent to.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("address")]
        public string? Address { get; set; }

        /// <summary>
        /// Protocol to use for SIP transport (signalling layer).<br/>
        /// Default Value: auto
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("transport")]
        public global::G.SIPTrunkTransportEnum? Transport { get; set; }

        /// <summary>
        /// Whether or not to encrypt media (data layer).<br/>
        /// Default Value: allowed
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("media_encryption")]
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
        public global::G.SIPTrunkCredentials? Credentials { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSIPTrunkPhoneNumberRequest" /> class.
        /// </summary>
        /// <param name="phoneNumber">
        /// Phone number
        /// </param>
        /// <param name="label">
        /// Label for the phone number
        /// </param>
        /// <param name="provider">
        /// Default Value: sip_trunk
        /// </param>
        /// <param name="terminationUri">
        /// SIP trunk termination URI
        /// </param>
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
        public CreateSIPTrunkPhoneNumberRequest(
            string phoneNumber,
            string label,
            string terminationUri,
            string? provider,
            string? address,
            global::G.SIPTrunkTransportEnum? transport,
            global::G.SIPMediaEncryptionEnum? mediaEncryption,
            global::System.Collections.Generic.Dictionary<string, string>? headers,
            global::G.SIPTrunkCredentials? credentials)
        {
            this.PhoneNumber = phoneNumber ?? throw new global::System.ArgumentNullException(nameof(phoneNumber));
            this.Label = label ?? throw new global::System.ArgumentNullException(nameof(label));
            this.TerminationUri = terminationUri ?? throw new global::System.ArgumentNullException(nameof(terminationUri));
            this.Provider = provider;
            this.Address = address;
            this.Transport = transport;
            this.MediaEncryption = mediaEncryption;
            this.Headers = headers;
            this.Credentials = credentials;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSIPTrunkPhoneNumberRequest" /> class.
        /// </summary>
        public CreateSIPTrunkPhoneNumberRequest()
        {
        }
    }
}