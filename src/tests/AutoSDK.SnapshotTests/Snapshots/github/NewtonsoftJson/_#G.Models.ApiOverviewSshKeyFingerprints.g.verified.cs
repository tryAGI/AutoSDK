//HintName: G.Models.ApiOverviewSshKeyFingerprints.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ApiOverviewSshKeyFingerprints
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("SHA256_RSA")]
        public string? Sha256Rsa { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("SHA256_DSA")]
        public string? Sha256Dsa { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("SHA256_ECDSA")]
        public string? Sha256Ecdsa { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("SHA256_ED25519")]
        public string? Sha256Ed25519 { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiOverviewSshKeyFingerprints" /> class.
        /// </summary>
        /// <param name="sha256Rsa"></param>
        /// <param name="sha256Dsa"></param>
        /// <param name="sha256Ecdsa"></param>
        /// <param name="sha256Ed25519"></param>
        public ApiOverviewSshKeyFingerprints(
            string? sha256Rsa,
            string? sha256Dsa,
            string? sha256Ecdsa,
            string? sha256Ed25519)
        {
            this.Sha256Rsa = sha256Rsa;
            this.Sha256Dsa = sha256Dsa;
            this.Sha256Ecdsa = sha256Ecdsa;
            this.Sha256Ed25519 = sha256Ed25519;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiOverviewSshKeyFingerprints" /> class.
        /// </summary>
        public ApiOverviewSshKeyFingerprints()
        {
        }
    }
}