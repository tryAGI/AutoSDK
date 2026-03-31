//HintName: G.MetadataClient.MetadataSendFeedback.g.cs

#nullable enable

namespace G
{
    public partial class MetadataClient
    {
        partial void PrepareMetadataSendFeedbackArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::G.MetadataSendFeedbackRequest request);
        partial void PrepareMetadataSendFeedbackRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::G.MetadataSendFeedbackRequest request);
        partial void ProcessMetadataSendFeedbackResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessMetadataSendFeedbackResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Send user feedback<br/>
        /// Send feedback from users to improve our services.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.MetadataSendFeedbackResponse> MetadataSendFeedbackAsync(

            global::G.MetadataSendFeedbackRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareMetadataSendFeedbackArguments(
                httpClient: HttpClient,
                request: request);

            var __pathBuilder = new global::G.PathBuilder(
                path: "/v1/metadata/feedback",
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
            var __httpRequestContentBody = request.ToJson(JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareMetadataSendFeedbackRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessMetadataSendFeedbackResponse(
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
                ProcessMetadataSendFeedbackResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::G.MetadataSendFeedbackResponse.FromJson(__content, JsonSerializerOptions) ??
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
                        await global::G.MetadataSendFeedbackResponse.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
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
        /// Send user feedback<br/>
        /// Send feedback from users to improve our services.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="feature">
        /// Default Value: letta-code
        /// </param>
        /// <param name="agentId"></param>
        /// <param name="sessionId"></param>
        /// <param name="version"></param>
        /// <param name="platform"></param>
        /// <param name="settings"></param>
        /// <param name="localTime"></param>
        /// <param name="deviceType"></param>
        /// <param name="cwd"></param>
        /// <param name="totalApiMs"></param>
        /// <param name="totalWallMs"></param>
        /// <param name="stepCount"></param>
        /// <param name="promptTokens"></param>
        /// <param name="completionTokens"></param>
        /// <param name="totalTokens"></param>
        /// <param name="cachedInputTokens"></param>
        /// <param name="cacheWriteTokens"></param>
        /// <param name="reasoningTokens"></param>
        /// <param name="contextTokens"></param>
        /// <param name="agentName"></param>
        /// <param name="agentDescription"></param>
        /// <param name="model"></param>
        /// <param name="billingTier"></param>
        /// <param name="recentChunks"></param>
        /// <param name="debugLogTail"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.MetadataSendFeedbackResponse> MetadataSendFeedbackAsync(
            string message,
            global::G.MetadataSendFeedbackRequestFeature? feature = default,
            string? agentId = default,
            string? sessionId = default,
            string? version = default,
            string? platform = default,
            string? settings = default,
            string? localTime = default,
            string? deviceType = default,
            string? cwd = default,
            double? totalApiMs = default,
            double? totalWallMs = default,
            double? stepCount = default,
            double? promptTokens = default,
            double? completionTokens = default,
            double? totalTokens = default,
            double? cachedInputTokens = default,
            double? cacheWriteTokens = default,
            double? reasoningTokens = default,
            double? contextTokens = default,
            string? agentName = default,
            string? agentDescription = default,
            string? model = default,
            string? billingTier = default,
            global::System.Collections.Generic.IList<object>? recentChunks = default,
            string? debugLogTail = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {

            var __request = new global::G.MetadataSendFeedbackRequest
            {
                Message = message,
                Feature = feature,
                AgentId = agentId,
                SessionId = sessionId,
                Version = version,
                Platform = platform,
                Settings = settings,
                LocalTime = localTime,
                DeviceType = deviceType,
                Cwd = cwd,
                TotalApiMs = totalApiMs,
                TotalWallMs = totalWallMs,
                StepCount = stepCount,
                PromptTokens = promptTokens,
                CompletionTokens = completionTokens,
                TotalTokens = totalTokens,
                CachedInputTokens = cachedInputTokens,
                CacheWriteTokens = cacheWriteTokens,
                ReasoningTokens = reasoningTokens,
                ContextTokens = contextTokens,
                AgentName = agentName,
                AgentDescription = agentDescription,
                Model = model,
                BillingTier = billingTier,
                RecentChunks = recentChunks,
                DebugLogTail = debugLogTail,
            };

            return await MetadataSendFeedbackAsync(
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}