//HintName: G.Models.SigstoreBundle0VerificationMaterialX509CertificateChainCertificate.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SigstoreBundle0VerificationMaterialX509CertificateChainCertificate
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rawBytes")]
        public string? RawBytes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SigstoreBundle0VerificationMaterialX509CertificateChainCertificate" /> class.
        /// </summary>
        /// <param name="rawBytes"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SigstoreBundle0VerificationMaterialX509CertificateChainCertificate(
            string? rawBytes)
        {
            this.RawBytes = rawBytes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SigstoreBundle0VerificationMaterialX509CertificateChainCertificate" /> class.
        /// </summary>
        public SigstoreBundle0VerificationMaterialX509CertificateChainCertificate()
        {
        }
    }
}