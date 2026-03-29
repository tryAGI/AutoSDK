//HintName: G.IExperimentsClient.ListExperimentRuns.g.cs
#nullable enable

namespace G
{
    public partial interface IExperimentsClient
    {
        /// <summary>
        /// List runs for an experiment<br/>
        /// Retrieve a paginated list of runs for an experiment
        /// </summary>
        /// <param name="experimentId"></param>
        /// <param name="cursor">
        /// Cursor for pagination (base64-encoded experiment run ID)
        /// </param>
        /// <param name="limit">
        /// The max number of experiment runs to return at a time. If not specified, returns all results.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ListExperimentRunsResponseBody> ListExperimentRunsAsync(
            string experimentId,
            string? cursor = default,
            int? limit = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}