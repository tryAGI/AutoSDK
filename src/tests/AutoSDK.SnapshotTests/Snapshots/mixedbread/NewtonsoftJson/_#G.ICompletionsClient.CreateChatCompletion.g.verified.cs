//HintName: G.ICompletionsClient.CreateChatCompletion.g.cs
#nullable enable

namespace G
{
    public partial interface ICompletionsClient
    {
        /// <summary>
        /// Create a chat completion<br/>
        /// Create a chat completion using the provided parameters.<br/>
        /// Generates a completion response based on the chat messages and model parameters provided.<br/>
        /// The response can be either a full completion or streamed chunks depending on the request parameters.<br/>
        /// Args:<br/>
        ///     params: Parameters for creating the chat completion including messages, model selection,<br/>
        ///            and generation settings<br/>
        ///     user: The authenticated user making the request<br/>
        /// Returns:<br/>
        ///     Either a ChatCompletion containing the full response, or ChatCompletionChunk for streaming<br/>
        /// Raises:<br/>
        ///     HTTPException: If there is an error creating the completion (500)
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> CreateChatCompletionAsync(
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}