//HintName: G.IApi.ListBatchTestsV2.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// List batch test jobs with pagination
        /// </summary>
        /// <param name="type"></param>
        /// <param name="llmId"></param>
        /// <param name="conversationFlowId"></param>
        /// <param name="version"></param>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="paginationKey"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AllOf<global::G.PaginatedResponseBase, global::G.ListBatchTestsV2Response2>> ListBatchTestsV2Async(
            global::G.ListBatchTestsV2Type type,
            string? llmId = default,
            string? conversationFlowId = default,
            int? version = default,
            int? limit = default,
            string? paginationKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}