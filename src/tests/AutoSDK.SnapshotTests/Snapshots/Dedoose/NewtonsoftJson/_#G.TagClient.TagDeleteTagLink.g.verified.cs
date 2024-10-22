//HintName: G.TagClient.TagDeleteTagLink.g.cs

#nullable enable

namespace G
{
    public partial class TagClient
    {
        partial void PrepareTagDeleteTagLinkArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? token,
            ref global::System.Guid? currentProjectId,
            ref string? projectIdKey,
            ref global::System.Guid? projectId,
            ref global::System.Guid? id,
            ref global::System.Guid? projectIDL,
            ref global::System.Guid? tag1IDL,
            ref global::System.Guid? tag2IDL,
            ref bool? isParentChildLink);
        partial void PrepareTagDeleteTagLinkRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? token,
            global::System.Guid? currentProjectId,
            string? projectIdKey,
            global::System.Guid? projectId,
            global::System.Guid? id,
            global::System.Guid? projectIDL,
            global::System.Guid? tag1IDL,
            global::System.Guid? tag2IDL,
            bool? isParentChildLink);
        partial void ProcessTagDeleteTagLinkResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessTagDeleteTagLinkResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// DeleteTagLink.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="currentProjectId"></param>
        /// <param name="projectIdKey"></param>
        /// <param name="projectId"></param>
        /// <param name="id"></param>
        /// <param name="projectIDL"></param>
        /// <param name="tag1IDL"></param>
        /// <param name="tag2IDL"></param>
        /// <param name="isParentChildLink"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.TagLink> TagDeleteTagLinkAsync(
            string? token = default,
            global::System.Guid? currentProjectId = default,
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
                client: HttpClient);
            PrepareTagDeleteTagLinkArguments(
                httpClient: HttpClient,
                token: ref token,
                currentProjectId: ref currentProjectId,
                projectIdKey: ref projectIdKey,
                projectId: ref projectId,
                id: ref id,
                projectIDL: ref projectIDL,
                tag1IDL: ref tag1IDL,
                tag2IDL: ref tag2IDL,
                isParentChildLink: ref isParentChildLink);

            var __pathBuilder = new PathBuilder(
                path: "/api/v1/tag/deletetaglink",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("currentProjectId", currentProjectId?.ToString()) 
                .AddOptionalParameter("ProjectIdKey", projectIdKey) 
                .AddOptionalParameter("ProjectId", projectId?.ToString()) 
                .AddOptionalParameter("Id", id?.ToString()) 
                .AddOptionalParameter("ProjectIDL", projectIDL?.ToString()) 
                .AddOptionalParameter("Tag1IDL", tag1IDL?.ToString()) 
                .AddOptionalParameter("Tag2IDL", tag2IDL?.ToString()) 
                .AddOptionalParameter("IsParentChildLink", isParentChildLink?.ToString()) 
                ; 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            if (token != default)
            {
                __httpRequest.Headers.TryAddWithoutValidation("token", token.ToString());
            }


            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareTagDeleteTagLinkRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                token: token,
                currentProjectId: currentProjectId,
                projectIdKey: projectIdKey,
                projectId: projectId,
                id: id,
                projectIDL: projectIDL,
                tag1IDL: tag1IDL,
                tag2IDL: tag2IDL,
                isParentChildLink: isParentChildLink);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessTagDeleteTagLinkResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            var __content = await __response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: HttpClient,
                response: __response,
                content: ref __content);
            ProcessTagDeleteTagLinkResponseContent(
                httpClient: HttpClient,
                httpResponseMessage: __response,
                content: ref __content);

            try
            {
                __response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException __ex)
            {
                throw new global::System.InvalidOperationException(__content, __ex);
            }

            return
                global::G.TagLink.FromJson(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}