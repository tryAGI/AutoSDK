//HintName: G.ReposClient.ReposCreateAutolink.g.cs

#nullable enable

namespace G
{
    public partial class ReposClient
    {
        partial void PrepareReposCreateAutolinkArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string owner,
            ref string repo,
            global::G.ReposCreateAutolinkRequest request);
        partial void PrepareReposCreateAutolinkRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string owner,
            string repo,
            global::G.ReposCreateAutolinkRequest request);
        partial void ProcessReposCreateAutolinkResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessReposCreateAutolinkResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create an autolink reference for a repository<br/>
        /// Users with admin access to the repository can create an autolink.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.Autolink> ReposCreateAutolinkAsync(
            string owner,
            string repo,
            global::G.ReposCreateAutolinkRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareReposCreateAutolinkArguments(
                httpClient: _httpClient,
                owner: ref owner,
                repo: ref repo,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/repos/{owner}/{repo}/autolinks", global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContentBody = global::System.Text.Json.JsonSerializer.Serialize(request, _jsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareReposCreateAutolinkRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                owner: owner,
                repo: repo,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessReposCreateAutolinkResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessReposCreateAutolinkResponseContent(
                httpClient: _httpClient,
                httpResponseMessage: response,
                content: ref __content);

            try
            {
                response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException ex)
            {
                throw new global::System.InvalidOperationException(__content, ex);
            }

            return
                global::System.Text.Json.JsonSerializer.Deserialize<global::G.Autolink?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Create an autolink reference for a repository<br/>
        /// Users with admin access to the repository can create an autolink.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="keyPrefix">
        /// This prefix appended by certain characters will generate a link any time it is found in an issue, pull request, or commit.
        /// </param>
        /// <param name="urlTemplate">
        /// The URL must contain `&lt;num&gt;` for the reference number. `&lt;num&gt;` matches different characters depending on the value of `is_alphanumeric`.
        /// </param>
        /// <param name="isAlphanumeric">
        /// Whether this autolink reference matches alphanumeric characters. If true, the `&lt;num&gt;` parameter of the `url_template` matches alphanumeric characters `A-Z` (case insensitive), `0-9`, and `-`. If false, this autolink reference only matches numeric characters.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.Autolink> ReposCreateAutolinkAsync(
            string owner,
            string repo,
            string keyPrefix,
            string urlTemplate,
            bool isAlphanumeric = true,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.ReposCreateAutolinkRequest
            {
                KeyPrefix = keyPrefix,
                UrlTemplate = urlTemplate,
                IsAlphanumeric = isAlphanumeric,
            };

            return await ReposCreateAutolinkAsync(
                owner: owner,
                repo: repo,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}