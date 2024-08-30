//HintName: G.DomainsClient.GetDomains.g.cs

#nullable enable

namespace G
{
    public partial class DomainsClient
    {
        partial void PrepareGetDomainsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string ip,
            ref int page,
            ref int limit);
        partial void PrepareGetDomainsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string ip,
            int page,
            int limit);
        partial void ProcessGetDomainsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGetDomainsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Our Hosted Domains, or Reverse IP API returns a list of all of the domains hosted on the provided IP address.<br/>
        /// Returns a list of all of the domains hosted on the provided IP address.
        /// </summary>
        /// <param name="ip"></param>
        /// <param name="page"></param>
        /// <param name="limit">
        /// Default Value: 100
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.DomainsResponse> GetDomainsAsync(
            string ip,
            int page = default,
            int limit = 100,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareGetDomainsArguments(
                httpClient: _httpClient,
                ip: ref ip,
                page: ref page,
                limit: ref limit);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/domains/{ip}?page={page}&limit={limit}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareGetDomainsRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                ip: ip,
                page: page,
                limit: limit);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessGetDomainsResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessGetDomainsResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize<global::G.DomainsResponse?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}