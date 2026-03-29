//HintName: G.IApi.CreateBatchTest.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Create a batch test to run multiple test cases
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.TestCaseBatchJob> CreateBatchTestAsync(

            global::G.CreateBatchTestRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a batch test to run multiple test cases
        /// </summary>
        /// <param name="testCaseDefinitionIds">
        /// Array of test case definition IDs to run
        /// </param>
        /// <param name="responseEngine">
        /// Response engine for test cases. Custom LLM is not supported.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.TestCaseBatchJob> CreateBatchTestAsync(
            global::System.Collections.Generic.IList<string> testCaseDefinitionIds,
            global::G.RetellResponseEngine responseEngine,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}