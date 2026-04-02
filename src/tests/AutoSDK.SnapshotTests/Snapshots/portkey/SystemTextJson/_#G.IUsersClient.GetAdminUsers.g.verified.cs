//HintName: G.IUsersClient.GetAdminUsers.g.cs
#nullable enable

namespace G
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// Get users
        /// </summary>
        /// <param name="xPortkeyApiKey"></param>
        /// <param name="pageSize"></param>
        /// <param name="currentPage"></param>
        /// <param name="role"></param>
        /// <param name="email"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.UserList> GetAdminUsersAsync(
            string? xPortkeyApiKey = default,
            int? pageSize = default,
            int? currentPage = default,
            global::G.GetAdminUsersRole? role = default,
            string? email = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get users
        /// </summary>
        /// <param name="xPortkeyApiKey"></param>
        /// <param name="pageSize"></param>
        /// <param name="currentPage"></param>
        /// <param name="role"></param>
        /// <param name="email"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AutoSDKHttpResponse<global::G.UserList>> GetAdminUsersAsResponseAsync(
            string? xPortkeyApiKey = default,
            int? pageSize = default,
            int? currentPage = default,
            global::G.GetAdminUsersRole? role = default,
            string? email = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}