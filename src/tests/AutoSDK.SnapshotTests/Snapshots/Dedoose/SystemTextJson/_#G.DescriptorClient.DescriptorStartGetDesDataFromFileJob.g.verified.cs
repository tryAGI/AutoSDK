//HintName: G.DescriptorClient.DescriptorStartGetDesDataFromFileJob.g.cs

#nullable enable

namespace G
{
    public partial class DescriptorClient
    {
        partial void PrepareDescriptorStartGetDesDataFromFileJobArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? token,
            ref string? localFileURL,
            ref global::System.Guid setId,
            ref global::System.Guid projectId);
        partial void PrepareDescriptorStartGetDesDataFromFileJobRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? token,
            string? localFileURL,
            global::System.Guid setId,
            global::System.Guid projectId);
        partial void ProcessDescriptorStartGetDesDataFromFileJobResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessDescriptorStartGetDesDataFromFileJobResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// StartGetDesDataFromFileJob.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="localFileURL"></param>
        /// <param name="setId"></param>
        /// <param name="projectId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.DescriptorStartGetDesDataFromFileJobResponse> DescriptorStartGetDesDataFromFileJobAsync(
            string? token = default,
            string? localFileURL = default,
            global::System.Guid setId = default,
            global::System.Guid projectId = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareDescriptorStartGetDesDataFromFileJobArguments(
                httpClient: _httpClient,
                token: ref token,
                localFileURL: ref localFileURL,
                setId: ref setId,
                projectId: ref projectId);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/api/v1/descriptor/startgetdesdatafromfilejob?localFileURL={localFileURL}&setId={setId}&projectId={projectId}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareDescriptorStartGetDesDataFromFileJobRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                token: token,
                localFileURL: localFileURL,
                setId: setId,
                projectId: projectId);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessDescriptorStartGetDesDataFromFileJobResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessDescriptorStartGetDesDataFromFileJobResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize<global::G.DescriptorStartGetDesDataFromFileJobResponse?>(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}