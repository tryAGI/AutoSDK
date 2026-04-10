//HintName: G.IMemoClient.AddMemoFolderLinks.g.cs
#nullable enable

namespace G
{
    public partial interface IMemoClient
    {
        /// <summary>
        /// AddMemoFolderLinks<br/>
        /// AddMemoFolderLinks
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> AddMemoFolderLinksAsync(

            global::G.AddMemoFolderLinksRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// AddMemoFolderLinks<br/>
        /// AddMemoFolderLinks
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="memoId"></param>
        /// <param name="folderIds"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> AddMemoFolderLinksAsync(
            global::System.Guid projectId,
            string memoId,
            global::System.Collections.Generic.IList<string> folderIds,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}