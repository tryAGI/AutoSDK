//HintName: G.TagClient.TagAddExcerptTagApplications.g.cs

#nullable enable

namespace G
{
    public partial class TagClient
    {
        partial void PrepareTagAddExcerptTagApplicationsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? token,
            ref global::System.Guid? userId,
            ref global::System.Guid? projectId,
            ref global::System.Guid? resourceId,
            ref global::System.Guid? excerptId,
            global::System.Collections.Generic.IList<global::G.TagAppSimple>? tagApps);
        partial void PrepareTagAddExcerptTagApplicationsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? token,
            global::System.Guid? userId,
            global::System.Guid? projectId,
            global::System.Guid? resourceId,
            global::System.Guid? excerptId,
            global::System.Collections.Generic.IList<global::G.TagAppSimple>? tagApps);
        partial void ProcessTagAddExcerptTagApplicationsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessTagAddExcerptTagApplicationsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// AddExcerptTagApplications.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="userId"></param>
        /// <param name="projectId"></param>
        /// <param name="resourceId"></param>
        /// <param name="excerptId"></param>
        /// <param name="tagApps"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<string> TagAddExcerptTagApplicationsAsync(
            string? token = default,
            global::System.Guid? userId = default,
            global::System.Guid? projectId = default,
            global::System.Guid? resourceId = default,
            global::System.Guid? excerptId = default,
            global::System.Collections.Generic.IList<global::G.TagAppSimple>? tagApps = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareTagAddExcerptTagApplicationsArguments(
                httpClient: HttpClient,
                token: ref token,
                userId: ref userId,
                projectId: ref projectId,
                resourceId: ref resourceId,
                excerptId: ref excerptId,
                tagApps: tagApps);

            var __pathBuilder = new PathBuilder(
                path: "/api/v1/tag/addexcerpttagapplications",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("userId", userId?.ToString()) 
                .AddOptionalParameter("projectId", projectId?.ToString()) 
                .AddOptionalParameter("resourceId", resourceId?.ToString()) 
                .AddOptionalParameter("excerptId", excerptId?.ToString()) 
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
            PrepareTagAddExcerptTagApplicationsRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                token: token,
                userId: userId,
                projectId: projectId,
                resourceId: resourceId,
                excerptId: excerptId,
                tagApps: tagApps);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessTagAddExcerptTagApplicationsResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            var __content = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: HttpClient,
                response: __response,
                content: ref __content);
            ProcessTagAddExcerptTagApplicationsResponseContent(
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

            return __content;
        }
    }
}