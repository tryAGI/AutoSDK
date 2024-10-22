//HintName: G.ResourceClient.ResourceUpdateDocumentDataAndExcerpts.g.cs

#nullable enable

namespace G
{
    public partial class ResourceClient
    {
        partial void PrepareResourceUpdateDocumentDataAndExcerptsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? token,
            ref global::System.Guid? projectId,
            ref global::System.Guid? userId,
            ref global::System.Guid? resourceId,
            ref string? updatedTextDataURI,
            ref int? updatedLength,
            global::System.Collections.Generic.IList<global::G.Excerpt>? excerpts);
        partial void PrepareResourceUpdateDocumentDataAndExcerptsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? token,
            global::System.Guid? projectId,
            global::System.Guid? userId,
            global::System.Guid? resourceId,
            string? updatedTextDataURI,
            int? updatedLength,
            global::System.Collections.Generic.IList<global::G.Excerpt>? excerpts);
        partial void ProcessResourceUpdateDocumentDataAndExcerptsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessResourceUpdateDocumentDataAndExcerptsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// UpdateDocumentDataAndExcerpts.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="projectId"></param>
        /// <param name="userId"></param>
        /// <param name="resourceId"></param>
        /// <param name="updatedTextDataURI"></param>
        /// <param name="updatedLength"></param>
        /// <param name="excerpts"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<string> ResourceUpdateDocumentDataAndExcerptsAsync(
            string? token = default,
            global::System.Guid? projectId = default,
            global::System.Guid? userId = default,
            global::System.Guid? resourceId = default,
            string? updatedTextDataURI = default,
            int? updatedLength = default,
            global::System.Collections.Generic.IList<global::G.Excerpt>? excerpts = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareResourceUpdateDocumentDataAndExcerptsArguments(
                httpClient: HttpClient,
                token: ref token,
                projectId: ref projectId,
                userId: ref userId,
                resourceId: ref resourceId,
                updatedTextDataURI: ref updatedTextDataURI,
                updatedLength: ref updatedLength,
                excerpts: excerpts);

            var __pathBuilder = new PathBuilder(
                path: "/api/v1/resource/updatedocumentdataandexcerpts",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("projectId", projectId?.ToString()) 
                .AddOptionalParameter("userId", userId?.ToString()) 
                .AddOptionalParameter("resourceId", resourceId?.ToString()) 
                .AddOptionalParameter("updatedTextDataURI", updatedTextDataURI) 
                .AddOptionalParameter("updatedLength", updatedLength?.ToString()) 
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
            PrepareResourceUpdateDocumentDataAndExcerptsRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                token: token,
                projectId: projectId,
                userId: userId,
                resourceId: resourceId,
                updatedTextDataURI: updatedTextDataURI,
                updatedLength: updatedLength,
                excerpts: excerpts);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessResourceUpdateDocumentDataAndExcerptsResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            var __content = await __response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: HttpClient,
                response: __response,
                content: ref __content);
            ProcessResourceUpdateDocumentDataAndExcerptsResponseContent(
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