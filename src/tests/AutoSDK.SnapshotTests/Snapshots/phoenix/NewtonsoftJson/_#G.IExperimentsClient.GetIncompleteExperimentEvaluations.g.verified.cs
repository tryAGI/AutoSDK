//HintName: G.IExperimentsClient.GetIncompleteExperimentEvaluations.g.cs
#nullable enable

namespace G
{
    public partial interface IExperimentsClient
    {
        /// <summary>
        /// Get incomplete evaluations for an experiment<br/>
        /// Get experiment runs that have incomplete evaluations.<br/>
        /// Returns runs with:<br/>
        /// - Missing evaluations (evaluator has not been run)<br/>
        /// - Failed evaluations (evaluator ran but has errors)<br/>
        /// Args:<br/>
        ///     experiment_id: The ID of the experiment<br/>
        ///     evaluation_name: List of evaluation names to check (required, at least one)<br/>
        ///     cursor: Cursor for pagination<br/>
        ///     limit: Maximum number of results to return<br/>
        /// Returns:<br/>
        ///     Paginated list of runs with incomplete evaluations
        /// </summary>
        /// <param name="experimentId"></param>
        /// <param name="evaluationName">
        /// Evaluation names to check<br/>
        /// Default Value: []
        /// </param>
        /// <param name="cursor">
        /// Cursor for pagination
        /// </param>
        /// <param name="limit">
        /// Maximum number of runs with incomplete evaluations to return<br/>
        /// Default Value: 50
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetIncompleteEvaluationsResponseBody> GetIncompleteExperimentEvaluationsAsync(
            string experimentId,
            global::System.Collections.Generic.IList<string>? evaluationName = default,
            string? cursor = default,
            int? limit = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}