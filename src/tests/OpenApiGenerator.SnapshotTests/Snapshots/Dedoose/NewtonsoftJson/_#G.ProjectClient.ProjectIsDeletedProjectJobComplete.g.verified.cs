//HintName: G.ProjectClient.ProjectIsDeletedProjectJobComplete.g.cs

#nullable enable

namespace G
{
    public partial class ProjectClient
    {
        partial void PrepareProjectIsDeletedProjectJobCompleteArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? token,
            ref string? jobId);
        partial void PrepareProjectIsDeletedProjectJobCompleteRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? token,
            string? jobId);
        partial void ProcessProjectIsDeletedProjectJobCompleteResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessProjectIsDeletedProjectJobCompleteResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// IsDeletedProjectJobComplete.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="jobId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<bool> ProjectIsDeletedProjectJobCompleteAsync(
            string? token,
            string? jobId,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareProjectIsDeletedProjectJobCompleteArguments(
                httpClient: _httpClient,
                token: ref token,
                jobId: ref jobId);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/api/v1/project/isdeletedprojectjobcomplete?jobId={jobId}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareProjectIsDeletedProjectJobCompleteRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                token: token,
                jobId: jobId);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessProjectIsDeletedProjectJobCompleteResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessProjectIsDeletedProjectJobCompleteResponseContent(
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
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<bool?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}