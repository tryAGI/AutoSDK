//HintName: G.ICertificatesClient.ListProjectCertificates.g.cs
#nullable enable

namespace G
{
    public partial interface ICertificatesClient
    {
        /// <summary>
        /// List certificates for this project.
        /// </summary>
        /// <param name="limit">
        /// Default Value: 20
        /// </param>
        /// <param name="after"></param>
        /// <param name="order">
        /// Default Value: desc
        /// </param>
        /// <param name="projectId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ListCertificatesResponse> ListProjectCertificatesAsync(
            string projectId,
            int? limit = default,
            string? after = default,
            global::G.ListProjectCertificatesOrder? order = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}