//HintName: G.Models.GetPhoneNumberInboundSIPTrunkConfigResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetPhoneNumberInboundSIPTrunkConfigResponseModel
    {
        /// <summary>
        /// List of IP addresses that are allowed to use the trunk. Each item in the list can be an individual IP address or a Classless Inter-Domain Routing notation representing a CIDR block.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("allowed_addresses", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> AllowedAddresses { get; set; } = default!;

        /// <summary>
        /// List of phone numbers that are allowed to use the trunk.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("allowed_numbers")]
        public global::System.Collections.Generic.IList<string>? AllowedNumbers { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("media_encryption", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.SIPMediaEncryptionEnum MediaEncryption { get; set; } = default!;

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
        /// Domains of remote SIP servers used to validate TLS certificates.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("remote_domains")]
        public global::System.Collections.Generic.IList<string>? RemoteDomains { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetPhoneNumberInboundSIPTrunkConfigResponseModel" /> class.
        /// </summary>
        /// <param name="allowedAddresses">
        /// List of IP addresses that are allowed to use the trunk. Each item in the list can be an individual IP address or a Classless Inter-Domain Routing notation representing a CIDR block.
        /// </param>
        /// <param name="mediaEncryption"></param>
        /// <param name="hasAuthCredentials">
        /// Whether authentication credentials are configured
        /// </param>
        /// <param name="allowedNumbers">
        /// List of phone numbers that are allowed to use the trunk.
        /// </param>
        /// <param name="username">
        /// SIP trunk username (if available)
        /// </param>
        /// <param name="remoteDomains">
        /// Domains of remote SIP servers used to validate TLS certificates.
        /// </param>
        public GetPhoneNumberInboundSIPTrunkConfigResponseModel(
            global::System.Collections.Generic.IList<string> allowedAddresses,
            global::G.SIPMediaEncryptionEnum mediaEncryption,
            bool hasAuthCredentials,
            global::System.Collections.Generic.IList<string>? allowedNumbers,
            string? username,
            global::System.Collections.Generic.IList<string>? remoteDomains)
        {
            this.AllowedAddresses = allowedAddresses ?? throw new global::System.ArgumentNullException(nameof(allowedAddresses));
            this.AllowedNumbers = allowedNumbers;
            this.MediaEncryption = mediaEncryption;
            this.HasAuthCredentials = hasAuthCredentials;
            this.Username = username;
            this.RemoteDomains = remoteDomains;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetPhoneNumberInboundSIPTrunkConfigResponseModel" /> class.
        /// </summary>
        public GetPhoneNumberInboundSIPTrunkConfigResponseModel()
        {
        }
    }
}