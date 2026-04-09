//HintName: G.IApi.CreateChatCompletion.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Create a chat completion message
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateChatCompletionResponse> CreateChatCompletionAsync(

            global::G.CreateChatCompletionRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a chat completion message
        /// </summary>
        /// <param name="chatId">
        /// Unique id of the chat to create completion.<br/>
        /// Example: oBeDLoLOeuAbiuaMFXRtDOLriTJ5tSxD
        /// </param>
        /// <param name="content">
        /// user message to generate agent chat completion.<br/>
        /// Example: hi how are you doing?
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateChatCompletionResponse> CreateChatCompletionAsync(
            string chatId,
            string content,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}