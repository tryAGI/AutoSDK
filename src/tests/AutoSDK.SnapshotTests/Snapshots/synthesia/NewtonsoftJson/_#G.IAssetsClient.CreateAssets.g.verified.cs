//HintName: G.IAssetsClient.CreateAssets.g.cs
#nullable enable

namespace G
{
    public partial interface IAssetsClient
    {
        /// <summary>
        /// Create media asset<br/>
        /// Creates a media asset with support for multipart or direct url upload. This endpoint currently supports only the dubbing configuration.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateAssetMultipartUploadResponse> CreateAssetsAsync(

            global::G.CreateAssetRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create media asset<br/>
        /// Creates a media asset with support for multipart or direct url upload. This endpoint currently supports only the dubbing configuration.
        /// </summary>
        /// <param name="contentType">
        /// The content type of the asset to upload. Must be one of: video/mp4, video/webm, or video/quicktime.<br/>
        /// Example: video/mp4
        /// </param>
        /// <param name="configuration">
        /// The configuration to use for the asset.
        /// </param>
        /// <param name="contentLength">
        /// The length of the file content to upload. This is used to verify the integrity of the asset during upload.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="contentMD5">
        /// The MD5 hash of the file content to upload. This is used to verify the integrity of the asset during upload.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="title">
        /// The title of the asset to upload.<br/>
        /// Default Value: Untitled<br/>
        /// Example: Untitled
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateAssetMultipartUploadResponse> CreateAssetsAsync(
            global::G.CreateAssetRequestContentType contentType,
            global::G.DubbingAssetRequestConfiguration configuration,
            int? contentLength = default,
            string? contentMD5 = default,
            string? title = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}