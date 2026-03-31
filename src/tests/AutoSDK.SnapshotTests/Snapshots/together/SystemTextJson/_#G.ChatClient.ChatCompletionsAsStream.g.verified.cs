//HintName: G.ChatClient.ChatCompletionsAsStream.g.cs

#nullable enable

namespace G
{
    public partial class ChatClient
    {
        partial void PrepareChatCompletionsAsStreamArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::G.ChatCompletionRequest request);
        partial void PrepareChatCompletionsAsStreamRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::G.ChatCompletionRequest request);
        partial void ProcessChatCompletionsAsStreamResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        /// <summary>
        /// Create chat completion<br/>
        /// Query a chat model.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Collections.Generic.IAsyncEnumerable<global::G.ChatCompletionStream> ChatCompletionsAsStreamAsync(

            global::G.ChatCompletionRequest request,
            [global::System.Runtime.CompilerServices.EnumeratorCancellation] global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));


            request = new global::G.ChatCompletionRequest
            {
                Messages = request.Messages,
                Model = request.Model,
                MaxTokens = request.MaxTokens,
                Stop = request.Stop,
                Temperature = request.Temperature,
                TopP = request.TopP,
                TopK = request.TopK,
                RepetitionPenalty = request.RepetitionPenalty,
                Stream = true,
                Logprobs = request.Logprobs,
                Echo = request.Echo,
                N = request.N,
                MinP = request.MinP,
                PresencePenalty = request.PresencePenalty,
                FrequencyPenalty = request.FrequencyPenalty,
                LogitBias = request.LogitBias,
                Seed = request.Seed,
                FunctionCall = request.FunctionCall,
                ResponseFormat = request.ResponseFormat,
                Tools = request.Tools,
                ToolChoice = request.ToolChoice,
                SafetyModel = request.SafetyModel,
            };
            PrepareArguments(
                client: HttpClient);
            PrepareChatCompletionsAsStreamArguments(
                httpClient: HttpClient,
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
            var __httpRequestContentBody = request.ToJson(JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareChatCompletionsAsStreamRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseHeadersRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessChatCompletionsAsStreamResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            try
            {
                __response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException __ex)
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

            using var __stream = await __response.Content.ReadAsStreamAsync(
#if NET5_0_OR_GREATER
                cancellationToken
#endif
            ).ConfigureAwait(false);

            await foreach (var __sseEvent in global::System.Net.ServerSentEvents.SseParser
                .Create(__stream).EnumerateAsync(cancellationToken))
            {
                var __content = __sseEvent.Data;
                if (__content == "[DONE]")
                {
                    yield break;
                }

                var __streamedResponse = global::G.ChatCompletionStream.FromJson(__content, JsonSerializerOptions) ??
                                       throw new global::G.ApiException(
                                           message: $"Response deserialization failed for \"{__content}\" ",
                                           statusCode: __response.StatusCode)
                                       {
                                           ResponseBody = __content,
                                           ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                                               __response.Headers,
                                               h => h.Key,
                                               h => h.Value),
                                       };

                yield return __streamedResponse;
            }
        }
        /// <summary>
        /// Create chat completion<br/>
        /// Query a chat model.
        /// </summary>
        /// <param name="messages">
        /// A list of messages comprising the conversation so far.<br/>
        /// Default Value: [{"role":"system","content":"You are a helpful assistant"}, {"role":"user","content":"What is 1 \u002B 1?"}]
        /// </param>
        /// <param name="model">
        /// The name of the model to query.<br/>
        /// Default Value: mistralai/Mixtral-8x7B-Instruct-v0.1<br/>
        /// Example: mistralai/Mixtral-8x7B-Instruct-v0.1
        /// </param>
        /// <param name="maxTokens">
        /// The maximum number of tokens to generate.
        /// </param>
        /// <param name="stop">
        /// A list of string sequences that will truncate (stop) inference text output. For example, "&lt;/s&gt;" will stop generation as soon as the model generates the given token.
        /// </param>
        /// <param name="temperature">
        /// A decimal number from 0-1 that determines the degree of randomness in the response. A temperature less than 1 favors more correctness and is appropriate for question answering or summarization. A value closer to 1 introduces more randomness in the output.
        /// </param>
        /// <param name="topP">
        /// A percentage (also called the nucleus parameter) that's used to dynamically adjust the number of choices for each predicted token based on the cumulative probabilities. It specifies a probability threshold below which all less likely tokens are filtered out. This technique helps maintain diversity and generate more fluent and natural-sounding text.
        /// </param>
        /// <param name="topK">
        /// An integer that's used to limit the number of choices for the next predicted word or token. It specifies the maximum number of tokens to consider at each step, based on their probability of occurrence. This technique helps to speed up the generation process and can improve the quality of the generated text by focusing on the most likely options.
        /// </param>
        /// <param name="repetitionPenalty">
        /// A number that controls the diversity of generated text by reducing the likelihood of repeated sequences. Higher values decrease repetition.
        /// </param>
        /// <param name="logprobs">
        /// Determines the number of most likely tokens to return at each token position log probabilities to return.
        /// </param>
        /// <param name="echo">
        /// If true, the response will contain the prompt. Can be used with `logprobs` to return prompt logprobs.
        /// </param>
        /// <param name="n">
        /// The number of completions to generate for each prompt.
        /// </param>
        /// <param name="minP">
        /// A number between 0 and 1 that can be used as an alternative to top_p and top-k.
        /// </param>
        /// <param name="presencePenalty">
        /// A number between -2.0 and 2.0 where a positive value increases the likelihood of a model talking about new topics.
        /// </param>
        /// <param name="frequencyPenalty">
        /// A number between -2.0 and 2.0 where a positive value decreases the likelihood of repeating tokens that have already been mentioned.
        /// </param>
        /// <param name="logitBias">
        /// Adjusts the likelihood of specific tokens appearing in the generated output.<br/>
        /// Example: {"1024":-10.5,"105":21.4}
        /// </param>
        /// <param name="seed">
        /// Seed value for reproducibility.<br/>
        /// Example: 42
        /// </param>
        /// <param name="functionCall"></param>
        /// <param name="responseFormat">
        /// An object specifying the format that the model must output.
        /// </param>
        /// <param name="tools">
        /// A list of tools the model may call. Currently, only functions are supported as a tool. Use this to provide a list of functions the model may generate JSON inputs for.
        /// </param>
        /// <param name="toolChoice">
        /// Controls which (if any) function is called by the model. By default uses `auto`, which lets the model pick between generating a message or calling a function.
        /// </param>
        /// <param name="safetyModel">
        /// The name of the moderation model used to validate tokens. Choose from the available moderation models found [here](https://docs.together.ai/docs/inference-models#moderation-models).<br/>
        /// Example: safety_model_name
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Collections.Generic.IAsyncEnumerable<global::G.ChatCompletionStream> ChatCompletionsAsStreamAsync(
            global::System.Collections.Generic.IList<global::G.ChatCompletionRequestMessage> messages,
            string model = "mistralai/Mixtral-8x7B-Instruct-v0.1",
            int? maxTokens = default,
            global::System.Collections.Generic.IList<string>? stop = default,
            float? temperature = default,
            float? topP = default,
            int? topK = default,
            double? repetitionPenalty = default,
            int? logprobs = default,
            bool? echo = default,
            int? n = default,
            float? minP = default,
            float? presencePenalty = default,
            float? frequencyPenalty = default,
            global::System.Collections.Generic.Dictionary<string, float>? logitBias = default,
            int? seed = default,
            global::G.OneOf<global::G.ChatCompletionRequestFunctionCallEnum?, global::G.ChatCompletionRequestFunctionCallEnum2>? functionCall = default,
            global::G.ChatCompletionRequestResponseFormat? responseFormat = default,
            global::System.Collections.Generic.IList<global::G.ToolsPart>? tools = default,
            global::G.OneOf<string, global::G.ToolChoice2>? toolChoice = default,
            string? safetyModel = default,
            [global::System.Runtime.CompilerServices.EnumeratorCancellation] global::System.Threading.CancellationToken cancellationToken = default)
        {

            var __request = new global::G.ChatCompletionRequest
            {
                Messages = messages,
                Model = model,
                MaxTokens = maxTokens,
                Stop = stop,
                Temperature = temperature,
                TopP = topP,
                TopK = topK,
                RepetitionPenalty = repetitionPenalty,
                Stream = true,
                Logprobs = logprobs,
                Echo = echo,
                N = n,
                MinP = minP,
                PresencePenalty = presencePenalty,
                FrequencyPenalty = frequencyPenalty,
                LogitBias = logitBias,
                Seed = seed,
                FunctionCall = functionCall,
                ResponseFormat = responseFormat,
                Tools = tools,
                ToolChoice = toolChoice,
                SafetyModel = safetyModel,
            };

            var __enumerable = ChatCompletionsAsStreamAsync(
                request: __request,
                cancellationToken: cancellationToken);

            await foreach (var __response in __enumerable)
            {
                yield return __response;
            }
        }
    }
}