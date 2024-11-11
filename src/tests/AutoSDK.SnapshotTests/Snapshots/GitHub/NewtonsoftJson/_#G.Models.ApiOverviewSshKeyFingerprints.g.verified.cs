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
        public string? SHA256RSA { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("SHA256_DSA")]
        public string? SHA256DSA { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("SHA256_ECDSA")]
        public string? SHA256ECDSA { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("SHA256_ED25519")]
        public string? SHA256ED25519 { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiOverviewSshKeyFingerprints" /> class.
        /// </summary>
        /// <param name="sHA256RSA"></param>
        /// <param name="sHA256DSA"></param>
        /// <param name="sHA256ECDSA"></param>
        /// <param name="sHA256ED25519"></param>
        public ApiOverviewSshKeyFingerprints(
            string? sHA256RSA,
            string? sHA256DSA,
            string? sHA256ECDSA,
            string? sHA256ED25519)
        {
            this.SHA256RSA = sHA256RSA;
            this.SHA256DSA = sHA256DSA;
            this.SHA256ECDSA = sHA256ECDSA;
            this.SHA256ED25519 = sHA256ED25519;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiOverviewSshKeyFingerprints" /> class.
        /// </summary>
        public ApiOverviewSshKeyFingerprints()
        {
        }
    }
}