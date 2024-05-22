//HintName: G.Api.EndPoints.CreateChatCompletion.g.cs

#nullable enable

namespace G
{
    public partial class Api
    {
        /// <summary>
        /// Creates a model response for the given chat conversation.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<CreateChatCompletionResponse> CreateChatCompletionAsync(
            CreateChatCompletionRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + "/chat/completions", global::System.UriKind.RelativeOrAbsolute));
            httpRequest.Content = new global::System.Net.Http.StringContent(
                content: global::Newtonsoft.Json.JsonConvert.SerializeObject(request),
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            return
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<CreateChatCompletionResponse>(content) ??
                throw new global::System.InvalidOperationException("Response deserialization failed for \"{content}\" ");
        }

        /// <summary>
        /// Creates a model response for the given chat conversation.
        /// </summary>
        /// <param name="messages"></param>
        /// <param name="model"></param>
        /// <param name="frequencyPenalty"></param>
        /// <param name="logitBias"></param>
        /// <param name="logprobs"></param>
        /// <param name="topLogprobs"></param>
        /// <param name="maxTokens"></param>
        /// <param name="n"></param>
        /// <param name="presencePenalty"></param>
        /// <param name="responseFormat"></param>
        /// <param name="seed"></param>
        /// <param name="stop"></param>
        /// <param name="stream"></param>
        /// <param name="streamOptions"></param>
        /// <param name="temperature"></param>
        /// <param name="topP"></param>
        /// <param name="tools"></param>
        /// <param name="toolChoice"></param>
        /// <param name="user"></param>
        /// <param name="functionCall"></param>
        /// <param name="functions"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<CreateChatCompletionResponse> CreateChatCompletionAsync(
            global::System.Collections.Generic.IList<ChatCompletionRequestMessage> messages,
            object model,
            double? frequencyPenalty = default,
            object? logitBias = default,
            bool? logprobs = default,
            int? topLogprobs = default,
            int? maxTokens = default,
            int? n = default,
            double? presencePenalty = default,
            CreateChatCompletionRequestResponseFormat? responseFormat = default,
            int? seed = default,
            object? stop = default,
            bool? stream = default,
            ChatCompletionStreamOptions? streamOptions = default,
            double? temperature = default,
            double? topP = default,
            global::System.Collections.Generic.IList<ChatCompletionTool>? tools = default,
            ChatCompletionToolChoiceOption? toolChoice = default,
            string? user = default,
            object? functionCall = default,
            global::System.Collections.Generic.IList<ChatCompletionFunctions>? functions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new CreateChatCompletionRequest
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
                Stop = stop,
                Stream = stream,
                StreamOptions = streamOptions,
                Temperature = temperature,
                TopP = topP,
                Tools = tools,
                ToolChoice = toolChoice,
                User = user,
                FunctionCall = functionCall,
                Functions = functions,
            };

            return await CreateChatCompletionAsync(
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}