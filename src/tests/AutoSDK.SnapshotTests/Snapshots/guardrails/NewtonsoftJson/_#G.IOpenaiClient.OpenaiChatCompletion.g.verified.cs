//HintName: G.IOpenaiClient.OpenaiChatCompletion.g.cs
#nullable enable

namespace G
{
    public partial interface IOpenaiClient
    {
        /// <summary>
        /// OpenAI SDK compatible endpoint for Chat Completions
        /// </summary>
        /// <param name="guardName"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.OpenAIChatCompletion> OpenaiChatCompletionAsync(
            string guardName,

            global::G.OpenAIChatCompletionPayload request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// OpenAI SDK compatible endpoint for Chat Completions
        /// </summary>
        /// <param name="guardName"></param>
        /// <param name="model">
        /// The model to use for the completion<br/>
        /// Example: gpt-3.5-turbo
        /// </param>
        /// <param name="messages">
        /// The messages to use for the completion
        /// </param>
        /// <param name="maxTokens">
        /// The maximum number of tokens to generate
        /// </param>
        /// <param name="temperature">
        /// The sampling temperature
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.OpenAIChatCompletion> OpenaiChatCompletionAsync(
            string guardName,
            string? model = default,
            global::System.Collections.Generic.IList<global::G.OpenAIChatMessage>? messages = default,
            int? maxTokens = default,
            double? temperature = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}