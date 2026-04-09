//HintName: G.IAgentsStreamsClient.Chat.g.cs
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace G
{
    public partial interface IAgentsStreamsClient
    {
        /// <summary>
        /// Send a message to a Chat<br/>
        /// Send a chat message to the existing chat with the agent
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="chatId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ChatResponse2> ChatAsync(
            string agentId,
            string chatId,

            global::G.ChatRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Send a message to a Chat<br/>
        /// Send a chat message to the existing chat with the agent
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="chatId"></param>
        /// <param name="messages">
        /// List of messages for Chat
        /// </param>
        /// <param name="streamId">
        /// Id of Stream (a new WebRTC connection to a browser peer)<br/>
        /// For more details go to Stream documents
        /// </param>
        /// <param name="sessionId">
        /// Id of session for Stream<br/>
        /// Required to organize requests to one thread of messages
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ChatResponse2> ChatAsync(
            string agentId,
            string chatId,
            global::System.Collections.Generic.IList<global::G.ChatRequestMessage> messages,
            string? streamId = default,
            string? sessionId = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}