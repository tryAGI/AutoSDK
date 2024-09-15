//HintName: G.IUsersClient.ListUsers.g.cs
#nullable enable

namespace G
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// Lists all of the users in the organization.
        /// </summary>
        /// <param name="limit">
        /// Default Value: 20
        /// </param>
        /// <param name="after"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.UserListResponse> ListUsersAsync(
            int limit = 20,
            string? after = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}