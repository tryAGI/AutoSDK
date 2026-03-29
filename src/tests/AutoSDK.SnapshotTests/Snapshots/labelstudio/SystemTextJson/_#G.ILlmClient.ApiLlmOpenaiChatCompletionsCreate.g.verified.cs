//HintName: G.ILlmClient.ApiLlmOpenaiChatCompletionsCreate.g.cs
#nullable enable

namespace G
{
    public partial interface ILlmClient
    {
        /// <summary>
        /// Proxy to OpenAI-Compatible Chat Completions<br/>
        /// Proxy requests to OpenAI-compatible chat completions APIs and return the full response payload. Supports multiple providers via model parameter format: "model_name" (defaults to OpenAI), "provider/model_name", or "provider:model_name". Works with providers that offer OpenAI-compatible endpoints.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> ApiLlmOpenaiChatCompletionsCreateAsync(

            global::G.ApiLlmOpenaiChatCompletionsCreateRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Proxy to OpenAI-Compatible Chat Completions<br/>
        /// Proxy requests to OpenAI-compatible chat completions APIs and return the full response payload. Supports multiple providers via model parameter format: "model_name" (defaults to OpenAI), "provider/model_name", or "provider:model_name". Works with providers that offer OpenAI-compatible endpoints.
        /// </summary>
        /// <param name="messages">
        /// Array of message objects for the chat completion
        /// </param>
        /// <param name="model">
        /// Model identifier. Can be "model_name" (defaults to OpenAI), "provider/model_name", or "provider:model_name"<br/>
        /// Example: gpt-4
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> ApiLlmOpenaiChatCompletionsCreateAsync(
            global::System.Collections.Generic.IList<global::G.ApiLlmOpenaiChatCompletionsCreateRequestMessage> messages,
            string model,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}