//HintName: G.IAdminClient.SetAccountUserAdminStatusAsAdmin.g.cs
#nullable enable

namespace G
{
    public partial interface IAdminClient
    {
        /// <summary>
        /// SetAccountUserAdminStatus<br/>
        /// SetAccountUserAdminStatus
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> SetAccountUserAdminStatusAsAdminAsync(
            global::G.SetAccountUserAdminStatusRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// SetAccountUserAdminStatus<br/>
        /// SetAccountUserAdminStatus
        /// </summary>
        /// <param name="accountId"></param>
        /// <param name="userId"></param>
        /// <param name="isAdmin"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> SetAccountUserAdminStatusAsAdminAsync(
            global::System.Guid accountId,
            global::System.Guid userId,
            bool isAdmin,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}