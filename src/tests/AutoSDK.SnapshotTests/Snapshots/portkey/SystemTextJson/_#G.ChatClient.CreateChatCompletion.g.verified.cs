//HintName: G.ChatClient.CreateChatCompletion.g.cs

#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace G
{
    public partial class ChatClient
    {
        partial void PrepareCreateChatCompletionArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? xPortkeyTraceId,
            ref string? xPortkeySpanId,
            ref string? xPortkeyParentSpanId,
            ref string? xPortkeySpanName,
            object? xPortkeyMetadata,
            ref string? xPortkeyCacheNamespace,
            ref bool? xPortkeyCacheForceRefresh,
            global::G.CreateChatCompletionRequest request);
        partial void PrepareCreateChatCompletionRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? xPortkeyTraceId,
            string? xPortkeySpanId,
            string? xPortkeyParentSpanId,
            string? xPortkeySpanName,
            object? xPortkeyMetadata,
            string? xPortkeyCacheNamespace,
            bool? xPortkeyCacheForceRefresh,
            global::G.CreateChatCompletionRequest request);
        partial void ProcessCreateChatCompletionResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateChatCompletionResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Chat
        /// </summary>
        /// <param name="xPortkeyTraceId"></param>
        /// <param name="xPortkeySpanId"></param>
        /// <param name="xPortkeyParentSpanId"></param>
        /// <param name="xPortkeySpanName"></param>
        /// <param name="xPortkeyMetadata"></param>
        /// <param name="xPortkeyCacheNamespace"></param>
        /// <param name="xPortkeyCacheForceRefresh"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.CreateChatCompletionResponse> CreateChatCompletionAsync(

            global::G.CreateChatCompletionRequest request,
            string? xPortkeyTraceId = default,
            string? xPortkeySpanId = default,
            string? xPortkeyParentSpanId = default,
            string? xPortkeySpanName = default,
            object? xPortkeyMetadata = default,
            string? xPortkeyCacheNamespace = default,
            bool? xPortkeyCacheForceRefresh = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareCreateChatCompletionArguments(
                httpClient: HttpClient,
                xPortkeyTraceId: ref xPortkeyTraceId,
                xPortkeySpanId: ref xPortkeySpanId,
                xPortkeyParentSpanId: ref xPortkeyParentSpanId,
                xPortkeySpanName: ref xPortkeySpanName,
                xPortkeyMetadata: xPortkeyMetadata,
                xPortkeyCacheNamespace: ref xPortkeyCacheNamespace,
                xPortkeyCacheForceRefresh: ref xPortkeyCacheForceRefresh,
                request: request);

            var __pathBuilder = new global::G.PathBuilder(
                path: "/chat/completions",
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

            if (xPortkeyTraceId != default)
            {
                __httpRequest.Headers.TryAddWithoutValidation("x-portkey-trace-id", xPortkeyTraceId.ToString());
            }
            if (xPortkeySpanId != default)
            {
                __httpRequest.Headers.TryAddWithoutValidation("x-portkey-span-id", xPortkeySpanId.ToString());
            }
            if (xPortkeyParentSpanId != default)
            {
                __httpRequest.Headers.TryAddWithoutValidation("x-portkey-parent-span-id", xPortkeyParentSpanId.ToString());
            }
            if (xPortkeySpanName != default)
            {
                __httpRequest.Headers.TryAddWithoutValidation("x-portkey-span-name", xPortkeySpanName.ToString());
            }
            if (xPortkeyMetadata != default)
            {
                __httpRequest.Headers.TryAddWithoutValidation("x-portkey-metadata", xPortkeyMetadata.ToString());
            }
            if (xPortkeyCacheNamespace != default)
            {
                __httpRequest.Headers.TryAddWithoutValidation("x-portkey-cache-namespace", xPortkeyCacheNamespace.ToString());
            }
            if (xPortkeyCacheForceRefresh != default)
            {
                __httpRequest.Headers.TryAddWithoutValidation("x-portkey-cache-force-refresh", xPortkeyCacheForceRefresh.ToString());
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
            PrepareCreateChatCompletionRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                xPortkeyTraceId: xPortkeyTraceId,
                xPortkeySpanId: xPortkeySpanId,
                xPortkeyParentSpanId: xPortkeyParentSpanId,
                xPortkeySpanName: xPortkeySpanName,
                xPortkeyMetadata: xPortkeyMetadata,
                xPortkeyCacheNamespace: xPortkeyCacheNamespace,
                xPortkeyCacheForceRefresh: xPortkeyCacheForceRefresh,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessCreateChatCompletionResponse(
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
                ProcessCreateChatCompletionResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::G.CreateChatCompletionResponse.FromJson(__content, JsonSerializerOptions) ??
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
                        await global::G.CreateChatCompletionResponse.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
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
        /// Chat
        /// </summary>
        /// <param name="xPortkeyTraceId"></param>
        /// <param name="xPortkeySpanId"></param>
        /// <param name="xPortkeyParentSpanId"></param>
        /// <param name="xPortkeySpanName"></param>
        /// <param name="xPortkeyMetadata"></param>
        /// <param name="xPortkeyCacheNamespace"></param>
        /// <param name="xPortkeyCacheForceRefresh"></param>
        /// <param name="messages">
        /// A list of messages comprising the conversation so far. [Example Python code](https://cookbook.openai.com/examples/how_to_format_inputs_to_chatgpt_models).
        /// </param>
        /// <param name="model">
        /// ID of the model to use. See the [model endpoint compatibility](https://platform.openai.com/docs/models/model-endpoint-compatibility) table for details on which models work with the Chat API.<br/>
        /// Example: gpt-5
        /// </param>
        /// <param name="frequencyPenalty">
        /// Number between -2.0 and 2.0. Positive values penalize new tokens based on their existing frequency in the text so far, decreasing the model's likelihood to repeat the same line verbatim.<br/>
        /// [See more information about frequency and presence penalties.](https://platform.openai.com/docs/guides/text-generation/parameter-details)<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="logitBias">
        /// Modify the likelihood of specified tokens appearing in the completion.<br/>
        /// Accepts a JSON object that maps tokens (specified by their token ID in the tokenizer) to an associated bias value from -100 to 100. Mathematically, the bias is added to the logits generated by the model prior to sampling. The exact effect will vary per model, but values between -1 and 1 should decrease or increase likelihood of selection; values like -100 or 100 should result in a ban or exclusive selection of the relevant token.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="logprobs">
        /// Whether to return log probabilities of the output tokens or not. If true, returns the log probabilities of each output token returned in the `content` of `message`.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="topLogprobs">
        /// An integer between 0 and 20 specifying the number of most likely tokens to return at each token position, each with an associated log probability. `logprobs` must be set to `true` if this parameter is used.
        /// </param>
        /// <param name="maxCompletionTokens">
        /// An upper bound for the number of tokens that can be generated for a completion, including visible output tokens and [reasoning tokens](https://platform.openai.com/docs/guides/reasoning).<br/>
        /// **Supported models:** GPT-5 series, o-series reasoning models (o1, o3, o3-mini, o4-mini) — required. Also supported on GPT-4o, GPT-4o-mini, GPT-4, GPT-4 Turbo, GPT-3.5 Turbo as a replacement for `max_tokens`.
        /// </param>
        /// <param name="n">
        /// How many chat completion choices to generate for each input message. Note that you will be charged based on the number of generated tokens across all of the choices. Keep `n` as `1` to minimize costs.<br/>
        /// Default Value: 1<br/>
        /// Example: 1
        /// </param>
        /// <param name="presencePenalty">
        /// Number between -2.0 and 2.0. Positive values penalize new tokens based on whether they appear in the text so far, increasing the model's likelihood to talk about new topics.<br/>
        /// [See more information about frequency and presence penalties.](https://platform.openai.com/docs/guides/text-generation/parameter-details)<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="responseFormat">
        /// An object specifying the format that the model must output.<br/>
        /// Setting to `{ "type": "json_schema", "json_schema": {...} }`enables Structured Outputs which ensures the model will match your<br/>
        /// supplied JSON schema. Works across all the providers that support this functionality. [OpenAI &amp; Azure OpenAI](/integrations/llms/openai/structured-outputs), [Gemini &amp; Vertex AI](/integrations/llms/vertex-ai/controlled-generations).<br/>
        /// Setting to `{ "type": "json_object" }` enables the older JSON mode, which ensures the message the model generates is valid JSON.<br/>
        /// Using `json_schema` is preferred for models that support it.
        /// </param>
        /// <param name="seed">
        /// This feature is in Beta.<br/>
        /// If specified, our system will make a best effort to sample deterministically, such that repeated requests with the same `seed` and parameters should return the same result.<br/>
        /// Determinism is not guaranteed, and you should refer to the `system_fingerprint` response parameter to monitor changes in the backend.
        /// </param>
        /// <param name="stop">
        /// Up to 4 sequences where the API will stop generating further tokens.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="stream">
        /// If set, partial message deltas will be sent, like in ChatGPT. Tokens will be sent as data-only [server-sent events](https://developer.mozilla.org/en-UShttps://platform.openai.com/docs/Web/API/Server-sent_events/Using_server-sent_events#Event_stream_format) as they become available, with the stream terminated by a `data: [DONE]` message. [Example Python code](https://cookbook.openai.com/examples/how_to_stream_completions).<br/>
        /// Default Value: false
        /// </param>
        /// <param name="streamOptions">
        /// Options for streaming response. Only set this when you set `stream: true`.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="thinking">
        /// View the thinking/reasoning tokens as part of your response. Thinking models produce a long internal chain of thought before generating a response. Supported only for specific Claude models on Anthropic, Google Vertex AI, and AWS Bedrock.  Requires setting `strict_openai_compliance = false` in your API call.<br/>
        /// Example: {"type":"enabled","budget_tokens":2030}
        /// </param>
        /// <param name="temperature">
        /// What sampling temperature to use, between 0 and 2. Higher values like 0.8 will make the output more random, while lower values like 0.2 will make it more focused and deterministic.<br/>
        /// We generally recommend altering this or `top_p` but not both.<br/>
        /// Default Value: 1<br/>
        /// Example: 1
        /// </param>
        /// <param name="topP">
        /// An alternative to sampling with temperature, called nucleus sampling, where the model considers the results of the tokens with top_p probability mass. So 0.1 means only the tokens comprising the top 10% probability mass are considered.<br/>
        /// We generally recommend altering this or `temperature` but not both.<br/>
        /// Default Value: 1<br/>
        /// Example: 1
        /// </param>
        /// <param name="tools">
        /// A list of tools the model may call. Currently, only functions are supported as a tool. Use this to provide a list of functions the model may generate JSON inputs for. A max of 128 functions are supported.
        /// </param>
        /// <param name="toolChoice">
        /// Controls which (if any) tool is called by the model.<br/>
        /// `none` means the model will not call any tool and instead generates a message.<br/>
        /// `auto` means the model can pick between generating a message or calling one or more tools.<br/>
        /// `required` means the model must call one or more tools.<br/>
        /// Specifying a particular tool via `{"type": "function", "function": {"name": "my_function"}}` forces the model to call that tool.<br/>
        /// `none` is the default when no tools are present. `auto` is the default if tools are present.
        /// </param>
        /// <param name="parallelToolCalls">
        /// Whether to enable [parallel function calling](https://platform.openai.com/docs/guides/function-calling/parallel-function-calling) during tool use.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="user">
        /// A unique identifier representing your end-user, which can help OpenAI to monitor and detect abuse. [Learn more](https://platform.openai.com/docs/guides/safety-best-practices/end-user-ids).<br/>
        /// Example: user-1234
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.CreateChatCompletionResponse> CreateChatCompletionAsync(
            global::System.Collections.Generic.IList<global::G.ChatCompletionRequestMessage> messages,
            global::G.AnyOf<string, global::G.CreateChatCompletionRequestModel?> model,
            string? xPortkeyTraceId = default,
            string? xPortkeySpanId = default,
            string? xPortkeyParentSpanId = default,
            string? xPortkeySpanName = default,
            object? xPortkeyMetadata = default,
            string? xPortkeyCacheNamespace = default,
            bool? xPortkeyCacheForceRefresh = default,
            double? frequencyPenalty = default,
            global::System.Collections.Generic.Dictionary<string, int>? logitBias = default,
            bool? logprobs = default,
            int? topLogprobs = default,
            int? maxCompletionTokens = default,
            int? n = default,
            double? presencePenalty = default,
            global::G.OneOf<global::G.ResponseFormatText, global::G.ResponseFormatJsonSchema, global::G.ResponseFormatJsonObject>? responseFormat = default,
            long? seed = default,
            global::G.OneOf<string, global::System.Collections.Generic.IList<string>>? stop = default,
            bool? stream = default,
            global::G.ChatCompletionStreamOptions? streamOptions = default,
            global::G.CreateChatCompletionRequestThinking? thinking = default,
            double? temperature = default,
            double? topP = default,
            global::System.Collections.Generic.IList<global::G.ChatCompletionTool>? tools = default,
            global::G.ChatCompletionToolChoiceOption? toolChoice = default,
            bool? parallelToolCalls = default,
            string? user = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.CreateChatCompletionRequest
            {
                Messages = messages,
                Model = model,
                FrequencyPenalty = frequencyPenalty,
                LogitBias = logitBias,
                Logprobs = logprobs,
                TopLogprobs = topLogprobs,
                MaxCompletionTokens = maxCompletionTokens,
                N = n,
                PresencePenalty = presencePenalty,
                ResponseFormat = responseFormat,
                Seed = seed,
                Stop = stop,
                Stream = stream,
                StreamOptions = streamOptions,
                Thinking = thinking,
                Temperature = temperature,
                TopP = topP,
                Tools = tools,
                ToolChoice = toolChoice,
                ParallelToolCalls = parallelToolCalls,
                User = user,
            };

            return await CreateChatCompletionAsync(
                xPortkeyTraceId: xPortkeyTraceId,
                xPortkeySpanId: xPortkeySpanId,
                xPortkeyParentSpanId: xPortkeyParentSpanId,
                xPortkeySpanName: xPortkeySpanName,
                xPortkeyMetadata: xPortkeyMetadata,
                xPortkeyCacheNamespace: xPortkeyCacheNamespace,
                xPortkeyCacheForceRefresh: xPortkeyCacheForceRefresh,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}