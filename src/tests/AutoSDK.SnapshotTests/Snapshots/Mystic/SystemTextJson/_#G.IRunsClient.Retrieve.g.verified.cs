//HintName: G.IRunsClient.Retrieve.g.cs
#nullable enable

namespace G
{
    public partial interface IRunsClient
    {
        /// <summary>
        /// Retrieve<br/>
        /// Retrieve the details of a run.
        /// </summary>
        /// <param name="runId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ClusterRunResult> RetrieveAsync(
            string runId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}