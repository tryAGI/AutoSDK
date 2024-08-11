//HintName: G.ResourceClient.ResourceStartAddPDFSwfResourceJob.g.cs

#nullable enable

namespace G
{
    public partial class ResourceClient
    {
        partial void PrepareResourceStartAddPDFSwfResourceJobArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? token,
            ref string? projectId,
            ref string? title,
            ref string? fileUri);
        partial void PrepareResourceStartAddPDFSwfResourceJobRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? token,
            string? projectId,
            string? title,
            string? fileUri);
        partial void ProcessResourceStartAddPDFSwfResourceJobResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessResourceStartAddPDFSwfResourceJobResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// StartAddPDFSwfResourceJob.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="projectId"></param>
        /// <param name="title"></param>
        /// <param name="fileUri"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<string> ResourceStartAddPDFSwfResourceJobAsync(
            string? token,
            string? projectId,
            string? title,
            string? fileUri,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareResourceStartAddPDFSwfResourceJobArguments(
                httpClient: _httpClient,
                token: ref token,
                projectId: ref projectId,
                title: ref title,
                fileUri: ref fileUri);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/api/v1/resource/startaddpdfswfresourcejob?projectId={projectId}&title={title}&fileUri={fileUri}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareResourceStartAddPDFSwfResourceJobRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                token: token,
                projectId: projectId,
                title: title,
                fileUri: fileUri);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessResourceStartAddPDFSwfResourceJobResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessResourceStartAddPDFSwfResourceJobResponseContent(
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