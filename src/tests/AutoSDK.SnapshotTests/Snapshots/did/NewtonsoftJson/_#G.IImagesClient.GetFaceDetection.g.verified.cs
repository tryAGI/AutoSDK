//HintName: G.IImagesClient.GetFaceDetection.g.cs
#nullable enable

namespace G
{
    public partial interface IImagesClient
    {
        /// <summary>
        /// Get face detection
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetFaceDetectionResponse> GetFaceDetectionAsync(

            global::G.GetFaceDetectionRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get face detection
        /// </summary>
        /// <param name="sourceUrl"></param>
        /// <param name="shouldSkipDetection"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetFaceDetectionResponse> GetFaceDetectionAsync(
            string sourceUrl,
            bool? shouldSkipDetection = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}