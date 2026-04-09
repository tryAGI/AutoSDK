//HintName: G.ICertificatesClient.ModifyCertificate.g.cs
#nullable enable

namespace G
{
    public partial interface ICertificatesClient
    {
        /// <summary>
        /// Modify a certificate. Note that only the name can be modified.
        /// </summary>
        /// <param name="certificateId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Certificate> ModifyCertificateAsync(
            string certificateId,

            global::G.ModifyCertificateRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Modify a certificate. Note that only the name can be modified.
        /// </summary>
        /// <param name="certificateId"></param>
        /// <param name="name">
        /// The updated name for the certificate
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.Certificate> ModifyCertificateAsync(
            string certificateId,
            string name,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}