//HintName: G.IApi.CreateChatCompletion.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Create a chat completion<br/>
        /// Generates a model response for the given conversation. Supports Sarvam's<br/>
        /// Indian language LLMs including Sarvam-105B, Sarvam-30B, and Sarvam-M.<br/>
        /// Supports tool calling, streaming, and reasoning effort control.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ChatCompletionResponse> CreateChatCompletionAsync(

            global::G.ChatCompletionRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a chat completion<br/>
        /// Generates a model response for the given conversation. Supports Sarvam's<br/>
        /// Indian language LLMs including Sarvam-105B, Sarvam-30B, and Sarvam-M.<br/>
        /// Supports tool calling, streaming, and reasoning effort control.
        /// </summary>
        /// <param name="model">
        /// Model ID to use for completion
        /// </param>
        /// <param name="messages">
        /// List of messages in the conversation
        /// </param>
        /// <param name="temperature">
        /// Sampling temperature (0-2). Default: 0.2<br/>
        /// Default Value: 0.2
        /// </param>
        /// <param name="topP">
        /// Nucleus sampling parameter. Default: 1.0<br/>
        /// Default Value: 1.0
        /// </param>
        /// <param name="maxTokens">
        /// Maximum number of tokens to generate
        /// </param>
        /// <param name="stream">
        /// Whether to stream the response via SSE<br/>
        /// Default Value: false
        /// </param>
        /// <param name="stop">
        /// Up to 4 stop sequences
        /// </param>
        /// <param name="n">
        /// Number of completion choices to generate<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="seed">
        /// Seed for deterministic sampling (beta)
        /// </param>
        /// <param name="frequencyPenalty">
        /// Frequency penalty (-2.0 to 2.0). Default: 0<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="presencePenalty">
        /// Presence penalty (-2.0 to 2.0). Default: 0<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="reasoningEffort">
        /// Level of reasoning effort
        /// </param>
        /// <param name="wikiGrounding">
        /// Enable Wikipedia-based grounding<br/>
        /// Default Value: false
        /// </param>
        /// <param name="tools">
        /// List of tools the model may call
        /// </param>
        /// <param name="toolChoice">
        /// Controls tool invocation: none, auto, required
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ChatCompletionResponse> CreateChatCompletionAsync(
            global::G.ChatCompletionRequestModel model,
            global::System.Collections.Generic.IList<global::G.ChatCompletionMessage> messages,
            double? temperature = default,
            double? topP = default,
            int? maxTokens = default,
            bool? stream = default,
            global::System.Collections.Generic.IList<string>? stop = default,
            int? n = default,
            int? seed = default,
            double? frequencyPenalty = default,
            double? presencePenalty = default,
            global::G.ChatCompletionRequestReasoningEffort? reasoningEffort = default,
            bool? wikiGrounding = default,
            global::System.Collections.Generic.IList<global::G.ChatCompletionTool>? tools = default,
            global::G.ChatCompletionRequestToolChoice? toolChoice = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}