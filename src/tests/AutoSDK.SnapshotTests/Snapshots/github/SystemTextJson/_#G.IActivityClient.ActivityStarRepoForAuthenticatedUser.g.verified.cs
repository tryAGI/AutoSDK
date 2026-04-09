//HintName: G.IActivityClient.ActivityStarRepoForAuthenticatedUser.g.cs
#nullable enable

namespace G
{
    public partial interface IActivityClient
    {
        /// <summary>
        /// Star a repository for the authenticated user<br/>
        /// Note that you'll need to set `Content-Length` to zero when calling out to this endpoint. For more information, see "[HTTP method](https://docs.github.com/rest/guides/getting-started-with-the-rest-api#http-method)."
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task ActivityStarRepoForAuthenticatedUserAsync(
            string owner,
            string repo,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}