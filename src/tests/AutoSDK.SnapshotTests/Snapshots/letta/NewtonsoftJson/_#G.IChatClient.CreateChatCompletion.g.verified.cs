//HintName: G.IChatClient.CreateChatCompletion.g.cs
#nullable enable

namespace G
{
    public partial interface IChatClient
    {
        /// <summary>
        /// Create Chat Completion<br/>
        /// Create a chat completion using a Letta agent (OpenAI-compatible).<br/>
        /// This endpoint provides full OpenAI API compatibility. The agent is selected based on:<br/>
        /// - The 'model' parameter in the request (should contain an agent ID in format 'agent-...')<br/>
        /// When streaming is enabled (stream=true), the response will be Server-Sent Events<br/>
        /// with ChatCompletionChunk objects.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ChatCompletion> CreateChatCompletionAsync(

            global::G.ChatCompletionRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Chat Completion<br/>
        /// Create a chat completion using a Letta agent (OpenAI-compatible).<br/>
        /// This endpoint provides full OpenAI API compatibility. The agent is selected based on:<br/>
        /// - The 'model' parameter in the request (should contain an agent ID in format 'agent-...')<br/>
        /// When streaming is enabled (stream=true), the response will be Server-Sent Events<br/>
        /// with ChatCompletionChunk objects.
        /// </summary>
        /// <param name="model">
        /// ID of the model to use
        /// </param>
        /// <param name="messages">
        /// Messages comprising the conversation so far
        /// </param>
        /// <param name="temperature">
        /// Sampling temperature
        /// </param>
        /// <param name="topP">
        /// Nucleus sampling parameter
        /// </param>
        /// <param name="n">
        /// Number of chat completion choices to generate<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="stream">
        /// Whether to stream back partial progress<br/>
        /// Default Value: false
        /// </param>
        /// <param name="stop">
        /// Sequences where the API will stop generating
        /// </param>
        /// <param name="maxTokens">
        /// Maximum number of tokens to generate
        /// </param>
        /// <param name="presencePenalty">
        /// Presence penalty
        /// </param>
        /// <param name="frequencyPenalty">
        /// Frequency penalty
        /// </param>
        /// <param name="user">
        /// A unique identifier representing your end-user
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ChatCompletion> CreateChatCompletionAsync(
            string model,
            global::System.Collections.Generic.IList<global::G.AnyOf<global::G.ChatCompletionDeveloperMessageParam, global::G.ChatCompletionSystemMessageParam, global::G.ChatCompletionUserMessageParam, global::G.ChatCompletionAssistantMessageParam, global::G.ChatCompletionToolMessageParam, global::G.ChatCompletionFunctionMessageParam>> messages,
            double? temperature = default,
            double? topP = default,
            int? n = default,
            bool? stream = default,
            global::G.AnyOf<string, global::System.Collections.Generic.IList<string>, object>? stop = default,
            int? maxTokens = default,
            double? presencePenalty = default,
            double? frequencyPenalty = default,
            string? user = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}