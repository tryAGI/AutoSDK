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
        public async global::System.Threading.Tasks.Task<global::G.ResourceUpdateDocumentDataAndExcerptsResponse> ResourceUpdateDocumentDataAndExcerptsAsync(
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
                client: _httpClient);
            PrepareResourceUpdateDocumentDataAndExcerptsArguments(
                httpClient: _httpClient,
                token: ref token,
                projectId: ref projectId,
                userId: ref userId,
                resourceId: ref resourceId,
                updatedTextDataURI: ref updatedTextDataURI,
                updatedLength: ref updatedLength,
                excerpts: excerpts);

            var __pathBuilder = new PathBuilder(
                path: "/api/v1/resource/updatedocumentdataandexcerpts",
                baseUri: _httpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("projectId", projectId?.ToString()) 
                .AddOptionalParameter("userId", userId?.ToString()) 
                .AddOptionalParameter("resourceId", resourceId?.ToString()) 
                .AddOptionalParameter("updatedTextDataURI", updatedTextDataURI) 
                .AddOptionalParameter("updatedLength", updatedLength?.ToString()) 
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
            PrepareResourceUpdateDocumentDataAndExcerptsRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                token: token,
                projectId: projectId,
                userId: userId,
                resourceId: resourceId,
                updatedTextDataURI: updatedTextDataURI,
                updatedLength: updatedLength,
                excerpts: excerpts);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessResourceUpdateDocumentDataAndExcerptsResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessResourceUpdateDocumentDataAndExcerptsResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize<global::G.ResourceUpdateDocumentDataAndExcerptsResponse?>(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}