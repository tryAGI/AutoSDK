//HintName: G.IApi.ListTestRunsV2.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// List test case jobs (test runs) for a batch test job with pagination
        /// </summary>
        /// <param name="testCaseBatchJobId"></param>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="paginationKey"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AllOf<global::G.PaginatedResponseBase, global::G.ListTestRunsV2Response2>> ListTestRunsV2Async(
            string testCaseBatchJobId,
            int? limit = default,
            string? paginationKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}