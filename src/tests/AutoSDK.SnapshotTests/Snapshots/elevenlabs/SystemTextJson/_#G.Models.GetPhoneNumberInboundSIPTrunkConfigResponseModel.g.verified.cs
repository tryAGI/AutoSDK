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
        [global::System.Text.Json.Serialization.JsonPropertyName("allowed_addresses")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> AllowedAddresses { get; set; }

        /// <summary>
        /// List of phone numbers that are allowed to use the trunk.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowed_numbers")]
        public global::System.Collections.Generic.IList<string>? AllowedNumbers { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("media_encryption")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.SIPMediaEncryptionEnumJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.SIPMediaEncryptionEnum MediaEncryption { get; set; }

        /// <summary>
        /// Whether authentication credentials are configured
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_auth_credentials")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HasAuthCredentials { get; set; }

        /// <summary>
        /// SIP trunk username (if available)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("username")]
        public string? Username { get; set; }

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
        /// Initializes a new instance of the <see cref="GetPhoneNumberInboundSIPTrunkConfigResponseModel" /> class.
        /// </summary>
        /// <param name="allowedAddresses">
        /// List of IP addresses that are allowed to use the trunk. Each item in the list can be an individual IP address or a Classless Inter-Domain Routing notation representing a CIDR block.
        /// </param>
        /// <param name="allowedNumbers">
        /// List of phone numbers that are allowed to use the trunk.
        /// </param>
        /// <param name="mediaEncryption"></param>
        /// <param name="hasAuthCredentials">
        /// Whether authentication credentials are configured
        /// </param>
        /// <param name="username">
        /// SIP trunk username (if available)
        /// </param>
        /// <param name="remoteDomains">
        /// Domains of remote SIP servers used to validate TLS certificates.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetPhoneNumberInboundSIPTrunkConfigResponseModel(
            global::System.Collections.Generic.IList<string> allowedAddresses,
            global::G.SIPMediaEncryptionEnum mediaEncryption,
            bool hasAuthCredentials,
            global::System.Collections.Generic.IList<string>? allowedNumbers,
            string? username,
            global::System.Collections.Generic.IList<string>? remoteDomains)
        {
            this.AllowedAddresses = allowedAddresses ?? throw new global::System.ArgumentNullException(nameof(allowedAddresses));
            this.MediaEncryption = mediaEncryption;
            this.HasAuthCredentials = hasAuthCredentials;
            this.AllowedNumbers = allowedNumbers;
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