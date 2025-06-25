//HintName: G.ICertificatesClient.ActivateOrganizationCertificates.g.cs
#nullable enable

namespace G
{
    public partial interface ICertificatesClient
    {
        /// <summary>
        /// Activate certificates at the organization level.<br/>
        /// You can atomically and idempotently activate up to 10 certificates at a time.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ListCertificatesResponse> ActivateOrganizationCertificatesAsync(
            global::G.ToggleCertificatesRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Activate certificates at the organization level.<br/>
        /// You can atomically and idempotently activate up to 10 certificates at a time.
        /// </summary>
        /// <param name="certificateIds"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ListCertificatesResponse> ActivateOrganizationCertificatesAsync(
            global::System.Collections.Generic.IList<string> certificateIds,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}