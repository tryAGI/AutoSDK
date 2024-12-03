//HintName: G.IMemoClient.StartSearchMemosJob.g.cs
#nullable enable

namespace G
{
    public partial interface IMemoClient
    {
        /// <summary>
        /// StartSearchMemosJob<br/>
        /// StartSearchMemosJob
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> StartSearchMemosJobAsync(
            global::G.StartSearchMemosJobRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// StartSearchMemosJob<br/>
        /// StartSearchMemosJob
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="searchText"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> StartSearchMemosJobAsync(
            global::System.Guid projectId,
            string searchText,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}