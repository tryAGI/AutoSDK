//HintName: G.TagClient.TagUpdateTagLink.g.cs

#nullable enable

namespace G
{
    public partial class TagClient
    {
        partial void PrepareTagUpdateTagLinkArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? token,
            ref string? projectIdKey,
            ref global::System.Guid? projectId,
            ref global::System.Guid? id,
            ref global::System.Guid? projectIDL,
            ref global::System.Guid? tag1IDL,
            ref global::System.Guid? tag2IDL,
            ref bool? isParentChildLink);
        partial void PrepareTagUpdateTagLinkRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? token,
            string? projectIdKey,
            global::System.Guid? projectId,
            global::System.Guid? id,
            global::System.Guid? projectIDL,
            global::System.Guid? tag1IDL,
            global::System.Guid? tag2IDL,
            bool? isParentChildLink);
        partial void ProcessTagUpdateTagLinkResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessTagUpdateTagLinkResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// UpdateTagLink.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="projectIdKey"></param>
        /// <param name="projectId"></param>
        /// <param name="id"></param>
        /// <param name="projectIDL"></param>
        /// <param name="tag1IDL"></param>
        /// <param name="tag2IDL"></param>
        /// <param name="isParentChildLink"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.TagLink> TagUpdateTagLinkAsync(
            string? token = default,
            string? projectIdKey = default,
            global::System.Guid? projectId = default,
            global::System.Guid? id = default,
            global::System.Guid? projectIDL = default,
            global::System.Guid? tag1IDL = default,
            global::System.Guid? tag2IDL = default,
            bool? isParentChildLink = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareTagUpdateTagLinkArguments(
                httpClient: _httpClient,
                token: ref token,
                projectIdKey: ref projectIdKey,
                projectId: ref projectId,
                id: ref id,
                projectIDL: ref projectIDL,
                tag1IDL: ref tag1IDL,
                tag2IDL: ref tag2IDL,
                isParentChildLink: ref isParentChildLink);

            var __pathBuilder = new PathBuilder(
                path: "/api/v1/tag/updatetaglink",
                baseUri: _httpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("ProjectIdKey", projectIdKey) 
                .AddOptionalParameter("ProjectId", projectId?.ToString()) 
                .AddOptionalParameter("Id", id?.ToString()) 
                .AddOptionalParameter("ProjectIDL", projectIDL?.ToString()) 
                .AddOptionalParameter("Tag1IDL", tag1IDL?.ToString()) 
                .AddOptionalParameter("Tag2IDL", tag2IDL?.ToString()) 
                .AddOptionalParameter("IsParentChildLink", isParentChildLink?.ToString()) 
                ; 
            var __path = __pathBuilder.ToString();
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            if (token != default)
            {
                httpRequest.Headers.TryAddWithoutValidation("token", token.ToString());
            }


            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareTagUpdateTagLinkRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                token: token,
                projectIdKey: projectIdKey,
                projectId: projectId,
                id: id,
                projectIDL: projectIDL,
                tag1IDL: tag1IDL,
                tag2IDL: tag2IDL,
                isParentChildLink: isParentChildLink);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessTagUpdateTagLinkResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessTagUpdateTagLinkResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize<global::G.TagLink?>(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}