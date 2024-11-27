//HintName: G.IUserClient.LinkUsertoAccount.g.cs
#nullable enable

namespace G
{
    public partial interface IUserClient
    {
        /// <summary>
        /// LinkUsertoAccount<br/>
        /// LinkUsertoAccount
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> LinkUsertoAccountAsync(
            global::G.LinkUsertoAccountRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// LinkUsertoAccount<br/>
        /// LinkUsertoAccount
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="accountId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> LinkUsertoAccountAsync(
            global::System.Guid userId,
            global::System.Guid accountId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}