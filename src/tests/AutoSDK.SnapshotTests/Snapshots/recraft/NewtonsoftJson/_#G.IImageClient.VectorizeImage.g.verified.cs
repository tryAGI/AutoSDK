//HintName: G.IImageClient.VectorizeImage.g.cs
#nullable enable

namespace G
{
    public partial interface IImageClient
    {
        /// <summary>
        /// Vectorize image
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ProcessImageResponse> VectorizeImageAsync(

            global::G.ProcessImageRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Vectorize image
        /// </summary>
        /// <param name="image"></param>
        /// <param name="imagename"></param>
        /// <param name="responseFormat"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ProcessImageResponse> VectorizeImageAsync(
            byte[] image,
            string imagename,
            global::G.ResponseFormat? responseFormat = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}