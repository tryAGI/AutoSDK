//HintName: G.Models.SigstoreBundle0VerificationMaterialX509CertificateChain.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SigstoreBundle0VerificationMaterialX509CertificateChain
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("certificates")]
        public global::System.Collections.Generic.IList<global::G.SigstoreBundle0VerificationMaterialX509CertificateChainCertificate>? Certificates { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SigstoreBundle0VerificationMaterialX509CertificateChain" /> class.
        /// </summary>
        /// <param name="certificates"></param>
        public SigstoreBundle0VerificationMaterialX509CertificateChain(
            global::System.Collections.Generic.IList<global::G.SigstoreBundle0VerificationMaterialX509CertificateChainCertificate>? certificates)
        {
            this.Certificates = certificates;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SigstoreBundle0VerificationMaterialX509CertificateChain" /> class.
        /// </summary>
        public SigstoreBundle0VerificationMaterialX509CertificateChain()
        {
        }
    }
}