//HintName: G.ICertificatesClient.ActivateCertificatesForProject.g.cs
#nullable enable

namespace G
{
    public partial interface ICertificatesClient
    {
        /// <summary>
        /// Activate certificates at the project level.<br/>
        /// You can atomically and idempotently activate up to 10 certificates at a time.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ListCertificatesResponse> ActivateCertificatesForProjectAsync(
            string projectId,

            global::G.ToggleCertificatesRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Activate certificates at the project level.<br/>
        /// You can atomically and idempotently activate up to 10 certificates at a time.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="certificateIds"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ListCertificatesResponse> ActivateCertificatesForProjectAsync(
            string projectId,
            global::System.Collections.Generic.IList<string> certificateIds,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}