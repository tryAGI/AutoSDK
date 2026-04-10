//HintName: G.ICloudClient.CreateGcpServiceAccount.g.cs
#nullable enable

namespace G
{
    public partial interface ICloudClient
    {
        /// <summary>
        /// Create Gcp Service Account
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> CreateGcpServiceAccountAsync(

            global::G.BodyCreateGcpServiceAccountV4CloudProviderGcpServiceAccountsPost request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Gcp Service Account
        /// </summary>
        /// <param name="credentialId"></param>
        /// <param name="serviceAccountFile"></param>
        /// <param name="serviceAccountFilename"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> CreateGcpServiceAccountAsync(
            byte[] serviceAccountFile,
            string serviceAccountFilename,
            string? credentialId = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}