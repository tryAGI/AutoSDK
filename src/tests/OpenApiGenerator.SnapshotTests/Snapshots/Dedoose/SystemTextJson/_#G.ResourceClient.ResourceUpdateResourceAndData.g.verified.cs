//HintName: G.ResourceClient.ResourceUpdateResourceAndData.g.cs

#nullable enable

namespace G
{
    public partial class ResourceClient
    {
        partial void PrepareResourceUpdateResourceAndDataArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? token,
            ref string? projectId,
            ref string? resourceId,
            ref string? title,
            ref string? description,
            ref string? fileURL,
            ref int length,
            ref bool isLocked);
        partial void PrepareResourceUpdateResourceAndDataRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? token,
            string? projectId,
            string? resourceId,
            string? title,
            string? description,
            string? fileURL,
            int length,
            bool isLocked);
        partial void ProcessResourceUpdateResourceAndDataResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessResourceUpdateResourceAndDataResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// UpdateResourceAndData.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="projectId"></param>
        /// <param name="resourceId"></param>
        /// <param name="title"></param>
        /// <param name="description"></param>
        /// <param name="fileURL"></param>
        /// <param name="length"></param>
        /// <param name="isLocked"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.ResourceUpdateResourceAndDataResponse> ResourceUpdateResourceAndDataAsync(
            string? token = default,
            string? projectId = default,
            string? resourceId = default,
            string? title = default,
            string? description = default,
            string? fileURL = default,
            int length = default,
            bool isLocked = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareResourceUpdateResourceAndDataArguments(
                httpClient: _httpClient,
                token: ref token,
                projectId: ref projectId,
                resourceId: ref resourceId,
                title: ref title,
                description: ref description,
                fileURL: ref fileURL,
                length: ref length,
                isLocked: ref isLocked);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/api/v1/resource/updateresourceanddata?projectId={projectId}&resourceId={resourceId}&title={title}&description={description}&fileURL={fileURL}&length={length}&isLocked={isLocked}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareResourceUpdateResourceAndDataRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                token: token,
                projectId: projectId,
                resourceId: resourceId,
                title: title,
                description: description,
                fileURL: fileURL,
                length: length,
                isLocked: isLocked);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessResourceUpdateResourceAndDataResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessResourceUpdateResourceAndDataResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize<global::G.ResourceUpdateResourceAndDataResponse?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}