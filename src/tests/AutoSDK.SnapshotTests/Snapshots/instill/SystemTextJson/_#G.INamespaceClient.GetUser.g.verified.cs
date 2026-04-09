//HintName: G.INamespaceClient.GetUser.g.cs
#nullable enable

namespace G
{
    public partial interface INamespaceClient
    {
        /// <summary>
        /// Get a user<br/>
        /// Returns the details of a user by their ID.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="view"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetUserResponse> GetUserAsync(
            string userId,
            global::G.GetUserView? view = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}