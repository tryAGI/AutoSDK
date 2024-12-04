//HintName: G.ProjectsClient.UpdateProjectRateLimits.g.cs

#nullable enable

namespace G
{
    public partial class ProjectsClient
    {
        partial void PrepareUpdateProjectRateLimitsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string projectId,
            ref string rateLimitId,
            global::G.ProjectRateLimitUpdateRequest request);
        partial void PrepareUpdateProjectRateLimitsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string projectId,
            string rateLimitId,
            global::G.ProjectRateLimitUpdateRequest request);
        partial void ProcessUpdateProjectRateLimitsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessUpdateProjectRateLimitsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Updates a project rate limit.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="rateLimitId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.ProjectRateLimit> UpdateProjectRateLimitsAsync(
            string projectId,
            string rateLimitId,
            global::G.ProjectRateLimitUpdateRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareUpdateProjectRateLimitsArguments(
                httpClient: HttpClient,
                projectId: ref projectId,
                rateLimitId: ref rateLimitId,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: $"/organization/projects/{projectId}/rate_limits/{rateLimitId}",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in Authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2")
                {
                    __httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: __authorization.Name,
                        parameter: __authorization.Value);
                }
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Header")
                {
                    __httpRequest.Headers.Add(__authorization.Name, __authorization.Value);
                }
            }
            var __httpRequestContentBody = request.ToJson(JsonSerializerContext);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareUpdateProjectRateLimitsRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                projectId: projectId,
                rateLimitId: rateLimitId,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessUpdateProjectRateLimitsResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // Error response for various conditions.
            if ((int)__response.StatusCode == 400)
            {
                string? __content_400 = null;
                global::G.ErrorResponse? __value_400 = null;
                if (ReadResponseAsString)
                {
                    __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    __value_400 = global::G.ErrorResponse.FromJson(__content_400, JsonSerializerContext);
                }
                else
                {
                    var __contentStream_400 = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                    __value_400 = await global::G.ErrorResponse.FromJsonStreamAsync(__contentStream_400, JsonSerializerContext).ConfigureAwait(false);
                }

                throw new global::G.ApiException<global::G.ErrorResponse>(
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

            if (ReadResponseAsString)
            {
                var __content = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                ProcessResponseContent(
                    client: HttpClient,
                    response: __response,
                    content: ref __content);
                ProcessUpdateProjectRateLimitsResponseContent(
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
                    global::G.ProjectRateLimit.FromJson(__content, JsonSerializerContext) ??
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
                    await global::G.ProjectRateLimit.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                    throw new global::System.InvalidOperationException("Response deserialization failed.");
            }
        }

        /// <summary>
        /// Updates a project rate limit.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="rateLimitId"></param>
        /// <param name="maxRequestsPer1Minute">
        /// The maximum requests per minute.
        /// </param>
        /// <param name="maxTokensPer1Minute">
        /// The maximum tokens per minute.
        /// </param>
        /// <param name="maxImagesPer1Minute">
        /// The maximum images per minute. Only relevant for certain models.
        /// </param>
        /// <param name="maxAudioMegabytesPer1Minute">
        /// The maximum audio megabytes per minute. Only relevant for certain models.
        /// </param>
        /// <param name="maxRequestsPer1Day">
        /// The maximum requests per day. Only relevant for certain models.
        /// </param>
        /// <param name="batch1DayMaxInputTokens">
        /// The maximum batch input tokens per day. Only relevant for certain models.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.ProjectRateLimit> UpdateProjectRateLimitsAsync(
            string projectId,
            string rateLimitId,
            int? maxRequestsPer1Minute = default,
            int? maxTokensPer1Minute = default,
            int? maxImagesPer1Minute = default,
            int? maxAudioMegabytesPer1Minute = default,
            int? maxRequestsPer1Day = default,
            int? batch1DayMaxInputTokens = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.ProjectRateLimitUpdateRequest
            {
                MaxRequestsPer1Minute = maxRequestsPer1Minute,
                MaxTokensPer1Minute = maxTokensPer1Minute,
                MaxImagesPer1Minute = maxImagesPer1Minute,
                MaxAudioMegabytesPer1Minute = maxAudioMegabytesPer1Minute,
                MaxRequestsPer1Day = maxRequestsPer1Day,
                Batch1DayMaxInputTokens = batch1DayMaxInputTokens,
            };

            return await UpdateProjectRateLimitsAsync(
                projectId: projectId,
                rateLimitId: rateLimitId,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}