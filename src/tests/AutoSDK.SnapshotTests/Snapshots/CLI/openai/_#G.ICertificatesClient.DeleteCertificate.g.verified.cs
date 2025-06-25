//HintName: G.ICertificatesClient.DeleteCertificate.g.cs
#nullable enable

namespace G
{
    public partial interface ICertificatesClient
    {
        /// <summary>
        /// Delete a certificate from the organization.<br/>
        /// The certificate must be inactive for the organization and all projects.
        /// </summary>
        /// <param name="certificateId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.DeleteCertificateResponse> DeleteCertificateAsync(
            string certificateId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}