//HintName: G.IApi.ListConversationFlows.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// List all conversation flows that can be attached to an agent.
        /// </summary>
        /// <param name="limit">
        /// Default Value: 1000
        /// </param>
        /// <param name="paginationKey"></param>
        /// <param name="paginationKeyVersion"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.ConversationFlowResponse>> ListConversationFlowsAsync(
            int? limit = default,
            string? paginationKey = default,
            int? paginationKeyVersion = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}