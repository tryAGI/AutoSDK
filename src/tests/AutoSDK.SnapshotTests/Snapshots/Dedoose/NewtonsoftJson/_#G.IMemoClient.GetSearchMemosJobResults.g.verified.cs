//HintName: G.IMemoClient.GetSearchMemosJobResults.g.cs
#nullable enable

namespace G
{
    public partial interface IMemoClient
    {
        /// <summary>
        /// GetSearchMemosJobResults<br/>
        /// GetSearchMemosJobResults
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> GetSearchMemosJobResultsAsync(
            global::G.GetSearchMemosJobResultsRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// GetSearchMemosJobResults<br/>
        /// GetSearchMemosJobResults
        /// </summary>
        /// <param name="jobId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> GetSearchMemosJobResultsAsync(
            string jobId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}