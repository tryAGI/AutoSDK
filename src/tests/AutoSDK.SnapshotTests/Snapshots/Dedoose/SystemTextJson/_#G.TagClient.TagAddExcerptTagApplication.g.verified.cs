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
        /// <exception cref="global::G.ApiException"></exception>
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
                client: HttpClient);
            PrepareTagAddExcerptTagApplicationArguments(
                httpClient: HttpClient,
                token: ref token,
                userId: ref userId,
                projectId: ref projectId,
                resourceId: ref resourceId,
                excerptId: ref excerptId,
                tagId: ref tagId,
                weight: ref weight);

            var __pathBuilder = new PathBuilder(
                path: "/api/v1/tag/addexcerpttagapplication",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("userId", userId?.ToString()) 
                .AddOptionalParameter("projectId", projectId?.ToString()) 
                .AddOptionalParameter("resourceId", resourceId?.ToString()) 
                .AddOptionalParameter("excerptId", excerptId?.ToString()) 
                .AddOptionalParameter("tagId", tagId?.ToString()) 
                .AddOptionalParameter("weight", weight?.ToString()) 
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
            PrepareTagAddExcerptTagApplicationRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                token: token,
                userId: userId,
                projectId: projectId,
                resourceId: resourceId,
                excerptId: excerptId,
                tagId: tagId,
                weight: weight);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessTagAddExcerptTagApplicationResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // Token is null.
            if ((int)__response.StatusCode == 400)
            {
                string? __content_400 = null;
                string? __value_400 = null;
                if (ReadResponseAsString)
                {
                    __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    __value_400 = global::System.Text.Json.JsonSerializer.Deserialize<string?>(__content_400, JsonSerializerOptions);
                }
                else
                {
                    var __contentStream_400 = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                    __value_400 = await global::System.Text.Json.JsonSerializer.DeserializeAsync<string?>(__contentStream_400, JsonSerializerOptions).ConfigureAwait(false);
                }

                throw new global::G.ApiException<string>(
                    message: __response.ReasonPhrase ?? string.Empty,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_400,
                    ResponseObject = __value_400,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // Token is invalid.
            if ((int)__response.StatusCode == 401)
            {
                string? __content_401 = null;
                string? __value_401 = null;
                if (ReadResponseAsString)
                {
                    __content_401 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    __value_401 = global::System.Text.Json.JsonSerializer.Deserialize<string?>(__content_401, JsonSerializerOptions);
                }
                else
                {
                    var __contentStream_401 = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                    __value_401 = await global::System.Text.Json.JsonSerializer.DeserializeAsync<string?>(__contentStream_401, JsonSerializerOptions).ConfigureAwait(false);
                }

                throw new global::G.ApiException<string>(
                    message: __response.ReasonPhrase ?? string.Empty,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_401,
                    ResponseObject = __value_401,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }

            if (ReadResponseAsString)
            {
                var __content = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                ProcessResponseContent(
                    client: HttpClient,
                    response: __response,
                    content: ref __content);
                ProcessTagAddExcerptTagApplicationResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();
                }
                catch (global::System.Net.Http.HttpRequestException __ex)
                {
                    throw new global::G.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }

                return
                    global::G.TagAppDTO.FromJson(__content, JsonSerializerOptions) ??
                    throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
            }
            else
            {
                try
                {
                    __response.EnsureSuccessStatusCode();
                }
                catch (global::System.Net.Http.HttpRequestException __ex)
                {
                    throw new global::G.ApiException(
                        message: __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }

                using var __content = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);

                return
                    await global::G.TagAppDTO.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
                    throw new global::System.InvalidOperationException("Response deserialization failed.");
            }
        }
    }
}