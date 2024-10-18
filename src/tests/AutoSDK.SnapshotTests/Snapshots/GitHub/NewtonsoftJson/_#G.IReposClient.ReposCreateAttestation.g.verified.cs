//HintName: G.IReposClient.ReposCreateAttestation.g.cs
#nullable enable

namespace G
{
    public partial interface IReposClient
    {
        /// <summary>
        /// Create an attestation<br/>
        /// Store an artifact attestation and associate it with a repository.<br/>
        /// The authenticated user must have write permission to the repository and, if using a fine-grained access token, the `attestations:write` permission is required.<br/>
        /// Artifact attestations are meant to be created using the [attest action](https://github.com/actions/attest). For more information, see our guide on [using artifact attestations to establish a build's provenance](https://docs.github.com/actions/security-guides/using-artifact-attestations-to-establish-provenance-for-builds).
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ReposCreateAttestationResponse> ReposCreateAttestationAsync(
            string owner,
            string repo,
            global::G.ReposCreateAttestationRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create an attestation<br/>
        /// Store an artifact attestation and associate it with a repository.<br/>
        /// The authenticated user must have write permission to the repository and, if using a fine-grained access token, the `attestations:write` permission is required.<br/>
        /// Artifact attestations are meant to be created using the [attest action](https://github.com/actions/attest). For more information, see our guide on [using artifact attestations to establish a build's provenance](https://docs.github.com/actions/security-guides/using-artifact-attestations-to-establish-provenance-for-builds).
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="bundle">
        /// The attestation's Sigstore Bundle.<br/>
        /// Refer to the [Sigstore Bundle Specification](https://github.com/sigstore/protobuf-specs/blob/main/protos/sigstore_bundle.proto) for more information.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ReposCreateAttestationResponse> ReposCreateAttestationAsync(
            string owner,
            string repo,
            global::G.ReposCreateAttestationRequestBundle bundle,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}