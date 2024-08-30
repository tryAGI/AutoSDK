//HintName: G.TagClient.TagAddTagLink.g.cs

#nullable enable

namespace G
{
    public partial class TagClient
    {
        partial void PrepareTagAddTagLinkArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? token,
            ref string? projectId,
            ref string? tag1Id,
            ref string? tag2Id,
            ref bool isParentChildLink);
        partial void PrepareTagAddTagLinkRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? token,
            string? projectId,
            string? tag1Id,
            string? tag2Id,
            bool isParentChildLink);
        partial void ProcessTagAddTagLinkResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessTagAddTagLinkResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// AddTagLink.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="projectId"></param>
        /// <param name="tag1Id"></param>
        /// <param name="tag2Id"></param>
        /// <param name="isParentChildLink"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.TagLink> TagAddTagLinkAsync(
            string? token = default,
            string? projectId = default,
            string? tag1Id = default,
            string? tag2Id = default,
            bool isParentChildLink = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareTagAddTagLinkArguments(
                httpClient: _httpClient,
                token: ref token,
                projectId: ref projectId,
                tag1Id: ref tag1Id,
                tag2Id: ref tag2Id,
                isParentChildLink: ref isParentChildLink);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/api/v1/tag/addtaglink?projectId={projectId}&tag1Id={tag1Id}&tag2Id={tag2Id}&isParentChildLink={isParentChildLink}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareTagAddTagLinkRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                token: token,
                projectId: projectId,
                tag1Id: tag1Id,
                tag2Id: tag2Id,
                isParentChildLink: isParentChildLink);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessTagAddTagLinkResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessTagAddTagLinkResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize<global::G.TagLink?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}