//HintName: G.IPageScreenshotsClient.GetFilePageScreenshotApiV1FilesIdPageScreenshotsPageIndexGet.g.cs
#nullable enable

namespace G
{
    public partial interface IPageScreenshotsClient
    {
        /// <summary>
        /// Get File Page Screenshot<br/>
        /// Get screenshot of a page from a file.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="pageIndex"></param>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> GetFilePageScreenshotApiV1FilesIdPageScreenshotsPageIndexGetAsync(
            global::System.Guid id,
            int pageIndex,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}