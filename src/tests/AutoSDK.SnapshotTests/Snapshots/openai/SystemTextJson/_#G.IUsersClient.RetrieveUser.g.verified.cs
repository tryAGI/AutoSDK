//HintName: G.IUsersClient.RetrieveUser.g.cs
#nullable enable

namespace G
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// Retrieves a user by their identifier.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.User> RetrieveUserAsync(
            string userId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}