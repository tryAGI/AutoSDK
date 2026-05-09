//HintName: G.IApi.CreateVoiceV1VoicesAddPost.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Create Voice<br/>
        /// Create a new voice
        /// </summary>
        /// <param name="xiApiKey"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Voice> CreateVoiceV1VoicesAddPostAsync(

            global::G.BodyCreateVoiceV1VoicesAddPost request,
            string? xiApiKey = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Voice<br/>
        /// Create a new voice
        /// </summary>
        /// <param name="xiApiKey"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AutoSDKHttpResponse<global::G.Voice>> CreateVoiceV1VoicesAddPostAsResponseAsync(

            global::G.BodyCreateVoiceV1VoicesAddPost request,
            string? xiApiKey = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Voice<br/>
        /// Create a new voice
        /// </summary>
        /// <param name="xiApiKey"></param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="files"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.Voice> CreateVoiceV1VoicesAddPostAsync(
            string name,
            string description,
            global::System.Collections.Generic.IList<byte[]> files,
            string? xiApiKey = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create Voice<br/>
        /// Create a new voice
        /// </summary>
        /// <param name="xiApiKey"></param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="files">
        /// The streams to send as multipart 'files' file parts.
        /// </param>
        /// <param name="filesFileNames">
        /// Optional file names to use for the multipart 'files' file parts.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Voice> CreateVoiceV1VoicesAddPostAsync(
            string name,
            string description,
            global::System.Collections.Generic.IReadOnlyList<global::System.IO.Stream> files,
            string? xiApiKey = default,
            global::System.Collections.Generic.IReadOnlyList<string>? filesFileNames = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Voice<br/>
        /// Create a new voice
        /// </summary>
        /// <param name="xiApiKey"></param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="files">
        /// The streams to send as multipart 'files' file parts.
        /// </param>
        /// <param name="filesFileNames">
        /// Optional file names to use for the multipart 'files' file parts.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AutoSDKHttpResponse<global::G.Voice>> CreateVoiceV1VoicesAddPostAsResponseAsync(
            string name,
            string description,
            global::System.Collections.Generic.IReadOnlyList<global::System.IO.Stream> files,
            string? xiApiKey = default,
            global::System.Collections.Generic.IReadOnlyList<string>? filesFileNames = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}