//HintName: G.PromptsClient.UpdatePromptLog.g.cs

#nullable enable

namespace G
{
    public partial class PromptsClient
    {
        partial void PrepareUpdatePromptLogArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string id,
            ref string logId,
            global::G.PromptLogRequest request);
        partial void PrepareUpdatePromptLogRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string id,
            string logId,
            global::G.PromptLogRequest request);
        partial void ProcessUpdatePromptLogResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessUpdatePromptLogResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Update Prompt Log
        /// </summary>
        /// <param name="id"></param>
        /// <param name="logId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.CreatePromptLogResponse> UpdatePromptLogAsync(
            string id,
            string logId,

            global::G.PromptLogRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareUpdatePromptLogArguments(
                httpClient: HttpClient,
                id: ref id,
                logId: ref logId,
                request: request);

            var __pathBuilder = new global::G.PathBuilder(
                path: $"/prompts/{id}/log/{logId}",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: new global::System.Net.Http.HttpMethod("PATCH"),
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
            PrepareUpdatePromptLogRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                id: id,
                logId: logId,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessUpdatePromptLogResponse(
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
                ProcessUpdatePromptLogResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::G.CreatePromptLogResponse.FromJson(__content, JsonSerializerOptions) ??
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
                        await global::G.CreatePromptLogResponse.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
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
        /// Update Prompt Log
        /// </summary>
        /// <param name="id"></param>
        /// <param name="logId"></param>
        /// <param name="versionId"></param>
        /// <param name="environment"></param>
        /// <param name="runId">
        /// Unique identifier for the Run.
        /// </param>
        /// <param name="path"></param>
        /// <param name="requestId"></param>
        /// <param name="outputMessage"></param>
        /// <param name="promptTokens"></param>
        /// <param name="reasoningTokens"></param>
        /// <param name="outputTokens"></param>
        /// <param name="promptCost"></param>
        /// <param name="outputCost"></param>
        /// <param name="finishReason"></param>
        /// <param name="messages"></param>
        /// <param name="prompt">
        /// Request to create or update a Prompt.
        /// </param>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// <param name="output"></param>
        /// <param name="createdAt"></param>
        /// <param name="error"></param>
        /// <param name="providerLatency"></param>
        /// <param name="inputs"></param>
        /// <param name="source"></param>
        /// <param name="metadata"></param>
        /// <param name="sourceDatapointId"></param>
        /// <param name="traceParentId"></param>
        /// <param name="user"></param>
        /// <param name="save"></param>
        /// <param name="requestLogId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.CreatePromptLogResponse> UpdatePromptLogAsync(
            string id,
            string logId,
            string? versionId = default,
            string? environment = default,
            string? runId = default,
            string? path = default,
            string? requestId = default,
            global::G.ChatMessage? outputMessage = default,
            int? promptTokens = default,
            int? reasoningTokens = default,
            int? outputTokens = default,
            double? promptCost = default,
            double? outputCost = default,
            string? finishReason = default,
            global::System.Collections.Generic.IList<global::G.ChatMessage>? messages = default,
            global::G.PromptRequest? prompt = default,
            global::System.DateTime? startTime = default,
            global::System.DateTime? endTime = default,
            string? output = default,
            global::System.DateTime? createdAt = default,
            string? error = default,
            double? providerLatency = default,
            object? inputs = default,
            string? source = default,
            object? metadata = default,
            string? sourceDatapointId = default,
            string? traceParentId = default,
            string? user = default,
            bool? save = default,
            string? requestLogId = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.PromptLogRequest
            {
                VersionId = versionId,
                Environment = environment,
                RunId = runId,
                Path = path,
                Id = requestId,
                OutputMessage = outputMessage,
                PromptTokens = promptTokens,
                ReasoningTokens = reasoningTokens,
                OutputTokens = outputTokens,
                PromptCost = promptCost,
                OutputCost = outputCost,
                FinishReason = finishReason,
                Messages = messages,
                Prompt = prompt,
                StartTime = startTime,
                EndTime = endTime,
                Output = output,
                CreatedAt = createdAt,
                Error = error,
                ProviderLatency = providerLatency,
                Inputs = inputs,
                Source = source,
                Metadata = metadata,
                SourceDatapointId = sourceDatapointId,
                TraceParentId = traceParentId,
                User = user,
                Save = save,
                LogId = requestLogId,
            };

            return await UpdatePromptLogAsync(
                id: id,
                logId: logId,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}