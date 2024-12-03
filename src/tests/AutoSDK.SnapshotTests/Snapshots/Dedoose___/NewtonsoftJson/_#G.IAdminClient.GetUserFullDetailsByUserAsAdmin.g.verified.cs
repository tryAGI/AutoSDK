//HintName: G.IAdminClient.GetUserFullDetailsByUserAsAdmin.g.cs
#nullable enable

namespace G
{
    public partial interface IAdminClient
    {
        /// <summary>
        /// GetUserFullDetailsByUser<br/>
        /// GetUserFullDetailsByUser
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> GetUserFullDetailsByUserAsAdminAsync(
            global::G.GetUserFullDetailsByUserRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// GetUserFullDetailsByUser<br/>
        /// GetUserFullDetailsByUser
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> GetUserFullDetailsByUserAsAdminAsync(
            global::System.Guid userId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}