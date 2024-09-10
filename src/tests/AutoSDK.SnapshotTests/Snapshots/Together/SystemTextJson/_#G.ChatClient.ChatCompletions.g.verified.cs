//HintName: G.ChatClient.ChatCompletions.g.cs

#nullable enable

namespace G
{
    public partial class ChatClient
    {
        partial void PrepareChatCompletionsArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::G.ChatCompletionRequest request);
        partial void PrepareChatCompletionsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::G.ChatCompletionRequest request);
        partial void ProcessChatCompletionsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessChatCompletionsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create chat completion<br/>
        /// Query a chat model.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.ChatCompletionResponse> ChatCompletionsAsync(
            global::G.ChatCompletionRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareChatCompletionsArguments(
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
            PrepareChatCompletionsRequest(
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
            ProcessChatCompletionsResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessChatCompletionsResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize<global::G.ChatCompletionResponse?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Create chat completion<br/>
        /// Query a chat model.
        /// </summary>
        /// <param name="messages">
        /// A list of messages comprising the conversation so far.
        /// </param>
        /// <param name="model">
        /// The name of the model to query.<br/>
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
        /// <param name="stream">
        /// If true, stream tokens as Server-Sent Events as the model generates them instead of waiting for the full model response. The stream terminates with `data: [DONE]`. If false, return a single JSON object containing the results.
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
        /// Adjusts the likelihood of specific tokens appearing in the generated output.
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
        public async global::System.Threading.Tasks.Task<global::G.ChatCompletionResponse> ChatCompletionsAsync(
            global::System.Collections.Generic.IList<global::G.ChatCompletionRequestMessage> messages,
            string model,
            int maxTokens = default,
            global::System.Collections.Generic.IList<string>? stop = default,
            float temperature = default,
            float topP = default,
            int topK = default,
            double repetitionPenalty = default,
            bool stream = default,
            int logprobs = default,
            bool echo = default,
            int n = default,
            float minP = default,
            float presencePenalty = default,
            float frequencyPenalty = default,
            global::G.ChatCompletionRequestLogitBias? logitBias = default,
            global::G.OneOf<global::G.ChatCompletionRequestFunctionCallEnum?, global::G.ChatCompletionRequestFunctionCallEnum2>? functionCall = default,
            global::G.ChatCompletionRequestResponseFormat? responseFormat = default,
            global::System.Collections.Generic.IList<global::G.ToolsPart>? tools = default,
            global::G.OneOf<string, global::G.ToolChoice2>? toolChoice = default,
            string? safetyModel = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.ChatCompletionRequest
            {
                Messages = messages,
                Model = model,
                MaxTokens = maxTokens,
                Stop = stop,
                Temperature = temperature,
                TopP = topP,
                TopK = topK,
                RepetitionPenalty = repetitionPenalty,
                Stream = stream,
                Logprobs = logprobs,
                Echo = echo,
                N = n,
                MinP = minP,
                PresencePenalty = presencePenalty,
                FrequencyPenalty = frequencyPenalty,
                LogitBias = logitBias,
                FunctionCall = functionCall,
                ResponseFormat = responseFormat,
                Tools = tools,
                ToolChoice = toolChoice,
                SafetyModel = safetyModel,
            };

            return await ChatCompletionsAsync(
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}