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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> CreateGcpServiceAccountAsync(
            global::G.BodyCreateGcpServiceAccountV4CloudProviderGcpServiceAccountsPost request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create Gcp Service Account
        /// </summary>
        /// <param name="credentialId"></param>
        /// <param name="serviceAccountFile"></param>
        /// <param name="serviceAccountFilename"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> CreateGcpServiceAccountAsync(
            byte[] serviceAccountFile,
            string serviceAccountFilename,
            string? credentialId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}