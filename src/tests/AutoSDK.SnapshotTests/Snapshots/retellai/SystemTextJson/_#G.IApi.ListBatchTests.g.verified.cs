//HintName: G.IApi.ListBatchTests.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// List batch test jobs for a response engine
        /// </summary>
        /// <param name="type"></param>
        /// <param name="llmId"></param>
        /// <param name="conversationFlowId"></param>
        /// <param name="version"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.TestCaseBatchJob>> ListBatchTestsAsync(
            global::G.ListBatchTestsType type,
            string? llmId = default,
            string? conversationFlowId = default,
            int? version = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}