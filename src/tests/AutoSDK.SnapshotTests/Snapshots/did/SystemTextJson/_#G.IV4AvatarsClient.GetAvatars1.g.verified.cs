//HintName: G.IV4AvatarsClient.GetAvatars1.g.cs
#nullable enable

namespace G
{
    public partial interface IV4AvatarsClient
    {
        /// <summary>
        /// List all of the expressive avatars
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetAvatars1Response> GetAvatars1Async(
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}