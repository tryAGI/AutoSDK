//HintName: G.IAccountClient.RemoveUserFromCurrentAccount.g.cs
#nullable enable

namespace G
{
    public partial interface IAccountClient
    {
        /// <summary>
        /// RemoveUserFromCurrentAccount<br/>
        /// RemoveUserFromCurrentAccount
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.User> RemoveUserFromCurrentAccountAsync(
            global::G.RemoveUserFromCurrentAccountRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// RemoveUserFromCurrentAccount<br/>
        /// RemoveUserFromCurrentAccount
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.User> RemoveUserFromCurrentAccountAsync(
            global::System.Guid userId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}