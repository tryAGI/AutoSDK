//HintName: G.IAppClient.AppPublicServiceCreateMessage.g.cs
#nullable enable

namespace G
{
    public partial interface IAppClient
    {
        /// <summary>
        /// Create a message<br/>
        /// Creates a message.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="appId"></param>
        /// <param name="conversationId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateMessageResponse> AppPublicServiceCreateMessageAsync(
            string namespaceId,
            string appId,
            string conversationId,
            global::G.CreateMessageBody request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create a message<br/>
        /// Creates a message.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="appId"></param>
        /// <param name="conversationId"></param>
        /// <param name="content"></param>
        /// <param name="role"></param>
        /// <param name="type"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateMessageResponse> AppPublicServiceCreateMessageAsync(
            string namespaceId,
            string appId,
            string conversationId,
            string content,
            string role,
            global::G.MessageType type = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}