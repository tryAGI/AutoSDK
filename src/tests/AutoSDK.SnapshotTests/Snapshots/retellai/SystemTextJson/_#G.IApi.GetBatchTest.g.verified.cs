//HintName: G.IApi.GetBatchTest.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Get a batch test job by ID
        /// </summary>
        /// <param name="testCaseBatchJobId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.TestCaseBatchJob> GetBatchTestAsync(
            string testCaseBatchJobId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}