//HintName: recraft.IUserClient.GetCurrentUser.g.cs
#nullable enable

namespace recraft
{
    public partial interface IUserClient
    {
        /// <summary>
        /// Get current user info
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::recraft.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::recraft.User> GetCurrentUserAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}