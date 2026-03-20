//HintName: G.IServiceAccountsClient.DeleteServiceAccount.g.cs
#nullable enable

namespace G
{
    public partial interface IServiceAccountsClient
    {
        /// <summary>
        /// Delete Service Account<br/>
        /// Delete a service account
        /// </summary>
        /// <param name="serviceAccountId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ServiceAccountDeleteResponse> DeleteServiceAccountAsync(
            global::System.Guid serviceAccountId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}