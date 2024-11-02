//HintName: G.IUserClient.GetCurrentUser.g.cs
#nullable enable

namespace G
{
    public partial interface IUserClient
    {
        /// <summary>
        /// Get current user info
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.User> GetCurrentUserAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}