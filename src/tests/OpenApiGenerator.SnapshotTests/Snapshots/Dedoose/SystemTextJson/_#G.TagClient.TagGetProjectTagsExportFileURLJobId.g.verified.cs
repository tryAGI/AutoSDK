//HintName: G.TagClient.TagGetProjectTagsExportFileURLJobId.g.cs

#nullable enable

namespace G
{
    public partial class TagClient
    {
        partial void PrepareTagGetProjectTagsExportFileURLJobIdArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? token,
            ref string? projectId,
            ref string? fileExtension,
            ref bool includeExcerpts,
            ref string? encryptedSymKey);
        partial void PrepareTagGetProjectTagsExportFileURLJobIdRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? token,
            string? projectId,
            string? fileExtension,
            bool includeExcerpts,
            string? encryptedSymKey);
        partial void ProcessTagGetProjectTagsExportFileURLJobIdResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessTagGetProjectTagsExportFileURLJobIdResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// GetProjectTagsExportFileURLJobId.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="projectId"></param>
        /// <param name="fileExtension"></param>
        /// <param name="includeExcerpts"></param>
        /// <param name="encryptedSymKey"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<string> TagGetProjectTagsExportFileURLJobIdAsync(
            string? token,
            string? projectId,
            string? fileExtension,
            bool includeExcerpts,
            string? encryptedSymKey,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareTagGetProjectTagsExportFileURLJobIdArguments(
                httpClient: _httpClient,
                token: ref token,
                projectId: ref projectId,
                fileExtension: ref fileExtension,
                includeExcerpts: ref includeExcerpts,
                encryptedSymKey: ref encryptedSymKey);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/api/v1/tag/getprojecttagsexportfileurljobid?projectId={projectId}&fileExtension={fileExtension}&includeExcerpts={includeExcerpts}&encryptedSymKey={encryptedSymKey}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareTagGetProjectTagsExportFileURLJobIdRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                token: token,
                projectId: projectId,
                fileExtension: fileExtension,
                includeExcerpts: includeExcerpts,
                encryptedSymKey: encryptedSymKey);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessTagGetProjectTagsExportFileURLJobIdResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessTagGetProjectTagsExportFileURLJobIdResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize<string?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}