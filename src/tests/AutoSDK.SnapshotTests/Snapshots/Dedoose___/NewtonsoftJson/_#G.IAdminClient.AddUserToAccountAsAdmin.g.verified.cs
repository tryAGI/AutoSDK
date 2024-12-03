//HintName: G.IAdminClient.AddUserToAccountAsAdmin.g.cs
#nullable enable

namespace G
{
    public partial interface IAdminClient
    {
        /// <summary>
        /// AddUserToAccount<br/>
        /// AddUserToAccount
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> AddUserToAccountAsAdminAsync(
            global::G.AddUserToAccountRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// AddUserToAccount<br/>
        /// AddUserToAccount
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="accountId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> AddUserToAccountAsAdminAsync(
            global::System.Guid userId,
            global::System.Guid accountId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}