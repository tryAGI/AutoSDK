//HintName: G.IChatClient.GetChatCompletionMessages.g.cs
#nullable enable

namespace G
{
    public partial interface IChatClient
    {
        /// <summary>
        /// Get the messages in a stored chat completion. Only Chat Completions that<br/>
        /// have been created with the `store` parameter set to `true` will be<br/>
        /// returned.
        /// </summary>
        /// <param name="completionId"></param>
        /// <param name="after"></param>
        /// <param name="limit">
        /// Default Value: 20
        /// </param>
        /// <param name="order">
        /// Default Value: asc
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ChatCompletionMessageList> GetChatCompletionMessagesAsync(
            string completionId,
            string? after = default,
            int? limit = default,
            global::G.GetChatCompletionMessagesOrder? order = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}