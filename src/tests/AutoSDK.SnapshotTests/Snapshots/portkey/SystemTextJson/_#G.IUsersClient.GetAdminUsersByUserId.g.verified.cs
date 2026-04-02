//HintName: G.IUsersClient.GetAdminUsersByUserId.g.cs
#nullable enable

namespace G
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// Get user
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.User> GetAdminUsersByUserIdAsync(
            string userId,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get user
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AutoSDKHttpResponse<global::G.User>> GetAdminUsersByUserIdAsResponseAsync(
            string userId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}