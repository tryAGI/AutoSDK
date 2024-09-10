//HintName: G.ChatClient.CreateChatCompletion.g.cs

#nullable enable

namespace G
{
    public partial class ChatClient
    {
        partial void PrepareCreateChatCompletionArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::G.CreateChatCompletionRequest request);
        partial void PrepareCreateChatCompletionRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::G.CreateChatCompletionRequest request);
        partial void ProcessCreateChatCompletionResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateChatCompletionResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Creates a model response for the given chat conversation.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.CreateChatCompletionResponse> CreateChatCompletionAsync(
            global::G.CreateChatCompletionRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareCreateChatCompletionArguments(
                httpClient: _httpClient,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + "/chat/completions", global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContentBody = global::System.Text.Json.JsonSerializer.Serialize(request, _jsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareCreateChatCompletionRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessCreateChatCompletionResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessCreateChatCompletionResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize<global::G.CreateChatCompletionResponse?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Creates a model response for the given chat conversation.
        /// </summary>
        /// <param name="messages">
        /// A list of messages comprising the conversation so far. [Example Python code](https://cookbook.openai.com/examples/how_to_format_inputs_to_chatgpt_models).
        /// </param>
        /// <param name="model">
        /// ID of the model to use. See the [model endpoint compatibility](/docs/models/model-endpoint-compatibility) table for details on which models work with the Chat API.<br/>
        /// Example: gpt-4o
        /// </param>
        /// <param name="frequencyPenalty">
        /// Number between -2.0 and 2.0. Positive values penalize new tokens based on their existing frequency in the text so far, decreasing the model's likelihood to repeat the same line verbatim.<br/>
        /// [See more information about frequency and presence penalties.](/docs/guides/text-generation/parameter-details)<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="logitBias">
        /// Modify the likelihood of specified tokens appearing in the completion.<br/>
        /// Accepts a JSON object that maps tokens (specified by their token ID in the tokenizer) to an associated bias value from -100 to 100. Mathematically, the bias is added to the logits generated by the model prior to sampling. The exact effect will vary per model, but values between -1 and 1 should decrease or increase likelihood of selection; values like -100 or 100 should result in a ban or exclusive selection of the relevant token.
        /// </param>
        /// <param name="logprobs">
        /// Whether to return log probabilities of the output tokens or not. If true, returns the log probabilities of each output token returned in the `content` of `message`.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="topLogprobs">
        /// An integer between 0 and 20 specifying the number of most likely tokens to return at each token position, each with an associated log probability. `logprobs` must be set to `true` if this parameter is used.
        /// </param>
        /// <param name="maxTokens">
        /// The maximum number of [tokens](/tokenizer) that can be generated in the chat completion.<br/>
        /// The total length of input tokens and generated tokens is limited by the model's context length. [Example Python code](https://cookbook.openai.com/examples/how_to_count_tokens_with_tiktoken) for counting tokens.
        /// </param>
        /// <param name="n">
        /// How many chat completion choices to generate for each input message. Note that you will be charged based on the number of generated tokens across all of the choices. Keep `n` as `1` to minimize costs.<br/>
        /// Default Value: 1<br/>
        /// Example: 1
        /// </param>
        /// <param name="presencePenalty">
        /// Number between -2.0 and 2.0. Positive values penalize new tokens based on whether they appear in the text so far, increasing the model's likelihood to talk about new topics.<br/>
        /// [See more information about frequency and presence penalties.](/docs/guides/text-generation/parameter-details)<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="responseFormat">
        /// An object specifying the format that the model must output. Compatible with [GPT-4o](/docs/models/gpt-4o), [GPT-4o mini](/docs/models/gpt-4o-mini), [GPT-4 Turbo](/docs/models/gpt-4-and-gpt-4-turbo) and all GPT-3.5 Turbo models newer than `gpt-3.5-turbo-1106`.<br/>
        /// Setting to `{ "type": "json_schema", "json_schema": {...} }` enables Structured Outputs which guarantees the model will match your supplied JSON schema. Learn more in the [Structured Outputs guide](/docs/guides/structured-outputs).<br/>
        /// Setting to `{ "type": "json_object" }` enables JSON mode, which guarantees the message the model generates is valid JSON.<br/>
        /// **Important:** when using JSON mode, you **must** also instruct the model to produce JSON yourself via a system or user message. Without this, the model may generate an unending stream of whitespace until the generation reaches the token limit, resulting in a long-running and seemingly "stuck" request. Also note that the message content may be partially cut off if `finish_reason="length"`, which indicates the generation exceeded `max_tokens` or the conversation exceeded the max context length.
        /// </param>
        /// <param name="seed">
        /// This feature is in Beta.<br/>
        /// If specified, our system will make a best effort to sample deterministically, such that repeated requests with the same `seed` and parameters should return the same result.<br/>
        /// Determinism is not guaranteed, and you should refer to the `system_fingerprint` response parameter to monitor changes in the backend.
        /// </param>
        /// <param name="serviceTier">
        /// Specifies the latency tier to use for processing the request. This parameter is relevant for customers subscribed to the scale tier service:<br/>
        ///   - If set to 'auto', the system will utilize scale tier credits until they are exhausted.<br/>
        ///   - If set to 'default', the request will be processed using the default service tier with a lower uptime SLA and no latency guarentee.<br/>
        ///   - When not set, the default behavior is 'auto'.<br/>
        ///   When this parameter is set, the response body will include the `service_tier` utilized.
        /// </param>
        /// <param name="stop">
        /// Up to 4 sequences where the API will stop generating further tokens.
        /// </param>
        /// <param name="stream">
        /// If set, partial message deltas will be sent, like in ChatGPT. Tokens will be sent as data-only [server-sent events](https://developer.mozilla.org/en-US/docs/Web/API/Server-sent_events/Using_server-sent_events#Event_stream_format) as they become available, with the stream terminated by a `data: [DONE]` message. [Example Python code](https://cookbook.openai.com/examples/how_to_stream_completions).<br/>
        /// Default Value: false
        /// </param>
        /// <param name="streamOptions">
        /// Options for streaming response. Only set this when you set `stream: true`.
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
        /// Whether to enable [parallel function calling](/docs/guides/function-calling/parallel-function-calling) during tool use.
        /// </param>
        /// <param name="user">
        /// A unique identifier representing your end-user, which can help OpenAI to monitor and detect abuse. [Learn more](/docs/guides/safety-best-practices/end-user-ids).<br/>
        /// Example: user-1234
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.CreateChatCompletionResponse> CreateChatCompletionAsync(
            global::System.Collections.Generic.IList<global::G.ChatCompletionRequestMessage> messages,
            global::G.AnyOf<string, global::G.CreateChatCompletionRequestModel?> model,
            double? frequencyPenalty = 0,
            global::G.CreateChatCompletionRequestLogitBias? logitBias = default,
            bool? logprobs = false,
            int? topLogprobs = default,
            int? maxTokens = default,
            int? n = 1,
            double? presencePenalty = 0,
            global::G.OneOf<global::G.ResponseFormatText, global::G.ResponseFormatJsonObject, global::G.ResponseFormatJsonSchema>? responseFormat = default,
            int? seed = default,
            global::G.CreateChatCompletionRequestServiceTier? serviceTier = default,
            global::G.OneOf<string, global::System.Collections.Generic.IList<string>>? stop = default,
            bool? stream = false,
            global::G.ChatCompletionStreamOptions? streamOptions = default,
            double? temperature = 1,
            double? topP = 1,
            global::System.Collections.Generic.IList<global::G.ChatCompletionTool>? tools = default,
            global::G.ChatCompletionToolChoiceOption? toolChoice = default,
            bool? parallelToolCalls = default,
            string? user = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.CreateChatCompletionRequest
            {
                Messages = messages,
                Model = model,
                FrequencyPenalty = frequencyPenalty,
                LogitBias = logitBias,
                Logprobs = logprobs,
                TopLogprobs = topLogprobs,
                MaxTokens = maxTokens,
                N = n,
                PresencePenalty = presencePenalty,
                ResponseFormat = responseFormat,
                Seed = seed,
                ServiceTier = serviceTier,
                Stop = stop,
                Stream = stream,
                StreamOptions = streamOptions,
                Temperature = temperature,
                TopP = topP,
                Tools = tools,
                ToolChoice = toolChoice,
                ParallelToolCalls = parallelToolCalls,
                User = user,
            };

            return await CreateChatCompletionAsync(
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}