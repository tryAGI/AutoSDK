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
        [global::System.Text.Json.Serialization.JsonPropertyName("phone_number")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PhoneNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.TelephonyProviderJsonConverter))]
        public global::G.TelephonyProvider? Provider { get; set; }

        /// <summary>
        /// Label for the phone number
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Label { get; set; }

        /// <summary>
        /// SIP trunk termination URI
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("termination_uri")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TerminationUri { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("credentials")]
        public global::G.SIPTrunkCredentials? Credentials { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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