//HintName: G.IApi.DeleteConversationFlow.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Delete a conversation flow and all its versions
        /// </summary>
        /// <param name="conversationFlowId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteConversationFlowAsync(
            string conversationFlowId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}