//HintName: G.AdminClient.AdminGetMergeStatus.g.cs

#nullable enable

namespace G
{
    public partial class AdminClient
    {
        partial void PrepareAdminGetMergeStatusArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string token,
            ref string mergedProjectId);
        partial void PrepareAdminGetMergeStatusRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string token,
            string mergedProjectId);
        partial void ProcessAdminGetMergeStatusResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessAdminGetMergeStatusResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// GetMergeStatus.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="mergedProjectId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<object> AdminGetMergeStatusAsync(
            string token,
            string mergedProjectId,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareAdminGetMergeStatusArguments(
                httpClient: _httpClient,
                token: ref token,
                mergedProjectId: ref mergedProjectId);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/api/v1/admin/getmergestatus?mergedProjectId={mergedProjectId}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareAdminGetMergeStatusRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                token: token,
                mergedProjectId: mergedProjectId);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessAdminGetMergeStatusResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessAdminGetMergeStatusResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize<object?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}