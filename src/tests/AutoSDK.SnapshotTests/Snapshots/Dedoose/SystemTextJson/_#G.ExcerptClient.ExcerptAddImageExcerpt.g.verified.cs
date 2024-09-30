//HintName: G.ExcerptClient.ExcerptAddImageExcerpt.g.cs

#nullable enable

namespace G
{
    public partial class ExcerptClient
    {
        partial void PrepareExcerptAddImageExcerptArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? token,
            ref global::System.Guid? projectId,
            ref global::System.Guid? userId,
            ref global::System.Guid? resourceId,
            ref int? start,
            ref int? end,
            global::System.Collections.Generic.IList<global::System.Guid>? tagIdsToApply);
        partial void PrepareExcerptAddImageExcerptRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? token,
            global::System.Guid? projectId,
            global::System.Guid? userId,
            global::System.Guid? resourceId,
            int? start,
            int? end,
            global::System.Collections.Generic.IList<global::System.Guid>? tagIdsToApply);
        partial void ProcessExcerptAddImageExcerptResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessExcerptAddImageExcerptResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// AddImageExcerpt.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="projectId"></param>
        /// <param name="userId"></param>
        /// <param name="resourceId"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="tagIdsToApply"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.ExcerptWithTagApps> ExcerptAddImageExcerptAsync(
            string? token = default,
            global::System.Guid? projectId = default,
            global::System.Guid? userId = default,
            global::System.Guid? resourceId = default,
            int? start = default,
            int? end = default,
            global::System.Collections.Generic.IList<global::System.Guid>? tagIdsToApply = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareExcerptAddImageExcerptArguments(
                httpClient: _httpClient,
                token: ref token,
                projectId: ref projectId,
                userId: ref userId,
                resourceId: ref resourceId,
                start: ref start,
                end: ref end,
                tagIdsToApply: tagIdsToApply);

            var __pathBuilder = new PathBuilder(
                path: "/api/v1/excerpt/addimageexcerpt",
                baseUri: _httpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("projectId", projectId?.ToString()) 
                .AddOptionalParameter("userId", userId?.ToString()) 
                .AddOptionalParameter("resourceId", resourceId?.ToString()) 
                .AddOptionalParameter("start", start?.ToString()) 
                .AddOptionalParameter("end", end?.ToString()) 
                .AddOptionalParameter("tagIdsToApply", tagIdsToApply, selector: static x => x.ToString(), delimiter: ",", explode: true) 
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
            PrepareExcerptAddImageExcerptRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                token: token,
                projectId: projectId,
                userId: userId,
                resourceId: resourceId,
                start: start,
                end: end,
                tagIdsToApply: tagIdsToApply);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessExcerptAddImageExcerptResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessExcerptAddImageExcerptResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize<global::G.ExcerptWithTagApps?>(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}