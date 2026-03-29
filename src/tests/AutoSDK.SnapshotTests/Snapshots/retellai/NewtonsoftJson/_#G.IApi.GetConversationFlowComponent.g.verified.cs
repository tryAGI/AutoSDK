//HintName: G.IApi.GetConversationFlowComponent.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Get a shared conversation flow component
        /// </summary>
        /// <param name="conversationFlowComponentId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ConversationFlowComponentResponse> GetConversationFlowComponentAsync(
            string conversationFlowComponentId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}