//HintName: G.IApi.CreateImageExpansion.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Create image expansion task<br/>
        /// Expand an image by extending its borders.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateTaskResponse> CreateImageExpansionAsync(

            global::G.CreateImageExpansionRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create image expansion task<br/>
        /// Expand an image by extending its borders.
        /// </summary>
        /// <param name="image">
        /// Input image as Base64 string or URL.
        /// </param>
        /// <param name="prompt">
        /// Text prompt to guide the expansion.
        /// </param>
        /// <param name="expansionRatio"></param>
        /// <param name="aspectRatio">
        /// Target aspect ratio.
        /// </param>
        /// <param name="callbackUrl">
        /// URL to receive webhook callback when task completes.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateTaskResponse> CreateImageExpansionAsync(
            string image,
            global::G.ExpansionRatio expansionRatio,
            string? prompt = default,
            global::G.CreateImageExpansionRequestAspectRatio? aspectRatio = default,
            string? callbackUrl = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}