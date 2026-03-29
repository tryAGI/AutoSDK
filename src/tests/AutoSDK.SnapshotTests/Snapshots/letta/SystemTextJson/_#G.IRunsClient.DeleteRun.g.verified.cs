//HintName: G.IRunsClient.DeleteRun.g.cs
#nullable enable

namespace G
{
    public partial interface IRunsClient
    {
        /// <summary>
        /// Delete Run<br/>
        /// Delete a run by its run_id.
        /// </summary>
        /// <param name="runId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> DeleteRunAsync(
            string runId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}