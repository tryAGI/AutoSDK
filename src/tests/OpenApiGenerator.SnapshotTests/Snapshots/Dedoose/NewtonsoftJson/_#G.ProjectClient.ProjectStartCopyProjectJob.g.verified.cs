//HintName: G.ProjectClient.ProjectStartCopyProjectJob.g.cs

#nullable enable

namespace G
{
    public partial class ProjectClient
    {
        partial void PrepareProjectStartCopyProjectJobArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? token,
            ref string? userId,
            ref string? projectId,
            ref string? title,
            ref string? decription);
        partial void PrepareProjectStartCopyProjectJobRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? token,
            string? userId,
            string? projectId,
            string? title,
            string? decription);
        partial void ProcessProjectStartCopyProjectJobResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessProjectStartCopyProjectJobResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// StartCopyProjectJob.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="userId"></param>
        /// <param name="projectId"></param>
        /// <param name="title"></param>
        /// <param name="decription"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<string> ProjectStartCopyProjectJobAsync(
            string? token = default,
            string? userId = default,
            string? projectId = default,
            string? title = default,
            string? decription = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareProjectStartCopyProjectJobArguments(
                httpClient: _httpClient,
                token: ref token,
                userId: ref userId,
                projectId: ref projectId,
                title: ref title,
                decription: ref decription);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/api/v1/project/startcopyprojectjob?userId={userId}&projectId={projectId}&title={title}&decription={decription}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareProjectStartCopyProjectJobRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                token: token,
                userId: userId,
                projectId: projectId,
                title: title,
                decription: decription);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessProjectStartCopyProjectJobResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessProjectStartCopyProjectJobResponseContent(
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
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<string?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}