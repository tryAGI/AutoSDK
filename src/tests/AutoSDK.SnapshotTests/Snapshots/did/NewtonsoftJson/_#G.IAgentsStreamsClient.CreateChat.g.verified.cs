//HintName: G.IAgentsStreamsClient.CreateChat.g.cs
#nullable enable

namespace G
{
    public partial interface IAgentsStreamsClient
    {
        /// <summary>
        /// Create a Chat<br/>
        /// Create a new chat with the agent. Each chat has separated history
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> CreateChatAsync(
            string agentId,

            global::G.CreateChatRequest2 request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a Chat<br/>
        /// Create a new chat with the agent. Each chat has separated history
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="persist">
        /// If true, the chat will be saved and won't be deleted automatically<br/>
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> CreateChatAsync(
            string agentId,
            bool? persist = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}