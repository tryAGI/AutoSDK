//HintName: G.IAccountClient.GrantAdmin.g.cs
#nullable enable

namespace G
{
    public partial interface IAccountClient
    {
        /// <summary>
        /// GrantAdmin<br/>
        /// GrantAdmin
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<bool> GrantAdminAsync(
            global::G.GrantAdminRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// GrantAdmin<br/>
        /// GrantAdmin
        /// </summary>
        /// <param name="accountId"></param>
        /// <param name="userId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<bool> GrantAdminAsync(
            global::System.Guid accountId,
            global::System.Guid userId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}