//HintName: G.TagClient.TagAddExcerptTagApplication.g.cs

#nullable enable

namespace G
{
    public partial class TagClient
    {
        partial void PrepareTagAddExcerptTagApplicationArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? token,
            ref global::System.Guid? userId,
            ref global::System.Guid? projectId,
            ref global::System.Guid? resourceId,
            ref global::System.Guid? excerptId,
            ref global::System.Guid? tagId,
            ref double? weight);
        partial void PrepareTagAddExcerptTagApplicationRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? token,
            global::System.Guid? userId,
            global::System.Guid? projectId,
            global::System.Guid? resourceId,
            global::System.Guid? excerptId,
            global::System.Guid? tagId,
            double? weight);
        partial void ProcessTagAddExcerptTagApplicationResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessTagAddExcerptTagApplicationResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// AddExcerptTagApplication.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="userId"></param>
        /// <param name="projectId"></param>
        /// <param name="resourceId"></param>
        /// <param name="excerptId"></param>
        /// <param name="tagId"></param>
        /// <param name="weight"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.TagAppDTO> TagAddExcerptTagApplicationAsync(
            string? token = default,
            global::System.Guid? userId = default,
            global::System.Guid? projectId = default,
            global::System.Guid? resourceId = default,
            global::System.Guid? excerptId = default,
            global::System.Guid? tagId = default,
            double? weight = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareTagAddExcerptTagApplicationArguments(
                httpClient: _httpClient,
                token: ref token,
                userId: ref userId,
                projectId: ref projectId,
                resourceId: ref resourceId,
                excerptId: ref excerptId,
                tagId: ref tagId,
                weight: ref weight);

            var __pathBuilder = new PathBuilder(
                path: "/api/v1/tag/addexcerpttagapplication",
                baseUri: _httpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("userId", userId?.ToString()) 
                .AddOptionalParameter("projectId", projectId?.ToString()) 
                .AddOptionalParameter("resourceId", resourceId?.ToString()) 
                .AddOptionalParameter("excerptId", excerptId?.ToString()) 
                .AddOptionalParameter("tagId", tagId?.ToString()) 
                .AddOptionalParameter("weight", weight?.ToString()) 
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
            PrepareTagAddExcerptTagApplicationRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                token: token,
                userId: userId,
                projectId: projectId,
                resourceId: resourceId,
                excerptId: excerptId,
                tagId: tagId,
                weight: weight);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessTagAddExcerptTagApplicationResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessTagAddExcerptTagApplicationResponseContent(
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
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.TagAppDTO?>(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}