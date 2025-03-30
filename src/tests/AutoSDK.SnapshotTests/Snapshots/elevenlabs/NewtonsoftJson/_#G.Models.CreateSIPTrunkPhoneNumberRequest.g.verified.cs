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
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("provider")]
        public global::G.TelephonyProvider? Provider { get; set; }

        /// <summary>
        /// Label for the phone number
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("label", Required = global::Newtonsoft.Json.Required.Always)]
        public string Label { get; set; } = default!;

        /// <summary>
        /// SIP trunk termination URI
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("termination_uri", Required = global::Newtonsoft.Json.Required.Always)]
        public string TerminationUri { get; set; } = default!;

        /// <summary>
        /// 
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
        /// <param name="provider"></param>
        /// <param name="label">
        /// Label for the phone number
        /// </param>
        /// <param name="terminationUri">
        /// SIP trunk termination URI
        /// </param>
        /// <param name="credentials"></param>
        public CreateSIPTrunkPhoneNumberRequest(
            string phoneNumber,
            string label,
            string terminationUri,
            global::G.TelephonyProvider? provider,
            global::G.SIPTrunkCredentials? credentials)
        {
            this.PhoneNumber = phoneNumber ?? throw new global::System.ArgumentNullException(nameof(phoneNumber));
            this.Label = label ?? throw new global::System.ArgumentNullException(nameof(label));
            this.TerminationUri = terminationUri ?? throw new global::System.ArgumentNullException(nameof(terminationUri));
            this.Provider = provider;
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