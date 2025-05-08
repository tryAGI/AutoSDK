//HintName: G.ICertificatesClient.UploadCertificate.g.cs
#nullable enable

namespace G
{
    public partial interface ICertificatesClient
    {
        /// <summary>
        /// Upload a certificate to the organization. This does **not** automatically activate the certificate.<br/>
        /// Organizations can upload up to 50 certificates.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Certificate> UploadCertificateAsync(
            global::G.UploadCertificateRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Upload a certificate to the organization. This does **not** automatically activate the certificate.<br/>
        /// Organizations can upload up to 50 certificates.
        /// </summary>
        /// <param name="name">
        /// An optional name for the certificate
        /// </param>
        /// <param name="content">
        /// The certificate content in PEM format
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.Certificate> UploadCertificateAsync(
            string content,
            string? name = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}