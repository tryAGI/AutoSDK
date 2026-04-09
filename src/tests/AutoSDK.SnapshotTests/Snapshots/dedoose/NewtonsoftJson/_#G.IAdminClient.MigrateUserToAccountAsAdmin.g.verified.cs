//HintName: G.IAdminClient.MigrateUserToAccountAsAdmin.g.cs
#nullable enable

namespace G
{
    public partial interface IAdminClient
    {
        /// <summary>
        /// MigrateUserToAccount<br/>
        /// MigrateUserToAccount
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> MigrateUserToAccountAsAdminAsync(

            global::G.MigrateUserToAccountRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// MigrateUserToAccount<br/>
        /// MigrateUserToAccount
        /// </summary>
        /// <param name="userToBeMovedId"></param>
        /// <param name="accountIdToMoveTo"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> MigrateUserToAccountAsAdminAsync(
            global::System.Guid userToBeMovedId,
            global::System.Guid accountIdToMoveTo,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}