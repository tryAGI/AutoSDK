//HintName: G.IEnvironmentsClient.EnvironmentsSendMessage.g.cs
#nullable enable

namespace G
{
    public partial interface IEnvironmentsClient
    {
        /// <summary>
        /// Send Message to Environment<br/>
        /// Send a message to a specific environment connection
        /// </summary>
        /// <param name="connectionId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.EnvironmentsSendMessageResponse> EnvironmentsSendMessageAsync(
            string connectionId,

            global::G.EnvironmentsSendMessageRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Send Message to Environment<br/>
        /// Send a message to a specific environment connection
        /// </summary>
        /// <param name="connectionId"></param>
        /// <param name="messages"></param>
        /// <param name="agentId"></param>
        /// <param name="conversationId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.EnvironmentsSendMessageResponse> EnvironmentsSendMessageAsync(
            string connectionId,
            global::System.Collections.Generic.IList<global::G.OneOf<global::G.EnvironmentsSendMessageRequestMessageVariant1, global::G.EnvironmentsSendMessageRequestMessageVariant2>> messages,
            string? agentId = default,
            string? conversationId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}