//HintName: G.IAssistantsClient.RetrieveMessage.g.cs
#nullable enable

namespace G
{
    public partial interface IAssistantsClient
    {
        /// <summary>
        /// Retrieve a message.
        /// </summary>
        /// <param name="threadId"></param>
        /// <param name="messageId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.MessageObject> RetrieveMessageAsync(
            string threadId,
            string messageId,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}