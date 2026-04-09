//HintName: recraft.IUserClient.GetCurrentUser.g.cs
#nullable enable

namespace recraft
{
    public partial interface IUserClient
    {
        /// <summary>
        /// Get current user info
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::recraft.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::recraft.User> GetCurrentUserAsync(
            global::recraft.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}