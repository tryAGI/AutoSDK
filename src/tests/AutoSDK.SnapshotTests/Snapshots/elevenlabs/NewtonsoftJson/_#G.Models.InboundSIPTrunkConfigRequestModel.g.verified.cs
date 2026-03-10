//HintName: G.Models.InboundSIPTrunkConfigRequestModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class InboundSIPTrunkConfigRequestModel
    {
        /// <summary>
        /// List of IP addresses that are allowed to use the trunk. Each item in the list can be an individual IP address or a Classless Inter-Domain Routing notation representing a CIDR block.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("allowed_addresses")]
        public global::System.Collections.Generic.IList<string>? AllowedAddresses { get; set; }

        /// <summary>
        /// List of phone numbers that are allowed to use the trunk.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("allowed_numbers")]
        public global::System.Collections.Generic.IList<string>? AllowedNumbers { get; set; }

        /// <summary>
        /// Whether or not to encrypt media (data layer).<br/>
        /// Default Value: allowed
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("media_encryption")]
        public global::G.SIPMediaEncryptionEnum? MediaEncryption { get; set; }

        /// <summary>
        /// Optional digest authentication credentials (username/password).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("credentials")]
        public global::G.SIPTrunkCredentialsRequestModel? Credentials { get; set; }

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
        /// Initializes a new instance of the <see cref="InboundSIPTrunkConfigRequestModel" /> class.
        /// </summary>
        /// <param name="allowedAddresses">
        /// List of IP addresses that are allowed to use the trunk. Each item in the list can be an individual IP address or a Classless Inter-Domain Routing notation representing a CIDR block.
        /// </param>
        /// <param name="allowedNumbers">
        /// List of phone numbers that are allowed to use the trunk.
        /// </param>
        /// <param name="mediaEncryption">
        /// Whether or not to encrypt media (data layer).<br/>
        /// Default Value: allowed
        /// </param>
        /// <param name="credentials">
        /// Optional digest authentication credentials (username/password).
        /// </param>
        /// <param name="remoteDomains">
        /// Domains of remote SIP servers used to validate TLS certificates.
        /// </param>
        public InboundSIPTrunkConfigRequestModel(
            global::System.Collections.Generic.IList<string>? allowedAddresses,
            global::System.Collections.Generic.IList<string>? allowedNumbers,
            global::G.SIPMediaEncryptionEnum? mediaEncryption,
            global::G.SIPTrunkCredentialsRequestModel? credentials,
            global::System.Collections.Generic.IList<string>? remoteDomains)
        {
            this.AllowedAddresses = allowedAddresses;
            this.AllowedNumbers = allowedNumbers;
            this.MediaEncryption = mediaEncryption;
            this.Credentials = credentials;
            this.RemoteDomains = remoteDomains;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InboundSIPTrunkConfigRequestModel" /> class.
        /// </summary>
        public InboundSIPTrunkConfigRequestModel()
        {
        }
    }
}