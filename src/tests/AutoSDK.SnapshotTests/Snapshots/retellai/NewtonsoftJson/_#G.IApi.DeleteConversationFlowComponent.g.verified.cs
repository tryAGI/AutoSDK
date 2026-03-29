//HintName: G.IApi.DeleteConversationFlowComponent.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Delete a shared conversation flow component. When deleting a shared component, creates local copies for all linked conversation flows.
        /// </summary>
        /// <param name="conversationFlowComponentId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteConversationFlowComponentAsync(
            string conversationFlowComponentId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}