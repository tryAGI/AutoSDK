//HintName: G.IApi.ListConversationFlowComponentsV2.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// List shared conversation flow components with pagination
        /// </summary>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="sortOrder">
        /// Default Value: descending
        /// </param>
        /// <param name="paginationKey"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AllOf<global::G.PaginatedResponseBase, global::G.ListConversationFlowComponentsV2Response2>> ListConversationFlowComponentsV2Async(
            int? limit = default,
            global::G.ListConversationFlowComponentsV2SortOrder? sortOrder = default,
            string? paginationKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}