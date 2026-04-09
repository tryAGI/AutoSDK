//HintName: G.ISecurityAdvisoriesClient.SecurityAdvisoriesCreateFork.g.cs
#nullable enable

namespace G
{
    public partial interface ISecurityAdvisoriesClient
    {
        /// <summary>
        /// Create a temporary private fork<br/>
        /// Create a temporary private fork to collaborate on fixing a security vulnerability in your repository.<br/>
        /// &gt; [!NOTE]<br/>
        /// &gt; Forking a repository happens asynchronously. You may have to wait up to 5 minutes before you can access the fork.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="ghsaId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.FullRepository> SecurityAdvisoriesCreateForkAsync(
            string owner,
            string repo,
            string ghsaId,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}