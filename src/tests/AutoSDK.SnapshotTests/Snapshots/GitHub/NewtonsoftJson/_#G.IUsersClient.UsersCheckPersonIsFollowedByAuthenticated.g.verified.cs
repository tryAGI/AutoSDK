//HintName: G.IUsersClient.UsersCheckPersonIsFollowedByAuthenticated.g.cs
#nullable enable

namespace G
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// Check if a person is followed by the authenticated user
        /// </summary>
        /// <param name="username"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.BasicError> UsersCheckPersonIsFollowedByAuthenticatedAsync(
            string username,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}