//HintName: G.PromptTemplatesClient.PromptTemplatesLabelsPromptLabelIdPatch.g.cs

#nullable enable

namespace G
{
    public partial class PromptTemplatesClient
    {
        partial void PreparePromptTemplatesLabelsPromptLabelIdPatchArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref int promptLabelId,
            global::G.PromptTemplatesLabelsPromptLabelIdPatchRequest request);
        partial void PreparePromptTemplatesLabelsPromptLabelIdPatchRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            int promptLabelId,
            global::G.PromptTemplatesLabelsPromptLabelIdPatchRequest request);
        partial void ProcessPromptTemplatesLabelsPromptLabelIdPatchResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessPromptTemplatesLabelsPromptLabelIdPatchResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Move Prompt Template Labels
        /// </summary>
        /// <param name="promptLabelId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.PromptTemplatesLabelsPromptLabelIdPatchResponse> PromptTemplatesLabelsPromptLabelIdPatchAsync(
            int promptLabelId,

            global::G.PromptTemplatesLabelsPromptLabelIdPatchRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PreparePromptTemplatesLabelsPromptLabelIdPatchArguments(
                httpClient: HttpClient,
                promptLabelId: ref promptLabelId,
                request: request);

            var __pathBuilder = new global::G.PathBuilder(
                path: $"/prompt-labels/{promptLabelId}",
                baseUri: HttpClient.BaseAddress);
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: new global::System.Net.Http.HttpMethod("PATCH"),
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif
            var __httpRequestContentBody = request.ToJson(JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PreparePromptTemplatesLabelsPromptLabelIdPatchRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                promptLabelId: promptLabelId,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessPromptTemplatesLabelsPromptLabelIdPatchResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            if (ReadResponseAsString)
            {
                var __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                    cancellationToken
#endif
                ).ConfigureAwait(false);

                ProcessResponseContent(
                    client: HttpClient,
                    response: __response,
                    content: ref __content);
                ProcessPromptTemplatesLabelsPromptLabelIdPatchResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::G.PromptTemplatesLabelsPromptLabelIdPatchResponse.FromJson(__content, JsonSerializerOptions) ??
                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                }
                catch (global::System.Exception __ex)
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
            }
            else
            {
                try
                {
                    __response.EnsureSuccessStatusCode();
                    using var __content = await __response.Content.ReadAsStreamAsync(
#if NET5_0_OR_GREATER
                        cancellationToken
#endif
                    ).ConfigureAwait(false);

                    return
                        await global::G.PromptTemplatesLabelsPromptLabelIdPatchResponse.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                }
                catch (global::System.Exception __ex)
                {
                    string? __content = null;
                    try
                    {
                        __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                            cancellationToken
#endif
                        ).ConfigureAwait(false);
                    }
                    catch (global::System.Exception)
                    {
                    }

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
            }
        }
        /// <summary>
        /// Move Prompt Template Labels
        /// </summary>
        /// <param name="promptLabelId"></param>
        /// <param name="promptVersionNumber"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.PromptTemplatesLabelsPromptLabelIdPatchResponse> PromptTemplatesLabelsPromptLabelIdPatchAsync(
            int promptLabelId,
            int promptVersionNumber,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.PromptTemplatesLabelsPromptLabelIdPatchRequest
            {
                PromptVersionNumber = promptVersionNumber,
            };

            return await PromptTemplatesLabelsPromptLabelIdPatchAsync(
                promptLabelId: promptLabelId,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}