//HintName: G.IUsersClient.UsersCheckBlocked.g.cs
#nullable enable

namespace G
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// Check if a user is blocked by the authenticated user<br/>
        /// Returns a 204 if the given user is blocked by the authenticated user. Returns a 404 if the given user is not blocked by the authenticated user, or if the given user account has been identified as spam by GitHub.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task UsersCheckBlockedAsync(
            string username,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}