//HintName: G.ICertificatesClient.GetCertificate.g.cs
#nullable enable

namespace G
{
    public partial interface ICertificatesClient
    {
        /// <summary>
        /// Get a certificate that has been uploaded to the organization.<br/>
        /// You can get a certificate regardless of whether it is active or not.
        /// </summary>
        /// <param name="certId"></param>
        /// <param name="include"></param>
        /// <param name="certificateId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Certificate> GetCertificateAsync(
            string certId,
            string certificateId,
            global::System.Collections.Generic.IList<global::G.GetCertificateIncludeItem>? include = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}