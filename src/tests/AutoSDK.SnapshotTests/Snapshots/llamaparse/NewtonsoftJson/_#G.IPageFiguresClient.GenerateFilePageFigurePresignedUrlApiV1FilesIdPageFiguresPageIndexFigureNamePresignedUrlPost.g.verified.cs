//HintName: G.IPageFiguresClient.GenerateFilePageFigurePresignedUrlApiV1FilesIdPageFiguresPageIndexFigureNamePresignedUrlPost.g.cs
#nullable enable

namespace G
{
    public partial interface IPageFiguresClient
    {
        /// <summary>
        /// Generate File Page Figure Presigned Url<br/>
        /// Returns a presigned url to read a page figure.<br/>
        /// The presigned url is valid for a limited time period, after which it will expire.<br/>
        /// Be careful on accidental exposure of the presigned url, as it may allow unauthorized access to the file before the expiration.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="pageIndex"></param>
        /// <param name="figureName"></param>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.PresignedUrl> GenerateFilePageFigurePresignedUrlApiV1FilesIdPageFiguresPageIndexFigureNamePresignedUrlPostAsync(
            global::System.Guid id,
            int pageIndex,
            string figureName,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}