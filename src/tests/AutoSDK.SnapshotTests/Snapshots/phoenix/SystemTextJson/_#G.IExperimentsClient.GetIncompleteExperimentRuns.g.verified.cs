//HintName: G.IExperimentsClient.GetIncompleteExperimentRuns.g.cs
#nullable enable

namespace G
{
    public partial interface IExperimentsClient
    {
        /// <summary>
        /// Get incomplete runs for an experiment<br/>
        /// Get runs that need to be completed for this experiment.<br/>
        /// Returns all incomplete runs, including both missing runs (not yet attempted)<br/>
        /// and failed runs (attempted but have errors).<br/>
        /// Args:<br/>
        ///     experiment_id: The ID of the experiment<br/>
        ///     cursor: Cursor for pagination<br/>
        ///     limit: Maximum number of results to return<br/>
        /// Returns:<br/>
        ///     Paginated list of incomplete runs grouped by dataset example,<br/>
        ///     with repetition numbers that need to be run
        /// </summary>
        /// <param name="experimentId"></param>
        /// <param name="cursor">
        /// Cursor for pagination
        /// </param>
        /// <param name="limit">
        /// Maximum number of examples with incomplete runs to return<br/>
        /// Default Value: 50
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetIncompleteExperimentRunsResponseBody> GetIncompleteExperimentRunsAsync(
            string experimentId,
            string? cursor = default,
            int? limit = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}