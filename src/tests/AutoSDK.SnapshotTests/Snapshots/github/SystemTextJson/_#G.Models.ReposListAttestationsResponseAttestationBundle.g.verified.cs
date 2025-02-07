//HintName: G.Models.ReposListAttestationsResponseAttestationBundle.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The attestation's Sigstore Bundle.<br/>
    /// Refer to the [Sigstore Bundle Specification](https://github.com/sigstore/protobuf-specs/blob/main/protos/sigstore_bundle.proto) for more information.
    /// </summary>
    public sealed partial class ReposListAttestationsResponseAttestationBundle
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mediaType")]
        public string? MediaType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("verificationMaterial")]
        public object? VerificationMaterial { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dsseEnvelope")]
        public object? DsseEnvelope { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReposListAttestationsResponseAttestationBundle" /> class.
        /// </summary>
        /// <param name="mediaType"></param>
        /// <param name="verificationMaterial"></param>
        /// <param name="dsseEnvelope"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReposListAttestationsResponseAttestationBundle(
            string? mediaType,
            object? verificationMaterial,
            object? dsseEnvelope)
        {
            this.MediaType = mediaType;
            this.VerificationMaterial = verificationMaterial;
            this.DsseEnvelope = dsseEnvelope;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReposListAttestationsResponseAttestationBundle" /> class.
        /// </summary>
        public ReposListAttestationsResponseAttestationBundle()
        {
        }
    }
}