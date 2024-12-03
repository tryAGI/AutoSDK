//HintName: G.Models.SigstoreBundle0VerificationMaterial.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SigstoreBundle0VerificationMaterial
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("x509CertificateChain")]
        public global::G.SigstoreBundle0VerificationMaterialX509CertificateChain? X509CertificateChain { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tlogEntries")]
        public global::System.Collections.Generic.IList<global::G.SigstoreBundle0VerificationMaterialTlogEntrie>? TlogEntries { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("timestampVerificationData")]
        public string? TimestampVerificationData { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SigstoreBundle0VerificationMaterial" /> class.
        /// </summary>
        /// <param name="x509CertificateChain"></param>
        /// <param name="tlogEntries"></param>
        /// <param name="timestampVerificationData"></param>
        public SigstoreBundle0VerificationMaterial(
            global::G.SigstoreBundle0VerificationMaterialX509CertificateChain? x509CertificateChain,
            global::System.Collections.Generic.IList<global::G.SigstoreBundle0VerificationMaterialTlogEntrie>? tlogEntries,
            string? timestampVerificationData)
        {
            this.X509CertificateChain = x509CertificateChain;
            this.TlogEntries = tlogEntries;
            this.TimestampVerificationData = timestampVerificationData;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SigstoreBundle0VerificationMaterial" /> class.
        /// </summary>
        public SigstoreBundle0VerificationMaterial()
        {
        }
    }
}