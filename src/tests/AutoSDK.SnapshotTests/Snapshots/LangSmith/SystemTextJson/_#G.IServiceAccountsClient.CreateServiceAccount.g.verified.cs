//HintName: G.IServiceAccountsClient.CreateServiceAccount.g.cs
#nullable enable

namespace G
{
    public partial interface IServiceAccountsClient
    {
        /// <summary>
        /// Create Service Account<br/>
        /// Create a service account
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ServiceAccountCreateResponse> CreateServiceAccountAsync(
            global::G.ServiceAccountCreateRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create Service Account<br/>
        /// Create a service account
        /// </summary>
        /// <param name="name"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ServiceAccountCreateResponse> CreateServiceAccountAsync(
            string name,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}