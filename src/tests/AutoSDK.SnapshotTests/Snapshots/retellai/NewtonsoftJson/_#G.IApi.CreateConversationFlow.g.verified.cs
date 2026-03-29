//HintName: G.IApi.CreateConversationFlow.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Create a new Conversation Flow that can be attached to an agent. This is used to generate response output for the agent.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ConversationFlowResponse> CreateConversationFlowAsync(

            global::G.CreateConversationFlowRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a new Conversation Flow that can be attached to an agent. This is used to generate response output for the agent.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ConversationFlowResponse> CreateConversationFlowAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}