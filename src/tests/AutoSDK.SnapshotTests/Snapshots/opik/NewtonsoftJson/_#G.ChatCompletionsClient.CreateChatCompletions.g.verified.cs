//HintName: G.ChatCompletionsClient.CreateChatCompletions.g.cs

#nullable enable

namespace G
{
    public partial class ChatCompletionsClient
    {
        partial void PrepareCreateChatCompletionsArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::G.ChatCompletionRequest request);
        partial void PrepareCreateChatCompletionsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::G.ChatCompletionRequest request);
        partial void ProcessCreateChatCompletionsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateChatCompletionsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create chat completions<br/>
        /// Create chat completions
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.ChatCompletionResponse> CreateChatCompletionsAsync(

            global::G.ChatCompletionRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));


            request = new global::G.ChatCompletionRequest
            {
                Model = request.Model,
                Messages = request.Messages,
                Temperature = request.Temperature,
                TopP = request.TopP,
                N = request.N,
                Stream = false,
                StreamOptions = request.StreamOptions,
                Stop = request.Stop,
                MaxTokens = request.MaxTokens,
                MaxCompletionTokens = request.MaxCompletionTokens,
                PresencePenalty = request.PresencePenalty,
                FrequencyPenalty = request.FrequencyPenalty,
                LogitBias = request.LogitBias,
                User = request.User,
                ResponseFormat = request.ResponseFormat,
                Seed = request.Seed,
                Tools = request.Tools,
                ToolChoice = request.ToolChoice,
                ParallelToolCalls = request.ParallelToolCalls,
                Store = request.Store,
                Metadata = request.Metadata,
                ReasoningEffort = request.ReasoningEffort,
                ServiceTier = request.ServiceTier,
                Functions = request.Functions,
                FunctionCall = request.FunctionCall,
            };
            PrepareArguments(
                client: HttpClient);
            PrepareCreateChatCompletionsArguments(
                httpClient: HttpClient,
                request: request);

            var __pathBuilder = new global::G.PathBuilder(
                path: "/v1/private/chat/completions",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
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
            PrepareCreateChatCompletionsRequest(
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
            ProcessCreateChatCompletionsResponse(
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
                ProcessCreateChatCompletionsResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::G.ChatCompletionResponse.FromJson(__content, JsonSerializerOptions) ??
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
                        await global::G.ChatCompletionResponse.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
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
        /// Create chat completions<br/>
        /// Create chat completions
        /// </summary>
        /// <param name="model"></param>
        /// <param name="messages"></param>
        /// <param name="temperature"></param>
        /// <param name="topP"></param>
        /// <param name="n"></param>
        /// <param name="streamOptions"></param>
        /// <param name="stop"></param>
        /// <param name="maxTokens"></param>
        /// <param name="maxCompletionTokens"></param>
        /// <param name="presencePenalty"></param>
        /// <param name="frequencyPenalty"></param>
        /// <param name="logitBias"></param>
        /// <param name="user"></param>
        /// <param name="responseFormat"></param>
        /// <param name="seed"></param>
        /// <param name="tools"></param>
        /// <param name="toolChoice"></param>
        /// <param name="parallelToolCalls"></param>
        /// <param name="store"></param>
        /// <param name="metadata"></param>
        /// <param name="reasoningEffort"></param>
        /// <param name="serviceTier"></param>
        /// <param name="functions"></param>
        /// <param name="functionCall"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.ChatCompletionResponse> CreateChatCompletionsAsync(
            string? model = default,
            global::System.Collections.Generic.IList<global::G.Message>? messages = default,
            double? temperature = default,
            double? topP = default,
            int? n = default,
            global::G.StreamOptions? streamOptions = default,
            global::System.Collections.Generic.IList<string>? stop = default,
            int? maxTokens = default,
            int? maxCompletionTokens = default,
            double? presencePenalty = default,
            double? frequencyPenalty = default,
            global::System.Collections.Generic.Dictionary<string, int>? logitBias = default,
            string? user = default,
            global::G.ResponseFormat? responseFormat = default,
            int? seed = default,
            global::System.Collections.Generic.IList<global::G.Tool>? tools = default,
            object? toolChoice = default,
            bool? parallelToolCalls = default,
            bool? store = default,
            global::System.Collections.Generic.Dictionary<string, string>? metadata = default,
            string? reasoningEffort = default,
            string? serviceTier = default,
            global::System.Collections.Generic.IList<global::G.Function>? functions = default,
            global::G.FunctionCall? functionCall = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {

            var __request = new global::G.ChatCompletionRequest
            {
                Model = model,
                Messages = messages,
                Temperature = temperature,
                TopP = topP,
                N = n,
                Stream = false,
                StreamOptions = streamOptions,
                Stop = stop,
                MaxTokens = maxTokens,
                MaxCompletionTokens = maxCompletionTokens,
                PresencePenalty = presencePenalty,
                FrequencyPenalty = frequencyPenalty,
                LogitBias = logitBias,
                User = user,
                ResponseFormat = responseFormat,
                Seed = seed,
                Tools = tools,
                ToolChoice = toolChoice,
                ParallelToolCalls = parallelToolCalls,
                Store = store,
                Metadata = metadata,
                ReasoningEffort = reasoningEffort,
                ServiceTier = serviceTier,
                Functions = functions,
                FunctionCall = functionCall,
            };

            return await CreateChatCompletionsAsync(
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}