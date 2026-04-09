//HintName: G.IReposClient.ReposCancelPagesDeployment.g.cs
#nullable enable

namespace G
{
    public partial interface IReposClient
    {
        /// <summary>
        /// Cancel a GitHub Pages deployment<br/>
        /// Cancels a GitHub Pages deployment.<br/>
        /// The authenticated user must have write permissions for the GitHub Pages site.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="pagesDeploymentId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task ReposCancelPagesDeploymentAsync(
            string owner,
            string repo,
            global::G.OneOf<int?, string> pagesDeploymentId,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}