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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Certificate> ModifyCertificateAsync(
            string certificateId,
            global::G.ModifyCertificateRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Modify a certificate. Note that only the name can be modified.
        /// </summary>
        /// <param name="certificateId"></param>
        /// <param name="name">
        /// The updated name for the certificate
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.Certificate> ModifyCertificateAsync(
            string certificateId,
            string name,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}