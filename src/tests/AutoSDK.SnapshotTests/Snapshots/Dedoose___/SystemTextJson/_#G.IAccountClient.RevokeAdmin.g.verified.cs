//HintName: G.IAccountClient.RevokeAdmin.g.cs
#nullable enable

namespace G
{
    public partial interface IAccountClient
    {
        /// <summary>
        /// RevokeAdmin<br/>
        /// RevokeAdmin
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<bool> RevokeAdminAsync(
            global::G.RevokeAdminRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// RevokeAdmin<br/>
        /// RevokeAdmin
        /// </summary>
        /// <param name="accountId"></param>
        /// <param name="userId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<bool> RevokeAdminAsync(
            global::System.Guid accountId,
            global::System.Guid userId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}