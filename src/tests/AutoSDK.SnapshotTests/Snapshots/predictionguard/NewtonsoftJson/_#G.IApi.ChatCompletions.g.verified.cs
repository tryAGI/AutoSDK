//HintName: G.IApi.ChatCompletions.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Chat Completions<br/>
        /// Generate chat completions based on a conversation history.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ChatCompletionsResponse200> ChatCompletionsAsync(

            global::G.ChatCompletionsRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Chat Completions<br/>
        /// Generate chat completions based on a conversation history.
        /// </summary>
        /// <param name="model">
        /// The chat model to use for generating completions.
        /// </param>
        /// <param name="messages"></param>
        /// <param name="frequencyPenalty">
        /// A value between -2.0 and 2.0, with positive values increasingly penalizing new tokens based on their frequency so far in order to decrease further occurrences.
        /// </param>
        /// <param name="logitBias">
        /// Modifies the likelihood of specified tokens appearing in a response.
        /// </param>
        /// <param name="maxCompletionTokens">
        /// The maximum number of tokens in the generated completion.
        /// </param>
        /// <param name="parallelToolCalls">
        /// Whether to enable parallel function calling during tool use.
        /// </param>
        /// <param name="presencePenalty">
        /// A value between -2.0 and 2.0, with positive values causing a flat reduction of new tokens based on their existing presence so far in order to decrease further occurrences.
        /// </param>
        /// <param name="reasoningEffort">
        /// Constrains effort on reasoning for reasoning models. Currently supported values are `low`, `medium`, and `high`. Reducing reasoning effort can result in faster responses and fewer tokens used on reasoning in a response. Only supported by reasoning models.
        /// </param>
        /// <param name="stop"></param>
        /// <param name="stream">
        /// Whether to stream back the model response.
        /// </param>
        /// <param name="streamOptions">
        /// Extra parameters used when streaming the response.
        /// </param>
        /// <param name="temperature">
        /// The temperature parameter for controlling randomness in completions. Supports a range of 0.0-2.0.
        /// </param>
        /// <param name="toolChoice"></param>
        /// <param name="tools">
        /// The content of the tool call.
        /// </param>
        /// <param name="topP">
        /// The diversity of the generated text based on nucleus sampling. Supports a range of 0.0-1.0.
        /// </param>
        /// <param name="topK">
        /// The diversity of the generated text based on top-k sampling.
        /// </param>
        /// <param name="output">
        /// Options to affect the output of the response.
        /// </param>
        /// <param name="input">
        /// Options to affect the input of the request.
        /// </param>
        /// <param name="maxTokens">
        /// Deprecated. Please use max_completion_tokens.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ChatCompletionsResponse200> ChatCompletionsAsync(
            string model,
            global::G.ChatCompletionsPostRequestBodyContentApplicationJsonSchemaMessages messages,
            double? frequencyPenalty = default,
            global::G.ChatCompletionsPostRequestBodyContentApplicationJsonSchemaLogitBias? logitBias = default,
            int? maxCompletionTokens = default,
            bool? parallelToolCalls = default,
            double? presencePenalty = default,
            string? reasoningEffort = default,
            global::G.ChatCompletionsPostRequestBodyContentApplicationJsonSchemaStop? stop = default,
            bool? stream = default,
            global::G.ChatCompletionsPostRequestBodyContentApplicationJsonSchemaStreamOptions? streamOptions = default,
            double? temperature = default,
            global::G.ChatCompletionsPostRequestBodyContentApplicationJsonSchemaToolChoice? toolChoice = default,
            global::System.Collections.Generic.IList<global::G.ChatCompletionsPostRequestBodyContentApplicationJsonSchemaToolsItems>? tools = default,
            double? topP = default,
            int? topK = default,
            global::G.ChatCompletionsPostRequestBodyContentApplicationJsonSchemaOutput? output = default,
            global::G.ChatCompletionsPostRequestBodyContentApplicationJsonSchemaInput? input = default,
            int? maxTokens = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}