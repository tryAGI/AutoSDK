//HintName: G.IPageScreenshotsClient.GenerateFilePageScreenshotPresignedUrlApiV1FilesIdPageScreenshotsPageIndexPresignedUrlPost.g.cs
#nullable enable

namespace G
{
    public partial interface IPageScreenshotsClient
    {
        /// <summary>
        /// Generate File Page Screenshot Presigned Url<br/>
        /// Returns a presigned url to read a page screenshot.<br/>
        /// The presigned url is valid for a limited time period, after which it will expire.<br/>
        /// Be careful on accidental exposure of the presigned url, as it may allow unauthorized access to the file before the expiration.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="pageIndex"></param>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.PresignedUrl> GenerateFilePageScreenshotPresignedUrlApiV1FilesIdPageScreenshotsPageIndexPresignedUrlPostAsync(
            global::System.Guid id,
            int pageIndex,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}