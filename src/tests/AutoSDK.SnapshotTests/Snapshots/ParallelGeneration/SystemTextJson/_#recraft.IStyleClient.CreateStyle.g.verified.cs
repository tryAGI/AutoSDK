//HintName: recraft.IStyleClient.CreateStyle.g.cs
#nullable enable

namespace recraft
{
    public partial interface IStyleClient
    {
        /// <summary>
        /// Create Style
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::recraft.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::recraft.CreateStyleResponse> CreateStyleAsync(

            global::recraft.CreateStyleRequest request,
            global::recraft.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Style
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::recraft.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::recraft.AutoSDKHttpResponse<global::recraft.CreateStyleResponse>> CreateStyleAsResponseAsync(

            global::recraft.CreateStyleRequest request,
            global::recraft.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Style
        /// </summary>
        /// <param name="images"></param>
        /// <param name="style"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::recraft.CreateStyleResponse> CreateStyleAsync(
            global::System.Collections.Generic.IList<byte[]> images,
            global::recraft.ImageStyle style,
            global::recraft.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create Style
        /// </summary>
        /// <param name="images">
        /// The streams to send as multipart 'images' file parts.
        /// </param>
        /// <param name="imagesFileNames">
        /// Optional file names to use for the multipart 'images' file parts.
        /// </param>
        /// <param name="style"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::recraft.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::recraft.CreateStyleResponse> CreateStyleAsync(
            global::System.Collections.Generic.IReadOnlyList<global::System.IO.Stream> images,
            global::recraft.ImageStyle style,
            global::System.Collections.Generic.IReadOnlyList<string>? imagesFileNames = default,
            global::recraft.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Style
        /// </summary>
        /// <param name="images">
        /// The streams to send as multipart 'images' file parts.
        /// </param>
        /// <param name="imagesFileNames">
        /// Optional file names to use for the multipart 'images' file parts.
        /// </param>
        /// <param name="style"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::recraft.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::recraft.AutoSDKHttpResponse<global::recraft.CreateStyleResponse>> CreateStyleAsResponseAsync(
            global::System.Collections.Generic.IReadOnlyList<global::System.IO.Stream> images,
            global::recraft.ImageStyle style,
            global::System.Collections.Generic.IReadOnlyList<string>? imagesFileNames = default,
            global::recraft.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}