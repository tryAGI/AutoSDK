//HintName: G.IApi.FetchCreate.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Fetch a Page<br/>
        /// Fetch a page and return its content, headers, and metadata.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.FetchCreateResponse> FetchCreateAsync(

            global::G.FetchCreateRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Fetch a Page<br/>
        /// Fetch a page and return its content, headers, and metadata.
        /// </summary>
        /// <param name="url">
        /// The URL to fetch
        /// </param>
        /// <param name="allowRedirects">
        /// Whether to follow HTTP redirects<br/>
        /// Default Value: false
        /// </param>
        /// <param name="allowInsecureSsl">
        /// Whether to bypass TLS certificate verification<br/>
        /// Default Value: false
        /// </param>
        /// <param name="proxies">
        /// Whether to enable proxy support for the request<br/>
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.FetchCreateResponse> FetchCreateAsync(
            string url,
            bool? allowRedirects = default,
            bool? allowInsecureSsl = default,
            bool? proxies = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}