//HintName: G.AdminClient.AdminGetFilteredProjects.g.cs

#nullable enable

namespace G
{
    public partial class AdminClient
    {
        partial void PrepareAdminGetFilteredProjectsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string token,
            ref string filter,
            ref int maxResults);
        partial void PrepareAdminGetFilteredProjectsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string token,
            string filter,
            int maxResults);
        partial void ProcessAdminGetFilteredProjectsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessAdminGetFilteredProjectsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// GetFilteredProjects.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="filter"></param>
        /// <param name="maxResults"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<object> AdminGetFilteredProjectsAsync(
            string token,
            string filter,
            int maxResults,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareAdminGetFilteredProjectsArguments(
                httpClient: _httpClient,
                token: ref token,
                filter: ref filter,
                maxResults: ref maxResults);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/api/v1/admin/getfilteredprojects?filter={filter}&maxResults={maxResults}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareAdminGetFilteredProjectsRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                token: token,
                filter: filter,
                maxResults: maxResults);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessAdminGetFilteredProjectsResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessAdminGetFilteredProjectsResponseContent(
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
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<object?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}