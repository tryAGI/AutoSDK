//HintName: G.IApi.ListTestRuns.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// List all test case jobs (test runs) for a batch test job
        /// </summary>
        /// <param name="testCaseBatchJobId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.TestCaseJob>> ListTestRunsAsync(
            string testCaseBatchJobId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}