//HintName: G.IApi.OpenaiFilesV1OpenaiFilesPost.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Openai Files
        /// </summary>
        /// <param name="xiApiKey"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> OpenaiFilesV1OpenaiFilesPostAsync(

            global::G.BodyOpenaiFilesV1OpenaiFilesPost request,
            string? xiApiKey = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Openai Files
        /// </summary>
        /// <param name="xiApiKey"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AutoSDKHttpResponse<string>> OpenaiFilesV1OpenaiFilesPostAsResponseAsync(

            global::G.BodyOpenaiFilesV1OpenaiFilesPost request,
            string? xiApiKey = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Openai Files
        /// </summary>
        /// <param name="xiApiKey"></param>
        /// <param name="purpose"></param>
        /// <param name="file"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> OpenaiFilesV1OpenaiFilesPostAsync(
            string purpose,
            global::System.Collections.Generic.IList<byte[]> file,
            string? xiApiKey = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Openai Files
        /// </summary>
        /// <param name="xiApiKey"></param>
        /// <param name="purpose"></param>
        /// <param name="file">
        /// The streams to send as multipart 'file' file parts.
        /// </param>
        /// <param name="fileFileNames">
        /// Optional file names to use for the multipart 'file' file parts.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> OpenaiFilesV1OpenaiFilesPostAsync(
            string purpose,
            global::System.Collections.Generic.IReadOnlyList<global::System.IO.Stream> file,
            string? xiApiKey = default,
            global::System.Collections.Generic.IReadOnlyList<string>? fileFileNames = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Openai Files
        /// </summary>
        /// <param name="xiApiKey"></param>
        /// <param name="purpose"></param>
        /// <param name="file">
        /// The streams to send as multipart 'file' file parts.
        /// </param>
        /// <param name="fileFileNames">
        /// Optional file names to use for the multipart 'file' file parts.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AutoSDKHttpResponse<string>> OpenaiFilesV1OpenaiFilesPostAsResponseAsync(
            string purpose,
            global::System.Collections.Generic.IReadOnlyList<global::System.IO.Stream> file,
            string? xiApiKey = default,
            global::System.Collections.Generic.IReadOnlyList<string>? fileFileNames = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}