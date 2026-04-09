//HintName: G.IMemoClient.LoadProjectMemosFoldersAndLinks.g.cs
#nullable enable

namespace G
{
    public partial interface IMemoClient
    {
        /// <summary>
        /// LoadProjectMemosFoldersAndLinks<br/>
        /// LoadProjectMemosFoldersAndLinks
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.MemosFoldersAndLinks> LoadProjectMemosFoldersAndLinksAsync(

            global::G.LoadProjectMemosFoldersAndLinksRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// LoadProjectMemosFoldersAndLinks<br/>
        /// LoadProjectMemosFoldersAndLinks
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.MemosFoldersAndLinks> LoadProjectMemosFoldersAndLinksAsync(
            global::System.Guid projectId,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}