//HintName: G.Models.ReposCreateAttestationRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ReposCreateAttestationRequest
    {
        /// <summary>
        /// The attestation's Sigstore Bundle.<br/>
        /// Refer to the [Sigstore Bundle Specification](https://github.com/sigstore/protobuf-specs/blob/main/protos/sigstore_bundle.proto) for more information.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bundle")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ReposCreateAttestationRequestBundle Bundle { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReposCreateAttestationRequest" /> class.
        /// </summary>
        /// <param name="bundle">
        /// The attestation's Sigstore Bundle.<br/>
        /// Refer to the [Sigstore Bundle Specification](https://github.com/sigstore/protobuf-specs/blob/main/protos/sigstore_bundle.proto) for more information.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReposCreateAttestationRequest(
            global::G.ReposCreateAttestationRequestBundle bundle)
        {
            this.Bundle = bundle ?? throw new global::System.ArgumentNullException(nameof(bundle));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReposCreateAttestationRequest" /> class.
        /// </summary>
        public ReposCreateAttestationRequest()
        {
        }
    }
}