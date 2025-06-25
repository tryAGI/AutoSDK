//HintName: G.IUsersClient.UsersBlock.g.cs
#nullable enable

namespace G
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// Block a user<br/>
        /// Blocks the given user and returns a 204. If the authenticated user cannot block the given user a 422 is returned.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task UsersBlockAsync(
            string username,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}