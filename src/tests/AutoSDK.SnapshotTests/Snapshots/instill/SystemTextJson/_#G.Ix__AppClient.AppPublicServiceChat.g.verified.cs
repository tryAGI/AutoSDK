//HintName: G.Ix__AppClient.AppPublicServiceChat.g.cs
#nullable enable

namespace G
{
    public partial interface Ix__AppClient
    {
        /// <summary>
        /// Chat<br/>
        /// Chat sends a message asynchronously and streams back the response.<br/>
        /// This method is intended for real-time conversation with a chatbot<br/>
        /// and the response needs to be processed incrementally.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="appId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ChatResponse> AppPublicServiceChatAsync(
            string namespaceId,
            string appId,
            global::G.ChatBody request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Chat<br/>
        /// Chat sends a message asynchronously and streams back the response.<br/>
        /// This method is intended for real-time conversation with a chatbot<br/>
        /// and the response needs to be processed incrementally.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="appId"></param>
        /// <param name="catalogId"></param>
        /// <param name="conversationUid"></param>
        /// <param name="message"></param>
        /// <param name="topK"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ChatResponse> AppPublicServiceChatAsync(
            string namespaceId,
            string appId,
            string catalogId,
            string conversationUid,
            string message,
            long? topK = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}