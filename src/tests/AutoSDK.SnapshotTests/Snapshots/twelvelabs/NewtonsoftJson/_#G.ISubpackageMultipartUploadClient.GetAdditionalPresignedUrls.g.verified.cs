//HintName: G.ISubpackageMultipartUploadClient.GetAdditionalPresignedUrls.g.cs
#nullable enable

namespace G
{
    public partial interface ISubpackageMultipartUploadClient
    {
        /// <summary>
        /// Request presigned URLs for the remaining chunks<br/>
        /// This method generates new presigned URLs for specific chunks that require uploading. Use this endpoint in the following situations:<br/>
        /// - Your initial URLs have expired (URLs expire after one hour).<br/>
        /// - The initial set of presigned URLs does not include URLs for all chunks.<br/>
        /// - You need to retry failed chunk uploads with new URLs.<br/>
        /// To specify which chunks need URLs, use the `start` and `count` parameters. For example, to generate URLs for chunks 21 to 30, use `start=21` and `count=10`.<br/>
        /// The response will provide new URLs, each with a fresh expiration time of one hour.
        /// </summary>
        /// <param name="uploadId"></param>
        /// <param name="xApiKey"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.RequestAdditionalPresignedURLsResponse> GetAdditionalPresignedUrlsAsync(
            string uploadId,
            string xApiKey,

            global::G.RequestAdditionalPresignedURLsRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Request presigned URLs for the remaining chunks<br/>
        /// This method generates new presigned URLs for specific chunks that require uploading. Use this endpoint in the following situations:<br/>
        /// - Your initial URLs have expired (URLs expire after one hour).<br/>
        /// - The initial set of presigned URLs does not include URLs for all chunks.<br/>
        /// - You need to retry failed chunk uploads with new URLs.<br/>
        /// To specify which chunks need URLs, use the `start` and `count` parameters. For example, to generate URLs for chunks 21 to 30, use `start=21` and `count=10`.<br/>
        /// The response will provide new URLs, each with a fresh expiration time of one hour.
        /// </summary>
        /// <param name="uploadId"></param>
        /// <param name="xApiKey"></param>
        /// <param name="start">
        /// The index of the first chunk number to generate URLs for. Chunks are numbered from 1.
        /// </param>
        /// <param name="count">
        /// The number of presigned URLs to generate starting from the index. You can request a maximum of 50 URLs in a single API call.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.RequestAdditionalPresignedURLsResponse> GetAdditionalPresignedUrlsAsync(
            string uploadId,
            string xApiKey,
            int start,
            int count,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}