//HintName: G.IApi.EndChat.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// End an ongoing chat
        /// </summary>
        /// <param name="chatId">
        /// Example: 16b980523634a6dc504898cda492e939
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task EndChatAsync(
            string chatId,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}