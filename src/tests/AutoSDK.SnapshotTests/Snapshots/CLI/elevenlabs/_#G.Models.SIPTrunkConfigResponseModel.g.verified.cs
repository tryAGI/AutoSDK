//HintName: G.Models.SIPTrunkConfigResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// SIP Trunk configuration details for a phone number
    /// </summary>
    public sealed partial class SIPTrunkConfigResponseModel
    {
        /// <summary>
        /// Hostname or IP the SIP INVITE is sent to
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("address")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Address { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transport")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.SIPTrunkTransportEnumJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.SIPTrunkTransportEnum Transport { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("media_encryption")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.SIPMediaEncryptionEnumJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.SIPMediaEncryptionEnum MediaEncryption { get; set; }

        /// <summary>
        /// SIP headers for INVITE request
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("headers")]
        public global::System.Collections.Generic.Dictionary<string, string>? Headers { get; set; }

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
        /// Whether a LiveKit SIP outbound trunk is configured<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_outbound_trunk")]
        public bool? HasOutboundTrunk { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SIPTrunkConfigResponseModel" /> class.
        /// </summary>
        /// <param name="address">
        /// Hostname or IP the SIP INVITE is sent to
        /// </param>
        /// <param name="transport"></param>
        /// <param name="mediaEncryption"></param>
        /// <param name="headers">
        /// SIP headers for INVITE request
        /// </param>
        /// <param name="hasAuthCredentials">
        /// Whether authentication credentials are configured
        /// </param>
        /// <param name="username">
        /// SIP trunk username (if available)
        /// </param>
        /// <param name="hasOutboundTrunk">
        /// Whether a LiveKit SIP outbound trunk is configured<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SIPTrunkConfigResponseModel(
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
            this.HasAuthCredentials = hasAuthCredentials;
            this.Headers = headers;
            this.Username = username;
            this.HasOutboundTrunk = hasOutboundTrunk;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SIPTrunkConfigResponseModel" /> class.
        /// </summary>
        public SIPTrunkConfigResponseModel()
        {
        }
    }
}