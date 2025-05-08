//HintName: G.ICertificatesClient.ListOrganizationCertificates.g.cs
#nullable enable

namespace G
{
    public partial interface ICertificatesClient
    {
        /// <summary>
        /// List uploaded certificates for this organization.
        /// </summary>
        /// <param name="limit">
        /// Default Value: 20
        /// </param>
        /// <param name="after"></param>
        /// <param name="order">
        /// Default Value: desc
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ListCertificatesResponse> ListOrganizationCertificatesAsync(
            int? limit = default,
            string? after = default,
            global::G.ListOrganizationCertificatesOrder? order = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}