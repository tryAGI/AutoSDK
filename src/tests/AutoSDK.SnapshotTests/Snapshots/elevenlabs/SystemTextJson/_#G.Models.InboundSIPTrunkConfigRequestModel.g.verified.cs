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
        [global::System.Text.Json.Serialization.JsonPropertyName("allowed_addresses")]
        public global::System.Collections.Generic.IList<string>? AllowedAddresses { get; set; }

        /// <summary>
        /// List of phone numbers that are allowed to use the trunk.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowed_numbers")]
        public global::System.Collections.Generic.IList<string>? AllowedNumbers { get; set; }

        /// <summary>
        /// Whether or not to encrypt media (data layer).<br/>
        /// Default Value: allowed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("media_encryption")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.SIPMediaEncryptionEnumJsonConverter))]
        public global::G.SIPMediaEncryptionEnum? MediaEncryption { get; set; }

        /// <summary>
        /// Optional digest authentication credentials (username/password).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("credentials")]
        public global::G.SIPTrunkCredentialsRequestModel? Credentials { get; set; }

        /// <summary>
        /// Domains of remote SIP servers used to validate TLS certificates.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("remote_domains")]
        public global::System.Collections.Generic.IList<string>? RemoteDomains { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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